using MockPJ.Models;
using MockPJ.Models.DTOs;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IHouseRepository : ICommonRepository<House>
	{
		Task<List<House>> GetListWithMoreInfoAsync(Expression<Func<House, bool>> filter = null);
		Task<House> GetWithMoreInfoAsync(Expression<Func<House, bool>> filter = null);
		Task<List<House>> GetLandLordHousesList(Expression<Func<House, bool>> filter = null);
		Task<List<House>> GetReportedListWithMoreInfoAsync(Expression<Func<House, bool>> filter = null);
	}
}
