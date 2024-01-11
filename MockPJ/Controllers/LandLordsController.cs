using Microsoft.AspNetCore.Mvc;
using MockPJ.Models.DTOs;
using MockPJ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockPJ.Controllers
{
	[Route("api/landlords")]
	[ApiController]
	public class LandLordsController : ControllerBase
	{
		private readonly AdminService _service;

		public LandLordsController(AdminService service)
		{
			_service = service;
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<GetLandLordDetailsReturnDTO>> GetLandLordDetails(int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetLandLordDetails(id));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
