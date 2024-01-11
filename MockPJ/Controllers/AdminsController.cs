using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockPJ.Controllers
{
	[Route("api/admins")]
	[ApiController]
	public class AdminsController : ControllerBase
	{
		private readonly AdminService _service;

		public AdminsController(AdminService service)
		{
			_service = service;
		}

		[Authorize(Roles = "Admin")]
		[Route("staffs")]
		[HttpPost]
		public async Task<ActionResult<StaffReturnDTO>> CreateStaff(CreateStaffDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var addedStaff = await _service.CreateStaff(dto);
				return CreatedAtAction("CreateStaff", new { id = addedStaff.UserID }, addedStaff);
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Admin")]
		[Route("staffs/{id}")]
		[HttpPut]
		public async Task<ActionResult<StaffReturnDTO>> AdminUpdateStaff(int id, AdminUpdateStaffDTO dto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var staff = await _service.AdminUpdateStaff(id, dto);
				return Ok(staff);
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Admin")]
		[Route("staffs/{id}")]
		[HttpDelete]
		public async Task<ActionResult> DeleteStaff(int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var deleteCount = await _service.DeleteStaff(id);

				if (deleteCount > 0)
				{
					return Ok();
				}

				return BadRequest("Delete failed");
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}

		[Authorize(Roles = "Admin")]
		[Route("staffs")]
		[HttpGet]
		public async Task<ActionResult<List<StaffReturnDTO>>> GetStaffsList()
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				return await _service.GetStaffsList();
			}
			catch (Exception e)
			{
				var msg = e.InnerException != null ? e.InnerException : e;
				return BadRequest(msg.Message);
			}
		}
	}
}
