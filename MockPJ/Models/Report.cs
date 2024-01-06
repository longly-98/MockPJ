namespace MockPJ.Models
{
	public class Report : Base
	{
		public int ReportID { get; set; }
		public string ReportContent { get; set; }
		public int HouseID { get; set; }
		public int StudentID { get; set; }
		public int CreatedBy { get; set; }
		public int LastModifiedBy { get; set; }
	}
}
