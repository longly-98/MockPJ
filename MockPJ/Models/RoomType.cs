namespace MockPJ.Models
{
	public class RoomType : Base
	{
		public int RoomTypeID { get; set; }
		public string RoomTypeName { get; set; }
		public ICollection<Room> Rooms { get; set; }
	}
}
