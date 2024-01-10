using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models.DTOs
{
	public class CreateReportDTO
	{
		[Required]
		public string? ReportContent { get; set; }
		[Required]
		public int? HouseID { get; set; }
		[Required]
		public int? StudentID { get; set; }
	}
}
