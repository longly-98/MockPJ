namespace MockPJ.Models.DTOs
{
	public class GetLandLordHousesListReturnDTO
	{
		public List<GetHousesReturnDTO> Houses { get; set; }
		public int AvailableRooms { get; set; } = 0;
		public int TotalRooms { get; set; } = 0;
	}
}
