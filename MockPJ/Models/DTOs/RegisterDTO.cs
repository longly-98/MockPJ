using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models.DTOs
{
	public class RegisterDTO
	{
		[Required]
		public string Email { get; set; } = null!;
		[Required]
		public string Password { get; set; } = null!;
		[Required]
		public string Username { get; set; } = null!;
		[Required]
		public string Role { get; set; } = null!;
	}
}
