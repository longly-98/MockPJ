using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models.DTOs
{
	public class CreateLandLordRegistrationDTO
	{
		[EmailAddress]
		public string? Email { get; set; }
		public string DisplayName { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string? ProfileImageLink { get; set; }
		public string FacebookURL { get; set; }
		public string? IdentityCardFrontSideImageLink { get; set; }
		public string? IdentityCardBackSideImageLink { get; set; }
		public CreateAddressDTO? Address { get; set; }
	}
}
