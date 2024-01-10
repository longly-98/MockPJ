using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models.DTOs
{
	public class CreateStaffDTO
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Username { get; set; }
	}
}
