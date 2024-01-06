namespace MockPJ.Models
{
	public class RoomHistory : Base
	{
		public int RoomHistoryID { get; set; }
		public string CustomerName { get; set; }
		public int RoomID { get; set; }
		public int CreatedBy { get; set; }
		public int LastModifiedBy { get; set; }
	}
}
