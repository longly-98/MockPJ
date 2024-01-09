namespace MockPJ.Models.DTOs
{
	public class GetHousesReturnDTO
	{
		public int HouseId { get; set; }
		public string HouseName { get; set; }
		public string Information { get; set; }
		public float PowerPrice { get; set; }
		public float WaterPrice { get; set; }
		public string Address { get; set; }
		public string GoogleMapLocation { get; set; }
		public string CampusName { get; set; }
		public string VillageName { get; set; }
		public List<ImageReturnDTO> Images { get; set; }
	}
}
