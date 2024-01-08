namespace MockPJ.Models
{
	public class Address : Base
	{
		public int AddressID { get; set; }
		public string Addresses { get; set; }
		public string GoogleMapLocation { get; set; }
		public House House { get; set; }
		public ICollection<Campus> Campuses { get; set; }
		public ICollection<User> Users { get; set; }
	}
}
