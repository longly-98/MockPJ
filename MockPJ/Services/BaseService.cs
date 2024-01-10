using MockPJ.Services.Interfaces;
using System.Security.Claims;

namespace MockPJ.Services
{
	public class BaseService : IBaseService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		public BaseService(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		public int GetCurrentUser()
		{
			var id = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value;
			return int.Parse(id);
		}
	}
}
