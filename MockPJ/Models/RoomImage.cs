namespace MockPJ.Models
{
	public class RoomImage : Base
	{
		public int ImageID { get; set; }
		public string ImageLink { get; set; }
		public int RoomID { get; set; }
		public int CreatedBy { get; set; }
		public int LastModifiedBy { get; set; }
	}
}
