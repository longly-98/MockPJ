namespace MockPJ.Models
{
	public class Campus : Base
	{
		public int CampusId { get; set; }
		public string CampusName { get; set; }
		public int AddressID { get; set; }
		public Address Address { get; set; }
		public ICollection<House> Houses { get; set; }
	}
}
