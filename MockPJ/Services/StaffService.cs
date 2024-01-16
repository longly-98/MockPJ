using AutoMapper;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Utilities.CustomException;

namespace MockPJ.Services
{
	public class StaffService : BaseService
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserRoleRepository _roleRepository;
		private readonly IStatusRepository _statusRepository;
		private readonly IUserRequestRepository _userRequestRepository;
		private readonly IHouseRepository _houseRepository;
		private readonly IReportRepository _reportRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public StaffService(IUserRepository userRepository, IUserRoleRepository roleRepository, IStatusRepository statusRepository, IUserRequestRepository userRequestRepository,
			 IHouseRepository houseRepository, IReportRepository reportRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
			_userRepository = userRepository;
			_roleRepository = roleRepository;
			_statusRepository = statusRepository;
			_userRequestRepository = userRequestRepository;
			_houseRepository = houseRepository;
			_reportRepository = reportRepository;
			_mapper = mapper;
			_httpContextAccessor = httpContextAccessor;
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
			}
			catch (Exception ex)
			{
				throw new UpdateFailException("Fail to update landlord status");
			}
		}

		public async Task ChangeLandLordRequestStatus(int id, ChangeUserRequestStatusRequestDTO dto)
		{
			var request = await _userRequestRepository.GetAsync(x => x.RequestID == id);

			if (request == null)
			{
				throw new NotFoundException("Request not found");
			}

			var landlord = await _userRepository.GetAsync(x => x.UserID == request.UserID);
			if (landlord == null)
			{
				throw new NotFoundException("LandLord of this request not found");
			}

			try
			{
				request.Status = dto.Status;
				await _userRequestRepository.UpdateAsync(request);

				if (dto.Status == RequestStatus.Resolved)
				{
					landlord.Verified = true;
					landlord.VerrifiedAt = DateTime.UtcNow;
					await _userRepository.UpdateAsync(landlord);
				}
			}
			catch (Exception ex)
			{
				throw new UpdateFailException("Fail to update landlord request");
			}
		}

		public async Task<List<GetReportsListReturnDTO>> GetReportsList(GetReportsListRequestDTO req)
		{
			var list = await _reportRepository.GetListWithHouseAsync(x => 
				(!string.IsNullOrEmpty(req.Keywords) ? x.House.HouseName.Contains(req.Keywords) || x.Student.DisplayName.Contains(req.Keywords) : true));

			if (req.SortBy != null && req.SortType != null)
			{
				var propertyInfo = typeof(Report).GetProperty(req.SortBy);
				if (propertyInfo != null)
				{
					var orderedList = req.SortType?.ToLower() == "desc" ? list.OrderByDescending(x => propertyInfo?.GetValue(x, null)) : list.OrderBy(x => propertyInfo.GetValue(x, null));
					list = orderedList.ToList();
				}
			}

			return _mapper.Map<List<GetReportsListReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}

		public async Task<List<GetReportedHousesListReturnDTO>> GetReportsList(GetReportedHousesListRequestDTO req)
		{
			var list = await _houseRepository.GetReportedListWithMoreInfoAsync(x =>
				(!string.IsNullOrEmpty(req.Keywords) ? x.HouseName.Contains(req.Keywords) || x.LandLord.DisplayName.Contains(req.Keywords) : true) &&
				x.Reports.Count > 0
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

			return _mapper.Map<List<GetReportedHousesListReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}

		public async Task<List<GetReportsListReturnDTO>> GetReportsListByHouse(int id, GetReportsListRequestDTO req)
		{
			var list = await _reportRepository.GetListWithHouseAsync(x =>
				(!string.IsNullOrEmpty(req.Keywords) ? x.ReportContent.Contains(req.Keywords) : true) &&
				x.HouseID == id
			);

			if (req.SortBy != null && req.SortType != null)
			{
				var propertyInfo = typeof(Report).GetProperty(req.SortBy);
				if (propertyInfo != null)
				{
					var orderedList = req.SortType?.ToLower() == "desc" ? list.OrderByDescending(x => propertyInfo?.GetValue(x, null)) : list.OrderBy(x => propertyInfo.GetValue(x, null));
					list = orderedList.ToList();
				}
			}

			return _mapper.Map<List<GetReportsListReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}

		public async Task<List<GetStudentOrdersReturnDTO>> GetStudentOrdersList(GetStudentOrdersRequestDTO req)
		{
			var roleStudent = await _roleRepository.GetAsync(x => x.RoleName == "Student");
			var list = await _userRequestRepository.GetUserRequestsList(x =>
				(!string.IsNullOrEmpty(req.Keywords) ? x.User.DisplayName.Contains(req.Keywords) : true) && x.User.RoleID == roleStudent.RoleID && x.RequestType == RequestType.StudentRequest
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

			return _mapper.Map<List<GetStudentOrdersReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}

		public async Task ChangeStudentOrderStatus(int id, ChangeUserRequestStatusRequestDTO dto)
		{
			var request = await _userRequestRepository.GetAsync(x => x.RequestID == id);

			if (request == null)
			{
				throw new NotFoundException("Request not found");
			}

			try
			{
				request.Status = dto.Status;
				await _userRequestRepository.UpdateAsync(request);
			}
			catch (Exception ex)
			{
				throw new UpdateFailException("Fail to update order");
			}
		}
	}
}
