using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models.DTOs
{
	public class AdminUpdateStaffDTO
	{

		[Required]
		[EmailAddress]
		public string Email { get; set; } = null!;
		[Required]
		public string DisplayName { get; set; } = null!;
		[Required]
		public bool Active { get; set; }
	}
}
