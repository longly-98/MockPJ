using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IHouseRepository : ICommonRepository<House>
	{
		Task<List<House>> GetListWithMoreInfoAsync(Expression<Func<House, bool>> filter = null);
		Task<House> GetWithMoreInfoAsync(Expression<Func<House, bool>> filter = null);
	}
}
