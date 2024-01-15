namespace MockPJ.Models.DTOs
{
	public class GetReportsListReturnDTO
	{
		public int ReportID { get; set; }
		public string StudentName { get; set; }
		public string HouseName { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string ReportContent { get; set; }
	}
}
