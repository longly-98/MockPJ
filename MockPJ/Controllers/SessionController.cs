using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Services;

namespace MockPJ.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SessionController : ControllerBase
	{
		/*private readonly UserManager<User> _userManager;*/
		private readonly BaseContext _context;
		private readonly SessionService _sessionService;

		public SessionController(BaseContext context, SessionService sessionService)
		{
			_context = context;
			_sessionService = sessionService;
		}


		/*		public SessionController(UserManager<User> userManager, BaseContext context, TokenService tokenService)
				{
					_userManager = userManager;
					_context = context;
					_tokenService = tokenService;
				}
		*/
		/*		[HttpPost]
				[Route("register")]
				public async Task<ActionResult> Register(RegisterDTO req)
				{
					if (!ModelState.IsValid)
					{
						return BadRequest(ModelState);
					}

					var user = await _sessionService.RegisterAsync(req);
					if (user != null)
					{
						var isInRole = await _userManager.IsInRoleAsync(user, req.Role);
						if (!isInRole)
						{
							// If not in the role, add the user to the role
							var result = await _userManager.AddToRoleAsync(user, req.Role);

							if (result.Succeeded)
							{
								return CreatedAtAction(nameof(Register), new { email = user.Email, role = user.Role.RoleName }, req);
							}

							foreach (var error in result.Errors)
							{
								ModelState.AddModelError(error.Code, error.Description);
							}
						}
					}

					return BadRequest(ModelState);
				}

				[HttpPost]
				[Route("login")]
				public async Task<ActionResult<AuthResponse>> Login(AuthRequest req)
				{
					if (!ModelState.IsValid)
					{
						return BadRequest(ModelState);
					}

					var user = await _sessionService.LoginAsync(req.Email);

					if (user != null)
					{
						var isInRole = await _userManager.IsInRoleAsync(user, user.Role.RoleName);
						if (!isInRole)
						{
							var result = await _userManager.AddToRoleAsync(user, user.Role.RoleName);
							if (result.Succeeded)
							{
								var isValidPwd = await _userManager.CheckPasswordAsync(user, req.Password);

								if (!isValidPwd)
								{
									return BadRequest(ModelState);
								}

								var accessToken = _tokenService.CreateToken(user);

								return Ok(new AuthResponse { Email = user.Email, Token = accessToken});
							}

							foreach (var error in result.Errors)
							{
								ModelState.AddModelError(error.Code, error.Description);
							}
						}
					}
					return BadRequest(ModelState);
				}*/

		[HttpPost]
		[Route("register")]
		public async Task<ActionResult<AuthResponse>> Register(RegisterDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var token = await _sessionService.RegisterAsync(req);
				return Ok(new AuthResponse { Email = req.Email, Token = token});
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[HttpPost]
		[Route("login")]
		public async Task<ActionResult<AuthResponse>> Login(AuthRequest req)
		{
			try
			{
				var token = await _sessionService.LoginAsync(req);

				if (string.IsNullOrEmpty(token)) { return Unauthorized(); }

				return Ok(new AuthResponse { Email = req.Email, Token = token });
			}

			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize]
		[HttpPost]
		[Route("changePassword")]
		public async Task<ActionResult> ChangePassword(ChangePasswordRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var res = await _sessionService.ChangePasswordAsync(req);

				if (!res) { return BadRequest("Wrong password"); }

				return Ok();
			}

			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}
	}
}
