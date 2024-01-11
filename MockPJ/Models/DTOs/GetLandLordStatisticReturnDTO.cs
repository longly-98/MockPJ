namespace MockPJ.Models.DTOs
{
	public class GetLandLordStatisticReturnDTO
	{
		public GetLandLordDetailsReturnDTO LandLordDetails { get; set; }
		public int? HouseCount { get; set; }
		public int? TotalRoomCount { get; set; }
		public int? AvailableRoomCount { get; set; }
	}
}
