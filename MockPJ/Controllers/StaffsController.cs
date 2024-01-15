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
		private readonly HouseService _houseService;

		public StaffsController(StaffService service, HouseService houseService)
		{
			_service = service;
			_houseService = houseService;
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
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("landlords/requests")]
		[HttpGet]
		public async Task<ActionResult<List<GetLandLordRequestsReturnDTO>>> GetLandLordRegisterList([FromQuery] GetLandLordListRequestDTO req)
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
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("landlords/{id}/houses")]
		[HttpGet]
		public async Task<ActionResult<List<GetLandLordRequestsReturnDTO>>> GetLandLordHousesList(int id, [FromQuery] GetHousesRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetLandLordHousesList(id, req));
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("landlords/{id}")]
		[HttpPut]
		public async Task<ActionResult> ChangeLandLordStatus(int id, ChangeUserStatusRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				await _service.ChangeLandLordStatus(id, req);
				return Ok();
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("houses")]
		[HttpGet]
		public async Task<ActionResult<List<GetHousesReturnDTO>>> GetAllHouses([FromQuery] GetHousesRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _houseService.GetAllHouse(req, false));
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("landlords/requests/{RequestID}")]
		[HttpPut]
		public async Task<ActionResult> ChangeLandLordRequestStatus(int RequestID, ChangeUserRequestStatusRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				await _service.ChangeLandLordRequestStatus(RequestID, req);
				return Ok();
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("reports")]
		[HttpGet]
		public async Task<ActionResult<List<GetReportsListReturnDTO>>> GetAllReports([FromQuery] GetReportsListRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetReportsList(req));
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("reported-houses")]
		[HttpGet]
		public async Task<ActionResult<List<GetReportedHousesListReturnDTO>>> GetReportedHouses([FromQuery] GetReportedHousesListRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetReportsList(req));
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("houses/{HouseID}/reports")]
		[HttpGet]
		public async Task<ActionResult<List<GetReportsListReturnDTO>>> GetHouseReportsList(int HouseID, [FromQuery] GetReportsListRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetReportsListByHouse(HouseID, req));
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("students/orders")]
		[HttpGet]
		public async Task<ActionResult<List<GetStudentDetailsReturnDTO>>> GetStudentOrdersList([FromQuery] GetStudentOrdersRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return Ok(await _service.GetStudentOrdersList(req));
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Staff")]
		[Route("students/orders/{RequestID}")]
		[HttpPut]
		public async Task<ActionResult> ChangeStudentOrderStatus(int RequestID, ChangeUserRequestStatusRequestDTO req)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				await _service.ChangeStudentOrderStatus(RequestID, req);
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
