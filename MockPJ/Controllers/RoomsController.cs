using Microsoft.AspNetCore.Mvc;
using MockPJ.Models.DTOs;
using MockPJ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockPJ.Controllers
{
	[Route("api/rooms")]
	[ApiController]
	public class RoomsController : ControllerBase
	{
		private readonly RoomService _service;

		public RoomsController(RoomService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<ActionResult<List<GetRoomsReturnDTO>>> GetHouseRooms([FromQuery] int houseID)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetHouseRooms(houseID));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<List<GetRoomsReturnDTO>>> GetRoomDetails(int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetRoomDetails(id));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
