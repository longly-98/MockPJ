namespace MockPJ.Models.DTOs
{
	public class GetRoomsReturnDTO
	{
		public int RoomID { get; set; }
		public string RoomName { get; set; }
		public float RoomPrice { get; set; }
		public string Area { get; set; }
		public int MaxAmountOfPeople { get; set; }
		public int CurrentAmountOfPeople { get; set; }
		public int BuildingNumber { get; set; }
		public int FloorNumber { get; set; }
		public string Status { get; set; }
		public string RoomType { get; set; }
		public List<HistoriesReturnDTO>? Histories { get; set; }
		public List<ImageReturnDTO>? Images { get; set; }
	}
}
