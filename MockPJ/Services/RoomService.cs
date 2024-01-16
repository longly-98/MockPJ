using AutoMapper;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Services
{
	public class RoomService : BaseService
	{
		private readonly IRoomRepository _roomRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public RoomService(IRoomRepository roomRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
			_roomRepository = roomRepository;
			_mapper = mapper;
			_httpContextAccessor = httpContextAccessor;
		}

		public async Task<List<GetRoomsReturnDTO>> GetHouseRooms(int id)
		{
			var rooms = await _roomRepository.GetListWithMoreInfoAsync(x => x.HouseID == id);

			return _mapper.Map<List<GetRoomsReturnDTO>>(rooms);
		}

		public async Task<GetRoomsReturnDTO> GetRoomDetails(int id)
		{
			var room = await _roomRepository.GetDetailsAsync(x => x.RoomID == id);

			return _mapper.Map<GetRoomsReturnDTO>(room);
		}
	}
}
