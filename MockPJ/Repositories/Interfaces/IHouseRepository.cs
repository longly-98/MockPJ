using MockPJ.Models;
using System.Linq.Expressions;

namespace MockPJ.Repositories.Interfaces
{
	public interface IHouseRepository
	{
		Task<IEnumerable<House>> GetAllHousesAsync(Expression<Func<House, bool>> filter = null);
		Task<IEnumerable<House>> GetReportedHousesAsync(Expression<Func<House, bool>> filter = null);
		Task<House> GetHouseDetailAsync(Expression<Func<House, bool>> filter = null);
		Task<House> AddHouseAsync(House house);
		Task<House> UpdateHouseAsync(House house);
		Task<int> DeleteHouseAsync(House house);
	}
}
