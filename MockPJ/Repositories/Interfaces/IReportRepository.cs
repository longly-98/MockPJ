using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IReportRepository : ICommonRepository<Report>
	{
		Task<List<Report>> GetListWithHouseAsync(Expression<Func<Report, bool>> filter = null);
	}
}
