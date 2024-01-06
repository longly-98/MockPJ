using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models
{
	public class RoomImage : Base
	{
		[Key]
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
