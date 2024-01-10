using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class HouseImage : Base
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ImageID { get; set; }
		public string ImageLink { get; set; }
		public int HouseID { get; set; }
		public House House { get; set; }
		public int? CreatedBy { get; set; }
		public int? LastModifiedBy { get; set; }
		public User Creator { get; set; }
		public User Modifier { get; set; }
	}
}
