using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Specifications
{
	public class RoomRepository : CommonRepository<Room>, IRoomRepository
	{
		private readonly BaseContext _context;

		public RoomRepository(BaseContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<Room>> GetListWithMoreInfoAsync(Expression<Func<Room, bool>> filter = null)
		{
			return await _context.Rooms.Include(x => x.Status).Include(x => x.RoomType).AsNoTracking().Where(filter).ToListAsync();
		}

		public async Task<Room> GetDetailsAsync(Expression<Func<Room, bool>> filter = null)
		{
			return await _context.Rooms.Include(x => x.Status).Include(x => x.RoomType).Include(x => x.RoomHistories).Include(x => x.RoomImages).AsNoTracking().FirstOrDefaultAsync(filter);
		}
	}
}
