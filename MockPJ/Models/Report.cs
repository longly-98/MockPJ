namespace MockPJ.Models
{
	public class Report : Base
	{
		public int ReportID { get; set; }
		public string ReportContent { get; set; }
		public int? HouseID { get; set; }
		public House House { get; set; }
		public int? StudentID { get; set; }
		public int? CreatedBy { get; set; }
		public int? LastModifiedBy { get; set; }
		public User Creator { get; set; }
		public User Modifier { get; set; }
		public User Student { get; set; }
	}
}
