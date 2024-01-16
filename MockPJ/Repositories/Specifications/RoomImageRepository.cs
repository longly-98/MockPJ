using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class RoomImageRepository : CommonRepository<RoomImage>, IRoomImageRepository
	{
		private readonly BaseContext _context;
		public RoomImageRepository(BaseContext context) : base(context)
		{
			_context = context;
		}
	}
}
