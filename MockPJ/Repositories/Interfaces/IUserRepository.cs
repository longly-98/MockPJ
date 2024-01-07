using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IUserRepository
	{
		Task<User> GetUserDetailAsync(Expression<Func<User, bool>> filter = null);
		Task<List<User>> GetUserListAsync(Expression<Func<User, bool>> filter = null);
		Task<User> AddUserAsync(User user);
		Task<User> UpdateUserAsync(User user);
		Task<int> DeleteUserAsync(User user);
	}
}
