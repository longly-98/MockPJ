using AutoMapper;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Services
{
	public class UserRequestService : BaseService
	{
		private readonly IUserRequestRepository _userRequestRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public UserRequestService(IUserRequestRepository userRequestRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
			_userRequestRepository = userRequestRepository;
			_mapper = mapper;
			_httpContextAccessor = httpContextAccessor;
		}

		public async Task<UserRequest> CreateLandLordRegistrationRequest(int UserID)
		{
			return await _userRequestRepository.AddAsync(new UserRequest { UserID = UserID, RequestType = RequestType.Register, Status = RequestStatus.Pending });
		}
	}
}
