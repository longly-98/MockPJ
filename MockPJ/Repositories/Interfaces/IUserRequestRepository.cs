using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IUserRequestRepository : ICommonRepository<UserRequest>
	{
		Task<List<UserRequest>> GetUserRequestsList(Expression<Func<UserRequest, bool>> filter = null);
	}
}
