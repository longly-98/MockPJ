using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Specifications
{
	public class RateRepository : CommonRepository<Rate>, IRateRepository
	{
		private readonly BaseContext _context;

		public RateRepository(BaseContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<Rate>> GetListWithMoreInfoAsync(Expression<Func<Rate, bool>> filter = null)
		{
			return await _context.Rates.Include(h => h.Student).AsNoTracking().Where(filter).ToListAsync();
		}
	}
}
