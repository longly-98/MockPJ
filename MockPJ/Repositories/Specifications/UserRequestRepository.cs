using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Specifications
{
	public class UserRequestRepository : CommonRepository<UserRequest>, IUserRequestRepository
	{
		private readonly BaseContext _context;

		public UserRequestRepository(BaseContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<UserRequest>> GetUserRequestsList(Expression<Func<UserRequest, bool>> filter = null)
		{
			return await _context.UserRequests.Include(r => r.User).AsNoTracking().Where(filter).ToListAsync();
		}
	}
}
