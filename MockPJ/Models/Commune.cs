using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class Commune : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CommuneID { get; set; }
		public string CommuneName { get; set; }
		public int DistrictID { get; set; }
		public District District { get; set; }
		public ICollection<Village> Villages { get; set; }
	}
}
