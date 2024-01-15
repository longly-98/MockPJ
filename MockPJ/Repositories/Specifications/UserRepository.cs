using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using System.Linq;
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

		public async Task<User> GetWithRoleAsync(Expression<Func<User, bool>> filter = null)
		{
			return await _context.Users.Include(u => u.Role).AsNoTracking().FirstOrDefaultAsync(filter);
		}

		public async Task<User> GetLandLordDetailsAsync(Expression<Func<User, bool>> filter = null)
		{
			return await _context.Users.Include(u => u.Address).AsNoTracking().FirstOrDefaultAsync(filter);
		}

		public async Task<List<User>> GetLandLordStatisticList(Expression<Func<User, bool>> filter = null)
		{
			 return await _context.Users.Include(u => u.Address).Include(u => u.OwnHouses).ThenInclude(x => x.Rooms).AsNoTracking().Where(filter).ToListAsync();
		}

		public async Task<List<User>> GetLandLordList(Expression<Func<User, bool>> filter = null)
		{
			return await _context.Users.Include(u => u.Address).AsNoTracking().Where(filter).ToListAsync();
		}
	}
}
