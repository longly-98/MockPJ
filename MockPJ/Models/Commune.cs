namespace MockPJ.Models
{
	public class Commune : Base
	{
		public int CommuneID { get; set; }
		public string CommuneName { get; set; }
		public int DistrictID { get; set; }
		public District District { get; set; }
		public ICollection<Village> Villages { get; set; }
	}
}
