using Microsoft.AspNetCore.Authorization;
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
		private readonly LandLordService _landLordService;
		private readonly UserRequestService _userRequestService;

		public LandLordsController(AdminService service, LandLordService landLordService, UserRequestService userRequestService)
		{
			_service = service;
			_landLordService = landLordService;
			_userRequestService = userRequestService;
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
				return Ok(await _landLordService.GetLandLordDetails(id));
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[HttpPost]
		[Route("registration")]
		public async Task<ActionResult<int>> CreateLandLordRegistration([FromBody] CreateLandLordRegistrationDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var landlord = await _landLordService.CreateLandLordRegistration(dto);
				await _userRequestService.CreateLandLordRegistrationRequest(landlord.UserID);
				return CreatedAtAction("CreateLandLordRegistration", new { id = landlord.UserID });
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpGet]
		[Route("houses")]
		public async Task<ActionResult<GetLandLordHousesListReturnDTO>> GetLandLordHousesList([FromQuery] GetHousesRequestDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return await _landLordService.GetLandLordHousesList(dto);
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpPost]
		[Route("houses")]
		public async Task<ActionResult> CreateHouse([FromBody] CreateHouseRequestDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			 
			try
			{
				var houseID = await _landLordService.CreateHouse(dto);

				if(houseID == 0)
				{
					return BadRequest("Create house failed");
				}
				return CreatedAtAction("CreateHouse", new { id = houseID});
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpPut]
		[Route("houses/{id}")]
		public async Task<ActionResult> UpdateHouse(int id, [FromBody] CreateHouseRequestDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var houseID = await _landLordService.UpdateHouse(id, dto);

				if (houseID == 0)
				{
					return BadRequest("Update house failed");
				}
				return CreatedAtAction("UpdateHouse", new { id = houseID });
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpDelete]
		[Route("houses/{id}")]
		public async Task<ActionResult> DeleteHouse(int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				await _landLordService.DeleteHouse(id);
				return Ok();
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpPut]
		[Route("rates/{id}/reply")]
		public async Task<ActionResult> ReplyComment(int id, [FromQuery] ReplyCommentRequestDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				await _landLordService.ReplyComment(id, dto);
				return Ok();
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpPost]
		[Route("houses/{HouseID}/rooms")]
		public async Task<ActionResult> CreateRoom(int HouseID, [FromBody] CreateRoomRequestDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var roomID = await _landLordService.CreateRoom(HouseID, dto);

				if (roomID == 0)
				{
					return BadRequest("Create room failed");
				}
				return CreatedAtAction("CreateRoom", new { id = roomID });
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpPut]
		[Route("houses/{HouseID}/rooms/{id}")]
		public async Task<ActionResult> UpdateRoom(int id, int HouseID, [FromBody] CreateRoomRequestDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var roomID = await _landLordService.UpdateRoom(id, HouseID, dto);

				if (roomID == 0)
				{
					return BadRequest("Update room failed");
				}
				return CreatedAtAction("UpdateRoom", new { id = roomID });
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpPut]
		[Route("houses/{HouseID}/rooms/{id}/status")]
		public async Task<ActionResult> UpdateRoomStatus(int id, int HouseID, [FromBody] UpdateRoomStatusRequestDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var roomID = await _landLordService.UpdateRoomStatus(id, HouseID, dto);

				if (roomID == 0)
				{
					return BadRequest("Update room failed");
				}
				return CreatedAtAction("UpdateRoomStatus", new { id = roomID });
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "LandLord")]
		[HttpDelete]
		[Route("houses/{HouseID}/rooms/{id}")]
		public async Task<ActionResult> DeleteRoom(int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				await _landLordService.DeleteRoom(id);
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
