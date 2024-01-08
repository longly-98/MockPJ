using AutoMapper;
using MockPJ.Models;
using MockPJ.Models.DTOs;

namespace MockPJ.Utilities.AutoMapperProfile
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<User, RegisterDTO>().ReverseMap();
		}
	}
}
