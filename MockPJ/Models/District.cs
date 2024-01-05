namespace MockPJ.Models
{
	public class District
	{
		public int DistrictID { get; set; }
		public string DistrictName { get; set;}
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
		public ICollection<Commune>	Communes { get; set; }
	}
}
