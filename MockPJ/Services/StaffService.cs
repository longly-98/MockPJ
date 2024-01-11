using AutoMapper;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;

namespace MockPJ.Services
{
	public class StaffService
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserRoleRepository _roleRepository;
		private readonly IStatusRepository _statusRepository;
		private readonly IMapper _mapper;

		public StaffService(IUserRepository userRepository, IUserRoleRepository roleRepository, IStatusRepository statusRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_roleRepository = roleRepository;
			_statusRepository = statusRepository;
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

		public async Task<List<GetLandLordRegReturnDTO>> GetLandLordRegisterList(GetLandLordListRequestDTO req)
		{
			var roleLandLord = await _roleRepository.GetAsync(x => x.RoleName == "LandLord");
			var list = await _userRepository.GetLandLordList(x =>
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

			return _mapper.Map<List<GetLandLordRegReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}
	}
}
