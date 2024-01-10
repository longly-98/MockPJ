using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class RoomImage : Base
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ImageID { get; set; }
		public string ImageLink { get; set; }
		public int RoomID { get; set; }
		public Room Room { get; set; }
		public int? CreatedBy { get; set; }
		public int? LastModifiedBy { get; set; }
		public User Creator { get; set; }
		public User Modifier { get; set; }
	}
}
