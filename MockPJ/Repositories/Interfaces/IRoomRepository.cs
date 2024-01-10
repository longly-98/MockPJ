using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IRoomRepository : ICommonRepository<Room>
	{
		Task<List<Room>> GetListWithMoreInfoAsync(Expression<Func<Room, bool>> filter = null);
		Task<Room> GetDetailsAsync(Expression<Func<Room, bool>> filter = null);
	}
}
