using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class CampusRepository : CommonRepository<Campus>, ICampusRepository
	{
		private readonly BaseContext _context;
		public CampusRepository(BaseContext context) : base(context)
		{
			_context = context;
		}
	}
}
