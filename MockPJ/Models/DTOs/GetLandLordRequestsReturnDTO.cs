namespace MockPJ.Models.DTOs
{
	public class GetLandLordRequestsReturnDTO
	{
		public int RequestID { get; set; }
		public string? Description { get; set; }
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime LastModifiedDate { get; set; }
		public GetLandLordDetailsReturnDTO LandLordDetails { get; set; }
	}
}
