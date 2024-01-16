namespace MockPJ.Models.DTOs
{
	public class CreateRoomRequestDTO
	{
		public string RoomName { get; set; }
		public float? RoomPrice { get; set; }
		public string? Area { get; set; }
		public int? MaxAmountOfPeople { get; set; }
		public int? CurrentAmountOfPeople { get; set; }
		public int? BuildingNumber { get; set; }
		public int? FloorNumber { get; set; }
		public int? RoomTypeID { get; set; }
		public string RoomStatus { get; set; }
		public List<CreateImageRequestDTO> Images { get; set; }
	}
}
