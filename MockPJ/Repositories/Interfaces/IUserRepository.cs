using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IUserRepository : ICommonRepository<User>
	{
		Task<User> GetWithRoleAsync(Expression<Func<User, bool>> filter = null);
	}
}
