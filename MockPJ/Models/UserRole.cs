using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class UserRole : Base
	{
		[Key]
		public int RoleID { get; set; }
		public string RoleName { get; set; }
		public ICollection<User> Users { get; set; }
	}
}
