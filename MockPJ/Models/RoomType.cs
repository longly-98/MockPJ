namespace MockPJ.Models
{
	public class RoomType : Base
	{
		public int RoomTypeID { get; set; }
		public string RoomName { get; set; }
		public ICollection<Room> Rooms { get; set; }
	}
}
