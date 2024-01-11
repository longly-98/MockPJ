using MockPJ.Models;
using MockPJ.Models.DTOs;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IUserRepository : ICommonRepository<User>
	{
		Task<User> GetWithRoleAsync(Expression<Func<User, bool>> filter = null);
		Task<User> GetLandLordDetailsAsync(Expression<Func<User, bool>> filter = null);
		Task<List<User>> GetLandLordStatisticList(Expression<Func<User, bool>> filter = null);
		Task<List<User>> GetLandLordList(Expression<Func<User, bool>> filter = null);
	}
}
