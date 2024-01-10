using AutoMapper;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Utilities.CustomException;

namespace MockPJ.Services
{
	public class ReportService : BaseService
	{
		private readonly IReportRepository _reportRepository;
		private readonly IHouseRepository _houseRepository;
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public ReportService(IReportRepository reportRepository, IHouseRepository houseRepository, IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
			_reportRepository = reportRepository;
			_mapper = mapper;
			_httpContextAccessor = httpContextAccessor;
			_houseRepository = houseRepository;
			_userRepository = userRepository;
		}

		public async Task<Report> CreateReport(CreateReportDTO dto)
		{
			var house = await _houseRepository.GetAsync(x => x.HouseID == dto.HouseID);
			if (house == null)
			{
				throw new NotFoundException("House not found");
			}

			var student = await _userRepository.GetAsync(x => x.UserID == dto.StudentID);
			if (student == null)
			{
				throw new NotFoundException("Student not found");
			}

			var mappedReport = _mapper.Map<Report>(dto);
			mappedReport.CreatedBy = GetCurrentUser();
			var addedReport = await _reportRepository.AddAsync(mappedReport);
			return addedReport;
		}
	}
}
