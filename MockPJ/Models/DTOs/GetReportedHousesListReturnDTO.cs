namespace MockPJ.Models.DTOs
{
	public class GetReportedHousesListReturnDTO
	{
		public int HouseID { get; set; }
		public string HouseName { get; set; }
		public string LandLordName { get; set; }
		public int ReportsCount { get; set; }
		public bool LandLordActive { get; set; }
	}
}
