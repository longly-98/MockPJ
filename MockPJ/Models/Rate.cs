namespace MockPJ.Models
{
	public class Rate : Base
	{
		public int RateID { get; set; }
		public int Star { get; set; }
		public string Comment { get; set; }
		public string LandLordReply { get; set; }
		public int HouseID { get; set; }
		public int? StudentID { get; set; }
		public int? CreatedBy { get; set; }
		public int? LastModifiedBy { get; set; }
		public User Creator { get; set; }
		public User Modifier { get; set; }
		public House House { get; set; }
		public User Student { get; set; }
	}
}
