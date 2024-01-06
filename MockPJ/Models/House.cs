namespace MockPJ.Models
{
	public class House : Base
	{
		public int HouseID { get; set; }
		public string HouseName { get; set;}
		public string Information { get; set; }
		public int AddressID { get; set; }
		public int VillageID { get; set; }
		public int LandLordID { get; set; }
		public int CampusID { get; set; }
		public float PowerPrice { get; set; }
		public float WaterPrice { get; set; }
		public int CreatedBy { get; set; }
		public int LastModifiedBy { get; set;}
	}
}
