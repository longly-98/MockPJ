using AutoMapper;
using Microsoft.Win32;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;

namespace MockPJ.Services
{
	public class LandLordService : BaseService
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserRoleRepository _roleRepository;
		private readonly IAddressRepository _addressRepository;
		private readonly IHouseRepository _houseRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public LandLordService(IUserRepository userRepository, 
			IUserRoleRepository roleRepository, IAddressRepository addressRepository, 
			IHouseRepository houseRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
			_userRepository = userRepository;
			_roleRepository = roleRepository;
			_addressRepository = addressRepository;
			_houseRepository = houseRepository;
			_httpContextAccessor = httpContextAccessor;
			_mapper = mapper;
		}

		public async Task<GetLandLordDetailsReturnDTO> GetLandLordDetails(int id)
		{
			var landlordRole = await _roleRepository.GetAsync(x => x.RoleName == "LandLord");
			var user = await _userRepository.GetLandLordDetailsAsync(x => x.UserID == id && x.RoleID == landlordRole.RoleID);

			return _mapper.Map<GetLandLordDetailsReturnDTO>(user);
		}

		public async Task<User> CreateLandLordRegistration(CreateLandLordRegistrationDTO dto)
		{
			var mappedLandlord = _mapper.Map<User>(dto);
			mappedLandlord.Password = BCrypt.Net.BCrypt.HashPassword(dto.Password);

			var landlordRole = await _roleRepository.GetAsync(x => x.RoleName == "LandLord");
			mappedLandlord.RoleID = landlordRole.RoleID;

			if (dto.Address != null)
			{
				var address = await _addressRepository.AddAsync(_mapper.Map<Address>(dto.Address));
				mappedLandlord.AddressID = address.AddressID;
			}

			return await _userRepository.AddAsync(mappedLandlord);
		}

		public async Task<GetLandLordHousesListReturnDTO> GetLandLordHousesList(GetHousesRequestDTO dto)
		{
			var currentUser = GetCurrentUser();
			var list = await _houseRepository.GetHousesListWithRoomsAsync(x =>
				(!string.IsNullOrEmpty(dto.Keywords) ? x.HouseName.Contains(dto.Keywords) : true) &&
				(dto.CampusID.HasValue ? x.CampusID == dto.CampusID : true) &&
				(dto.VillageID.HasValue ? x.VillageID == dto.VillageID : true) && x.LandLordID == currentUser
			);

			var res = new GetLandLordHousesListReturnDTO();
			res.AvailableRooms = list.Select(x => x.Rooms.Where(r => r.Status.StatusName == "Available")).Count();
			res.TotalRooms = list.Count();

			if (dto.SortBy != null && dto.SortType != null)
			{
				var propertyInfo = typeof(House).GetProperty(dto.SortBy);
				if (propertyInfo != null)
				{
					var orderedList = dto.SortType?.ToLower() == "desc" ? list.OrderByDescending(x => propertyInfo?.GetValue(x, null)) : list.OrderBy(x => propertyInfo.GetValue(x, null));
					list = orderedList.ToList();
				}
			}

			var mappedList = _mapper.Map<List<GetHousesReturnDTO>>(list.Skip((dto.Page - 1) * dto.PageSize).Take(dto.PageSize));
			res.Houses = mappedList;

			return res;
		}
	}
}
