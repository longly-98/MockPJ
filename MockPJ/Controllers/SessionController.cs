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
		private readonly BaseContext _context;
		private readonly SessionService _sessionService;

		public SessionController(BaseContext context, SessionService sessionService)
		{
			_context = context;
			_sessionService = sessionService;
		}

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
