namespace MockPJ.Models.DTOs
{
	public class ChangePasswordRequestDTO
	{
		public string Email { get; set; }
		public string CurrentPassword { get; set; }
		public string NewPassword { get; set; }
	}
}
