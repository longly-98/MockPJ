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
	}
}
