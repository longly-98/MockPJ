using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class AddressRepository : CommonRepository<Address>, IAddressRepository
	{
		private readonly BaseContext _context;
		public AddressRepository(BaseContext context) : base(context)
		{
			_context = context;
		}
	}
}
