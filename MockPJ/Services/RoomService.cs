using AutoMapper;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Services
{
	public class RoomService
	{
		private readonly IRoomRepository _roomRepository;
		private readonly IMapper _mapper;

		public RoomService(IRoomRepository roomRepository, IMapper mapper)
		{
			_roomRepository = roomRepository;
			_mapper = mapper;
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
