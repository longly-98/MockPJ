using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Specifications
{
	public class HouseRepository : CommonRepository<House>, IHouseRepository
	{
		private readonly BaseContext _context;
		public HouseRepository(BaseContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<House>> GetListWithMoreInfoAsync(Expression<Func<House, bool>> filter = null)
		{
			return await _context.Houses.Include(h => h.Address).Include(h => h.Village).Include(h => h.Campus).Include(h => h.LandLord).Include(h => h.HouseImages).AsNoTracking().Where(filter).ToListAsync();
		}

		public async Task<House> GetWithMoreInfoAsync(Expression<Func<House, bool>> filter = null)
		{
			return await _context.Houses.Include(h => h.Address).Include(h => h.Village).Include(h => h.Campus).Include(h => h.HouseImages).AsNoTracking().FirstOrDefaultAsync(filter);
		}

		public async Task<List<House>> GetLandLordHousesList(Expression<Func<House, bool>> filter = null)
		{
			return await _context.Houses.Include(h => h.Address).Include(h => h.Village).Include(h => h.Campus).Include(h => h.LandLord).Include(h => h.HouseImages).AsNoTracking().Where(filter).ToListAsync();
		}

		public async Task<List<House>> GetReportedListWithMoreInfoAsync(Expression<Func<House, bool>> filter = null)
		{
			return await _context.Houses.Include(h => h.Address).Include(h => h.Village).Include(h => h.Campus).Include(h => h.LandLord).Include(h => h.HouseImages).Include(h => h.Reports).AsNoTracking().Where(filter).ToListAsync();
		}
	}
}
