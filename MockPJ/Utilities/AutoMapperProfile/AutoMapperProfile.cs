using AutoMapper;
using Elfie.Serialization;
using MockPJ.Models;
using MockPJ.Models.DTOs;

namespace MockPJ.Utilities.AutoMapperProfile
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<User, RegisterDTO>().ReverseMap();
			CreateMap<House, GetHousesReturnDTO>().ReverseMap();
			CreateMap<House, GetHousesReturnDTO>()
			.ForMember(dest => dest.CampusName, opt => opt.MapFrom(src => src.Campus.CampusName))
			.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address.Addresses))
			.ForMember(dest => dest.VillageName, opt => opt.MapFrom(src => src.Village.VillageName))
			.ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.HouseImages)).ReverseMap();
			CreateMap<HouseImage, ImageReturnDTO>().ReverseMap();
		}
	}
}
