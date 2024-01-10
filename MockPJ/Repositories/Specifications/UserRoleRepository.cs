using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class UserRoleRepository : CommonRepository<UserRole>, IUserRoleRepository
	{
		public UserRoleRepository(BaseContext context) : base(context)
		{
		}
	}
}
