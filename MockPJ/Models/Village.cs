using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class Village : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int VillageId { get; set; }
		public string VillageName { get; set; }
		public int CommuneID { get; set; }
		public Commune Commune { get; set; }
		public ICollection<House> Houses { get; set; }
	}
}
