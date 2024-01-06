namespace MockPJ.Models
{
	public class HouseImage : Base
	{
		public int ImageID { get; set; }
		public string ImageLink { get; set; }
		public int HouseID { get; set; }
		public int CreatedBy { get; set; }
		public int LastModifiedBy { get; set; }
	}
}
