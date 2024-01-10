using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MockPJ.Models.DTOs;
using MockPJ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockPJ.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RatesController : ControllerBase
	{
		private readonly RateService _service;

		public RatesController(RateService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<ActionResult<List<GetHousesReturnDTO>>> GetAllRatesByHouse([FromQuery] int houseId)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetAllRatesByHouse(houseId));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[Authorize(Roles = "Student")]
		[HttpPost]
		public async Task<ActionResult> CreateRate(CreateRateDTO rate)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var addedRate = await _service.CreateRate(rate);
				return CreatedAtAction("CreateRate", new { id = addedRate.RateID });
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
