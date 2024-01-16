using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class RoomTypeRepository : CommonRepository<RoomType>, IRoomTypeRepository
	{
		private readonly BaseContext _context;
		public RoomTypeRepository(BaseContext context) : base(context)
		{
			_context = context;
		}
	}
}
