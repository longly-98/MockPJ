namespace MockPJ.Models
{
	public class Village
	{
		public int VillageId { get; set; }
		public string VillageName { get; set; }
		public int CommuneID { get; set; }
		public Commune Commune { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
	}
}
