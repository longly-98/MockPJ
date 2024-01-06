namespace MockPJ.Models
{
	public class Room : Base
	{
		public int RoomID { get; set; }
		public string RoomName { get; set; }
		public float RoomPrice { get; set; }
		public string Area { get; set; }
		public int MaxAmountOfPeople { get; set; }
		public int CurrentAmountOfPeople { get; set; }
		public int BuildingNumber { get; set; }
		public int FloorNumber { get; set; }
		public int StatusID { get; set; }
		public int RoomTypeID { get; set; }
		public int HouseID { get; set; }
		public int CreatedBy { get; set; }
		public int LastModifiedBy { get; set; }
	}
}
