using AutoMapper;
using Microsoft.Win32;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Utilities.CustomException;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MockPJ.Services
{
	public class LandLordService : BaseService
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserRoleRepository _roleRepository;
		private readonly IAddressRepository _addressRepository;
		private readonly IHouseRepository _houseRepository;
		private readonly IHouseImageRepository _houseImageRepository;
		private readonly ICampusRepository _campusRepository;
		private readonly IVillageRepository _villageRepository;
		private readonly IRateRepository _ratingRepository;
		private readonly IStatusRepository _statusRepository;
		private readonly IRoomRepository _roomRepository;
		private readonly IRoomImageRepository _roomImageRepository;
		private readonly IRoomTypeRepository _roomTypeRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public LandLordService(IUserRepository userRepository,
			IUserRoleRepository roleRepository, IAddressRepository addressRepository,
			IHouseRepository houseRepository, IHouseImageRepository houseImageRepository,
			IVillageRepository villageRepository, ICampusRepository campusRepository,
			IRateRepository ratingRepository, IStatusRepository statusRepository, IRoomImageRepository roomImageRepository,
			IMapper mapper, IHttpContextAccessor httpContextAccessor, IRoomRepository roomRepository, IRoomTypeRepository roomTypeRepository) : base(httpContextAccessor)
		{
			_userRepository = userRepository;
			_roleRepository = roleRepository;
			_addressRepository = addressRepository;
			_houseRepository = houseRepository;
			_httpContextAccessor = httpContextAccessor;
			_houseImageRepository = houseImageRepository;
			_campusRepository = campusRepository;
			_villageRepository = villageRepository;
			_ratingRepository = ratingRepository;
			_statusRepository = statusRepository;
			_roomRepository = roomRepository;
			_roomImageRepository = roomImageRepository;
			_mapper = mapper;
			_roomTypeRepository = roomTypeRepository;
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

		public async Task<int> CreateHouse(CreateHouseRequestDTO dto)
		{
			var currentUser = GetCurrentUser();
			int houseID = 0;

			var village = await _villageRepository.GetAsync(x => x.VillageId == dto.VillageID);
			if (village == null)
			{
				throw new NotFoundException("Village not found");
			}

			var campus = await _campusRepository.GetAsync(x => x.CampusId == dto.CampusID);
			if (campus == null)
			{
				throw new NotFoundException("Campus not found");
			}

			using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
			{
				try
				{
					var addresss = await _addressRepository.AddAsync(_mapper.Map<Address>(dto.Address));

					var mappedHouse = _mapper.Map<House>(dto);
					mappedHouse.LandLordID = currentUser;
					mappedHouse.CreatedBy = currentUser;
					var house = await _houseRepository.AddAsync(mappedHouse);

					var mappedImages = _mapper.Map<List<HouseImage>>(dto.Images);
					mappedImages.ForEach(i =>
					{
						i.CreatedBy = currentUser;
						i.HouseID = house.HouseID;
					});
					var images = await _houseImageRepository.AddRangeAsync(mappedImages);

					houseID = house.HouseID;
					scope.Complete();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally { scope.Dispose(); }
			}

			return houseID;
		}

		public async Task<int> UpdateHouse(int id, CreateHouseRequestDTO dto)
		{
			var currentUser = GetCurrentUser();
			int houseID = 0;

			var currentHouse = await _houseRepository.GetAsync(x => x.HouseID == id);
			if (currentHouse == null)
			{
				throw new NotFoundException("House not found");
			}

			if (dto.VillageID != null && currentHouse.VillageID != dto.VillageID)
			{
				var village = await _villageRepository.GetAsync(x => x.VillageId == dto.VillageID);
				if (village == null)
				{
					throw new NotFoundException("Village not found");
				}
			}

			if (dto.CampusID != null && currentHouse.CampusID != dto.CampusID)
			{
				var campus = await _campusRepository.GetAsync(x => x.CampusId == dto.CampusID);
				if (campus == null)
				{
					throw new NotFoundException("Campus not found");
				}
			}

			using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
			{
				try
				{
					var addresss = await _addressRepository.UpdateAsync(_mapper.Map<Address>(dto.Address));

					var mappedHouse = _mapper.Map<House>(dto);
					mappedHouse.HouseID = id;
					var house = await _houseRepository.UpdateAsync(mappedHouse);

					var mappedImages = _mapper.Map<List<HouseImage>>(dto.Images);
					mappedImages.ForEach(i =>
					{
						i.CreatedBy = currentUser;
						i.HouseID = house.HouseID;
					});
					var images = await _houseImageRepository.UpdateRangeAsync(mappedImages);

					houseID = house.HouseID;
					scope.Complete();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally { scope.Dispose(); }
			}

			return houseID;
		}

		public async Task DeleteHouse(int id)
		{
			var currentHouse = await _houseRepository.GetAsync(x => x.HouseID == id);
			if (currentHouse == null)
			{
				throw new NotFoundException("House not found");
			}

			try
			{
				var address = await _addressRepository.GetAsync(x => x.AddressID == currentHouse.AddressID);
				if (address != null)
				{
					await _addressRepository.DeleteAsync(address);
				}
				await _houseRepository.DeleteAsync(currentHouse);
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		public async Task ReplyComment(int id, ReplyCommentRequestDTO dto)
		{
			var currentUser = GetCurrentUser();

			var rate = await _ratingRepository.GetAsync(x => x.RateID == id);
			rate.LandLordReply = dto.Comment;
			rate.LastModifiedBy = currentUser;
			rate.LastModifiedDate = DateTime.UtcNow;

			try
			{
				await _ratingRepository.UpdateAsync(rate);
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		public async Task<int> CreateRoom(int id, CreateRoomRequestDTO dto)
		{
			var currentUser = GetCurrentUser();
			int roomID = 0;

			var currentHouse = await _houseRepository.GetAsync(x => x.HouseID == id);
			if (currentHouse == null)
			{
				throw new NotFoundException("House not found");
			}

			var status = await _statusRepository.GetAsync(x => x.StatusName == dto.RoomStatus);
			if (status == null)
			{
				throw new NotFoundException($"Status {dto.RoomStatus} not found");
			}

			var roomType = await _roomTypeRepository.GetAsync(x => x.RoomTypeID == dto.RoomTypeID);
			if (roomType == null)
			{
				throw new NotFoundException($"Room type {dto.RoomTypeID} not found");
			}

			using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
			{
				try
				{
					var mappedRoom = _mapper.Map<Room>(dto);
					mappedRoom.HouseID = currentHouse.HouseID;
					mappedRoom.CreatedBy = currentUser;
					mappedRoom.StatusID = status.StatusID;
					mappedRoom.RoomTypeID = roomType.RoomTypeID;
					var room = await _roomRepository.AddAsync(mappedRoom);

					var mappedImages = _mapper.Map<List<RoomImage>>(dto.Images);
					mappedImages.ForEach(i =>
					{
						i.CreatedBy = currentUser;
						i.RoomID = room.RoomID;
					});
					var images = await _roomImageRepository.AddRangeAsync(mappedImages);

					roomID = room.RoomID;
					scope.Complete();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally { scope.Dispose(); }
			}

			return roomID;
		}

		public async Task<int> UpdateRoom(int id, int HouseID, CreateRoomRequestDTO dto)
		{
			var currentUser = GetCurrentUser();
			int roomID = 0;

			var status = await _statusRepository.GetAsync(x => x.StatusName == dto.RoomStatus);
			if (status == null)
			{
				throw new NotFoundException($"Status {dto.RoomStatus} not found");
			}

			var roomType = await _roomTypeRepository.GetAsync(x => x.RoomTypeID == dto.RoomTypeID);
			if (roomType == null)
			{
				throw new NotFoundException($"Room type {dto.RoomTypeID} not found");
			}

			var currentRoom = await _roomRepository.GetAsync(x => x.RoomID == id);
			if (currentRoom == null)
			{
				throw new NotFoundException("Room not found");
			}

			var currentHouse = await _houseRepository.GetAsync(x => x.HouseID == HouseID);
			if (currentHouse == null)
			{
				throw new NotFoundException("House not found");
			}

			using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
			{
				try
				{
					var mappedRoom = _mapper.Map<Room>(dto);
					mappedRoom.StatusID = status.StatusID;
					mappedRoom.RoomTypeID = roomType.RoomTypeID;
					mappedRoom.RoomID = id;
					mappedRoom.HouseID = currentHouse.HouseID;
					var room = await _roomRepository.UpdateAsync(mappedRoom);

					var mappedImages = _mapper.Map<List<RoomImage>>(dto.Images);
					mappedImages.ForEach(i =>
					{
						i.CreatedBy = currentUser;
						i.RoomID = room.RoomID;
					});
					var images = await _roomImageRepository.UpdateRangeAsync(mappedImages);

					roomID = room.RoomID;
					scope.Complete();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally { scope.Dispose(); }
			}

			return roomID;
		}

		public async Task<int> UpdateRoomStatus(int id, int HouseID, UpdateRoomStatusRequestDTO dto)
		{
			var currentUser = GetCurrentUser();
			int roomID = 0;

			var status = await _statusRepository.GetAsync(x => x.StatusName == dto.Status);
			if (status == null)
			{
				throw new NotFoundException($"Status {dto.Status} not found");
			}

			var currentRoom = await _roomRepository.GetAsync(x => x.RoomID == id);
			if (currentRoom == null)
			{
				throw new NotFoundException("Room not found");
			}

			var currentHouse = await _houseRepository.GetAsync(x => x.HouseID == HouseID);
			if (currentHouse == null)
			{
				throw new NotFoundException("House not found");
			}

			try
			{
				currentRoom.StatusID = status.StatusID;
				var room = await _roomRepository.UpdateAsync(currentRoom);

				roomID = room.RoomID;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return roomID;
		}

		public async Task DeleteRoom(int id)
		{
			var currentRoom = await _roomRepository.GetAsync(x => x.RoomID == id);
			if (currentRoom == null)
			{
				throw new NotFoundException("Room not found");
			}

			try
			{
				await _roomRepository.DeleteAsync(currentRoom);
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

	}
}
