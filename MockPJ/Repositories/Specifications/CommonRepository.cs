using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Specifications
{
	public class CommonRepository<T> : ICommonRepository<T> where T : class
	{
		private readonly BaseContext _context;

		public CommonRepository(BaseContext context)
		{
			_context = context;
		}

		public async Task<T> AddAsync(T entity)
		{
			await _context.AddAsync(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task<List<T>> AddRangeAsync(List<T> entities)
		{
			await _context.AddRangeAsync(entities);
			await _context.SaveChangesAsync();
			return entities;
		}

		public async Task<int> DeleteAsync(T entity)
		{
			_ = _context.Remove(entity);
			return await _context.SaveChangesAsync();
		}

		public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null)
		{
			return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(filter);
		}

		public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null)
		{
			return await (filter == null ? _context.Set<T>().ToListAsync() : _context.Set<T>().Where(filter).ToListAsync());
		}

		public async Task<T> UpdateAsync(T entity)
		{
			_ = _context.Update(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task<List<T>> UpdateRangeAsync(List<T> entities)
		{
			_context.UpdateRange(entities);
			await _context.SaveChangesAsync();
			return entities;
		}
	}
}
