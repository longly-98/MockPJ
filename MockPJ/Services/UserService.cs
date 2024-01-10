using AutoMapper;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;

namespace MockPJ.Services
{
	public class UserService
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;

		public UserService(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}

		public async Task<GetLandLordDetailsReturnDTO> GetLandLordDetails(int id)
		{
			var user = await _userRepository.GetLandLordDetailsAsync(x => x.UserID == id);

			return _mapper.Map<GetLandLordDetailsReturnDTO>(user);
		}
	}
}
