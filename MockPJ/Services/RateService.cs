using AutoMapper;
using MockPJ.Models.DTOs;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Utilities.CustomException;

namespace MockPJ.Services
{
	public class RateService : BaseService
	{
		private readonly IRateRepository _rateRepository;	
		private readonly IHouseRepository _houseRepository;
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public RateService(IRateRepository rateRepository, IHouseRepository houseRepository, IUserRepository userRepository , IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
			_rateRepository = rateRepository;
			_mapper = mapper;
			_httpContextAccessor = httpContextAccessor;
			_houseRepository = houseRepository;
			_userRepository = userRepository;
		}

		public async Task<List<GetRatesReturnDTO>> GetAllRatesByHouse(int houseId)
		{
			var list = await _rateRepository.GetListWithMoreInfoAsync(x => x.HouseID == houseId);

			return _mapper.Map<List<GetRatesReturnDTO>>(list);
		}

		public async Task<Rate> CreateRate(CreateRateDTO rate)
		{
			var house = await _houseRepository.GetAsync(x => x.HouseID == rate.HouseID);
			if (house == null)
			{
				throw new NotFoundException("House not found");
			}

			var student = await _userRepository.GetAsync(x => x.UserID == rate.StudentID);
			if (student == null)
			{
				throw new NotFoundException("Student not found");
			}

			var mappedRate = _mapper.Map<Rate>(rate);
			mappedRate.CreatedBy = GetCurrentUser();
			var addedRate = await _rateRepository.AddAsync(mappedRate);

			return addedRate;
		}
	}
}
