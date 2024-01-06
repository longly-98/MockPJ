namespace MockPJ.Models
{
	public class Village : Base
	{
		public int VillageId { get; set; }
		public string VillageName { get; set; }
		public int CommuneID { get; set; }
		public Commune Commune { get; set; }
		public ICollection<House> Houses { get; set; }
	}
}
