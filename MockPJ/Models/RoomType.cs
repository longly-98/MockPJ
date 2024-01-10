using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class RoomType : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RoomTypeID { get; set; }
		public string RoomTypeName { get; set; }
		public ICollection<Room> Rooms { get; set; }
	}
}
