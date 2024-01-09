using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockPJ.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HousesController : ControllerBase
	{
		private readonly HouseService _service;

		public HousesController(HouseService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<ActionResult<List<GetHousesReturnDTO>>> GetAllHouses([FromQuery] GetHousesRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetAllHouse(req));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<GetHousesReturnDTO>> GetHouse(int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetHouseDetails(id));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
