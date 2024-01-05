namespace MockPJ.Models
{
	public class Commune
	{
		public int CommuneID { get; set; }
		public string CommuneName { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
		public int DistrictID { get; set; }
		public District District { get; set; }
		public ICollection<Village> Villages { get; set; }
	}
}
