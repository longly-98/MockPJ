using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Specifications
{
	public class ReportRepository : CommonRepository<Report>, IReportRepository
	{
		private readonly BaseContext _context;
		public ReportRepository(BaseContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<Report>> GetListWithHouseAsync(Expression<Func<Report, bool>> filter = null)
		{
			return await _context.Reports.Include(r => r.House).Include(r => r.Student).AsNoTracking().Where(filter).ToListAsync();
		}
	}
}
