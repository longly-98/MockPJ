using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class StatusRepository : CommonRepository<Status>, IStatusRepository
	{
		public StatusRepository(BaseContext context) : base(context)
		{
		}
	}
}
