using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MockPJ.Models.DTOs;
using MockPJ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockPJ.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReportsController : ControllerBase
	{
		private readonly ReportService _service;

		public ReportsController(ReportService service)
		{
			_service = service;
		}

		[Authorize(Roles = "Student")]
		[HttpPost]
		public async Task<ActionResult> CreateReport(CreateReportDTO report)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			try
			{
				var addedReport = await _service.CreateReport(report);
				return CreatedAtAction("CreateReport", new { id = addedReport.ReportID });
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
