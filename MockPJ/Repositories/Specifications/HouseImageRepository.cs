using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class HouseImageRepository : CommonRepository<HouseImage>, IHouseImageRepository
	{
		private readonly BaseContext _context;
		public HouseImageRepository(BaseContext context) : base(context)
		{
			_context = context;
		}
	}
}
