using AutoMapper;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Utilities.CustomException;

namespace MockPJ.Services
{
	public class StaffService
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserRoleRepository _roleRepository;
		private readonly IStatusRepository _statusRepository;
		private readonly IUserRequestRepository _userRequestRepository;
		private readonly IHouseRepository _houseRepository;
		private readonly IMapper _mapper;

		public StaffService(IUserRepository userRepository, IUserRoleRepository roleRepository, IStatusRepository statusRepository, IUserRequestRepository userRequestRepository,
			 IHouseRepository houseRepository,IMapper mapper)
		{
			_userRepository = userRepository;
			_roleRepository = roleRepository;
			_statusRepository = statusRepository;
			_userRequestRepository = userRequestRepository;
			_houseRepository = houseRepository;
			_mapper = mapper;
		}

		public async Task<List<GetLandLordStatisticReturnDTO>> GetLandLordStatisticList(GetLandLordListRequestDTO req)
		{
			var roleLandLord = await _roleRepository.GetAsync(x => x.RoleName == "LandLord");
			var list = await _userRepository.GetLandLordStatisticList(x =>
				(!string.IsNullOrEmpty(req.Keywords) ? x.DisplayName.Contains(req.Keywords) : true) && x.RoleID == roleLandLord.RoleID
			);

			if (req.SortBy != null && req.SortType != null)
			{
				var propertyInfo = typeof(User).GetProperty(req.SortBy);
				if (propertyInfo != null)
				{
					var orderedList = req.SortType?.ToLower() == "desc" ? list.OrderByDescending(x => propertyInfo?.GetValue(x, null)) : list.OrderBy(x => propertyInfo.GetValue(x, null));
					list = orderedList.ToList();
				}
			}

			var availabelStatus = await _statusRepository.GetAsync(x => x.StatusName == "Available");
			var detailList = list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize).Select(x => new GetLandLordStatisticReturnDTO
			{
				LandLordDetails = _mapper.Map<GetLandLordDetailsReturnDTO>(x),
				HouseCount = x.OwnHouses.Count(),
				TotalRoomCount = x.OwnHouses.SelectMany(h => h.Rooms).Count(),
				AvailableRoomCount = x.OwnHouses.SelectMany(h => h.Rooms.Where(r => r.StatusID == availabelStatus.StatusID)).Count()
			}).ToList();

			return detailList;
		}

		public async Task<List<GetLandLordRequestsReturnDTO>> GetLandLordRegisterList(GetLandLordListRequestDTO req)
		{
			var roleLandLord = await _roleRepository.GetAsync(x => x.RoleName == "LandLord");
			var list = await _userRequestRepository.GetUserRequestsList(x =>
				(!string.IsNullOrEmpty(req.Keywords) ? x.User.DisplayName.Contains(req.Keywords) : true) && x.User.RoleID == roleLandLord.RoleID && x.RequestType == RequestType.Register
			);

			if (req.SortBy != null && req.SortType != null)
			{
				var propertyInfo = typeof(UserRequest).GetProperty(req.SortBy);
				if (propertyInfo != null)
				{
					var orderedList = req.SortType?.ToLower() == "desc" ? list.OrderByDescending(x => propertyInfo?.GetValue(x, null)) : list.OrderBy(x => propertyInfo.GetValue(x, null));
					list = orderedList.ToList();
				}
			}

			return _mapper.Map<List<GetLandLordRequestsReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}

		public async Task<List<GetHousesReturnDTO>> GetLandLordHousesList(int id, GetHousesRequestDTO req)
		{
			var list = await _houseRepository.GetLandLordHousesList(x =>
				(!string.IsNullOrEmpty(req.Keywords) ? x.HouseName.Contains(req.Keywords) : true) &&
				(req.CampusID.HasValue ? x.CampusID == req.CampusID : true) &&
				(req.VillageID.HasValue ? x.VillageID == req.VillageID : true) && x.LandLordID == id
			);

			if (req.SortBy != null && req.SortType != null)
			{
				var propertyInfo = typeof(House).GetProperty(req.SortBy);
				if (propertyInfo != null)
				{
					var orderedList = req.SortType?.ToLower() == "desc" ? list.OrderByDescending(x => propertyInfo?.GetValue(x, null)) : list.OrderBy(x => propertyInfo.GetValue(x, null));
					list = orderedList.ToList();
				}
			}

			return _mapper.Map<List<GetHousesReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}

		public async Task ChangeLandLordStatus(int id, ChangeUserStatusRequestDTO dto)
		{
			var user = await _userRepository.GetAsync(x => x.UserID == id);

			if (user == null)
			{
				throw new NotFoundException("LandLord not found");
			}

			try
			{
				user.Active = dto.Active;
				await _userRepository.UpdateAsync(user);
			} catch (Exception ex)
			{
				throw new UpdateFailException("Fail to update landlord status");
			}
		}
	}
}
