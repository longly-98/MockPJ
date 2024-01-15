namespace MockPJ.Models.DTOs
{
	public class GetStudentDetailsReturnDTO
	{
		public int UserID { get; set; }
		public string Email { get; set; }
		public string DisplayName { get; set; }
		public string? ProfileImageLink { get; set; }
		public string? PhoneNumber { get; set; }
		public string? Address { get; set; }
		public bool? Active { get; set; }
	}
}
