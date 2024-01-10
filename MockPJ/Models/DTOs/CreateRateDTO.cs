using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models.DTOs
{
	public class CreateRateDTO
	{
		[Required(ErrorMessage = "required")]
		public int? Star { get; set; }
		public string? Comment { get; set; }
		public string? LandLordReply { get; set; }
		[Required]
		public int? HouseID { get; set; }
		[Required]
		public int? StudentID { get; set; }
		public int? CreatedBy { get; set; }
	}
}
