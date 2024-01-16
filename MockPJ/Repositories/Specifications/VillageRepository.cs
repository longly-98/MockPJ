using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class VillageRepository : CommonRepository<Village>, IVillageRepository
	{
		private readonly BaseContext _context;
		public VillageRepository(BaseContext context) : base(context)
		{
			_context = context;
		}
	}
}
