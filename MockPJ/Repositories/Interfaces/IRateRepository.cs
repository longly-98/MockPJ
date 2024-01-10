using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IRateRepository : ICommonRepository<Rate>
	{
		Task<List<Rate>> GetListWithMoreInfoAsync(Expression<Func<Rate, bool>> filter = null);
	}
}
