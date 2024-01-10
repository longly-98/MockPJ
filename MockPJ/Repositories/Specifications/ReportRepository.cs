using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Repositories.Specifications
{
	public class ReportRepository : CommonRepository<Report>, IReportRepository
	{
		public ReportRepository(BaseContext context) : base(context)
		{
		}
	}
}
