namespace MockPJ.Models.DTOs
{
	public class GetRatesReturnDTO
	{
		public int RateId { get; set; }
		public int Star {  get; set; }
		public string? Comment { get; set; }
		public string? LandLordReply { get; set; }
		public string StudentName { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? LastModifiedDate { get; set;}
	}
}
