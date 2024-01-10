using AutoMapper;
using BCrypt.Net;
using Microsoft.AspNetCore.Identity;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Utilities;

namespace MockPJ.Services
{
	public class SessionService
	{
		private readonly IUserRepository userRepository;
		private readonly IMapper mapper;
		private readonly TokenService tokenService;

		public SessionService(IUserRepository userRepository, IMapper mapper, TokenService tokenService)
		{
			this.userRepository = userRepository;
			this.mapper = mapper;
			this.tokenService = tokenService;
		}

		public async Task<string> RegisterAsync(RegisterDTO register)
		{
			var mappedUser = mapper.Map<User>(register);
			mappedUser.Password = BCrypt.Net.BCrypt.HashPassword(register.Password);
			var user = await userRepository.AddAsync(mappedUser);
			return tokenService.CreateToken(user);
		}

		public async Task<string> LoginAsync(AuthRequest auth)
		{
			var user = await userRepository.GetWithRoleAsync(x => x.Email == auth.Email);

			if (user != null)
			{
				var isValidPassword = BCrypt.Net.BCrypt.Verify(auth.Password, user.Password);

				if (isValidPassword)
				{
					return tokenService.CreateToken(user);
				}
			}

			return null;
		}

		public async Task<bool> ChangePasswordAsync(ChangePasswordRequestDTO dto)
		{
			var user = await userRepository.GetWithRoleAsync(x => x.Email == dto.Email);

			if (user != null)
			{
				var isValidPassword = BCrypt.Net.BCrypt.Verify(dto.CurrentPassword, user.Password);

				if (isValidPassword)
				{
					user.Password = BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);
					await userRepository.UpdateAsync(user);
					return true;
				}
			}

			return false;
		}
	}
}
