using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Specifications
{
	public class UserRepository : CommonRepository<User>, IUserRepository
	{
		private readonly BaseContext _context;
		public UserRepository(BaseContext context) : base(context)
		{
			_context = context;
		}

		public async Task<User> GetWithRoleAsync(Expression<Func<User, bool>> filter = null, CancellationToken cancellationToken = default)
		{
			return await _context.Users.Include(u => u.Role).AsNoTracking().FirstOrDefaultAsync(filter, cancellationToken);
		}
	}
}
