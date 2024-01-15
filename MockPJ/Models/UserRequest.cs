using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace MockPJ.Models
{
	public class UserRequest : Base
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RequestID { get; set; }
		public int UserID { get; set; }
		public string? Description { get; set; }
		public RequestStatus Status { get; set; }
		public RequestType RequestType { get; set; }

		public User User { get; set; }
	}
}
