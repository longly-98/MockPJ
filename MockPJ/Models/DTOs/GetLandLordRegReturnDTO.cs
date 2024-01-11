namespace MockPJ.Models.DTOs
{
	public class GetLandLordRegReturnDTO : GetLandLordDetailsReturnDTO
	{
		public bool? Verified { get; set; }
		public DateTime? VerifiedAt { get; set; }
	}
}
