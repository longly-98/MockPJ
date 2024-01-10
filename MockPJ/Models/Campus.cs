using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class Campus : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CampusId { get; set; }
		public string CampusName { get; set; }
		public int AddressID { get; set; }
		public Address Address { get; set; }
		public ICollection<House> Houses { get; set; }
	}
}
