namespace MockPJ.Models
{
	public class RoomHistory : Base
	{
		public int RoomHistoryID { get; set; }
		public string CustomerName { get; set; }
		public int? RoomID { get; set; }
		public Room Room { get; set; }
		public int? CreatedBy { get; set; }
		public int? LastModifiedBy { get; set; }
		public User Creator { get; set; }
		public User Modifier { get; set; }
	}
}
