using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Utilities.CustomException;
using System.Drawing.Printing;
using System.Globalization;
using System.Threading;

namespace MockPJ.Services
{
	public class HouseService : BaseService
	{
		private readonly IHouseRepository _houseRepository;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public HouseService(IHouseRepository houseRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
		{
			_houseRepository = houseRepository;
			_mapper = mapper;
			_httpContextAccessor = httpContextAccessor;
		}

		public async Task<List<GetHousesReturnDTO>> GetAllHouse(GetHousesRequestDTO req, bool CheckLandLord = true)
		{
			var list = await _houseRepository.GetListWithMoreInfoAsync(x =>
				(!string.IsNullOrEmpty(req.Keywords) ? x.HouseName.Contains(req.Keywords) : true) &&
				(req.CampusID.HasValue ? x.CampusID == req.CampusID : true) &&
				(req.VillageID.HasValue ? x.VillageID == req.VillageID : true) && 
				(CheckLandLord ? x.LandLord.Active : true)
			);

			if (req.SortBy != null && req.SortType != null)
			{
				var propertyInfo = typeof(House).GetProperty(req.SortBy);
				if (propertyInfo != null)
				{
					var orderedList = req.SortType?.ToLower() == "desc" ? list.OrderByDescending(x => propertyInfo?.GetValue(x, null)) : list.OrderBy(x => propertyInfo.GetValue(x, null));
					list = orderedList.ToList();
				}
			}

			return _mapper.Map<List<GetHousesReturnDTO>>(list.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize));
		}

		public async Task<GetHousesReturnDTO> GetHouseDetails(int id)
		{
			var house = await _houseRepository.GetWithMoreInfoAsync(x => x.HouseID == id);

			if (house is null)
			{
				throw new NotFoundException("House not found");
			}
			return _mapper.Map<GetHousesReturnDTO>(house);
		}
	}
}
