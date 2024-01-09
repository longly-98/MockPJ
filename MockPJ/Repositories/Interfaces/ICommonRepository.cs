using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface ICommonRepository<T> where T : class
	{
		Task<T> GetAsync(Expression<Func<T, bool>> filter = null);
		Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
		Task<T> AddAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task<int> DeleteAsync(T entity);
		Task<List<T>> AddRangeAsync(List<T> entity);
		Task<List<T>> UpdateRangeAsync(List<T> entity);
	}
}
