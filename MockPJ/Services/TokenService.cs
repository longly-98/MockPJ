﻿using Microsoft.IdentityModel.Tokens;
using MockPJ.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MockPJ.Services
{
	public class TokenService
	{
		private const int ExpirationHours = 24;
		private readonly ILogger<TokenService> _logger;
		private readonly IConfiguration _configuration;

		public TokenService(ILogger<TokenService> logger, IConfiguration configuration)
		{
			_logger = logger;
			_configuration = configuration;
		}

		public string CreateToken(User user)
		{
			var expiration = DateTime.UtcNow.AddHours(ExpirationHours);
			var token = CreateJwtToken(
				CreateClaims(user),
				CreateSigningCredentials(),
				expiration
			);

			var tokenHandler = new JwtSecurityTokenHandler();

			_logger.LogInformation("JWT Token created");

			return tokenHandler.WriteToken(token);
		}

		private JwtSecurityToken CreateJwtToken(List<Claim> claims, SigningCredentials credentials,	DateTime expiration) =>
		new(
			_configuration.GetSection("JwtTokenSettings")["ValidIssuer"],
			_configuration.GetSection("JwtTokenSettings")["ValidAudience"],
			claims,
			expires: expiration,
			signingCredentials: credentials
		);

		private List<Claim> CreateClaims(User user)
		{
			var jwtSub = _configuration.GetSection("JwtTokenSettings")["JwtRegisteredClaimNamesSub"];

			try
			{
				var claims = new List<Claim>
					{
						new Claim(JwtRegisteredClaimNames.Sub, jwtSub),
						new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
						new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString()),
						new Claim(ClaimTypes.Sid, user.UserID.ToString()),
						new Claim(ClaimTypes.Name, user.DisplayName),
						new Claim(ClaimTypes.Email, user.Email),
						new Claim(ClaimTypes.Role, user.Role.RoleName)
					};

				return claims;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		private SigningCredentials CreateSigningCredentials()
		{
			var symmetricSecurityKey = _configuration.GetSection("JwtTokenSettings")["SymmetricSecurityKey"];

			return new SigningCredentials(
				new SymmetricSecurityKey(
					Encoding.UTF8.GetBytes(symmetricSecurityKey)
				),
				SecurityAlgorithms.HmacSha256
			);
		}
	}
}
