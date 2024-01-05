namespace MockPJ.Models
{
	public class House
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
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
		public int CreatedBy { get; set; }
		public DateTime LastModifiedDated { get; set; }
		public int LastModifiedBy { get; set;}
	}
}
