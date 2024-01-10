using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class District : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DistrictID { get; set; }
		public string DistrictName { get; set; }
		public ICollection<Commune> Communes { get; set; }
	}
}
