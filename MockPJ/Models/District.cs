namespace MockPJ.Models
{
	public class District : Base
	{
		public int DistrictID { get; set; }
		public string DistrictName { get; set;}
		public ICollection<Commune>	Communes { get; set; }
	}
}
