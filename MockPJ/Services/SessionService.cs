using AutoMapper;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;

namespace MockPJ.Services
{
	public class SessionService
	{
		private readonly IUserRepository userRepository;
		private readonly IMapper mapper;
		private readonly TokenService tokenService;

		public SessionService(IUserRepository userRepository, IMapper mapper,TokenService tokenService)
		{
			this.userRepository = userRepository;
			this.mapper = mapper;
			this.tokenService = tokenService;
		}

		public async Task<string> RegisterAsync(RegisterDTO register)
		{
			var user = await userRepository.AddAsync(mapper.Map<User>(register));
			return tokenService.CreateToken(user);
		}

		public async Task<string> LoginAsync(AuthRequest auth)
		{
			var user = await userRepository.GetWithRoleAsync(x => x.Email == auth.Email && x.Password == auth.Password);
			var role = user.Role;
			return tokenService.CreateToken(user);
		}
	}
}
