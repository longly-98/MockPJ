namespace MockPJ.Models.DTOs
{
	public class CreateHouseRequestDTO
	{
		public string HouseName { get; set; }
		public string Information { get; set; }
		public CreateAddressDTO? Address { get; set; }
		public int? VillageID { get; set; }
		public int? CampusID { get; set; }
		public float PowerPrice { get; set; }
		public float WaterPrice { get; set; }
		public List<CreateImageRequestDTO> Images { get; set; }
	}
}
