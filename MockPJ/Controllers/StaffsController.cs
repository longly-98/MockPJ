using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockPJ.Controllers
{
	[Route("api/staff")]
	[ApiController]
	public class StaffsController : ControllerBase
	{
		private readonly StaffService _service;

		public StaffsController(StaffService service)
		{
			_service = service;
		}

		[Authorize(Roles = "Staff")]
		[Route("landlords/statistic")]
		[HttpGet]
		public async Task<ActionResult<List<GetLandLordStatisticReturnDTO>>> GetLandLordList([FromQuery]GetLandLordListRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetLandLordStatisticList(req));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("landlords/requests")]
		[HttpGet]
		public async Task<ActionResult<List<GetLandLordRegReturnDTO>>> GetLandLordRegisterList([FromQuery] GetLandLordListRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetLandLordRegisterList(req));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
