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
			CreateMap<Rate, GetRatesReturnDTO>().ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.DisplayName)).ReverseMap();
			CreateMap<User, GetLandLordDetailsReturnDTO>()
				.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address.Addresses)).ReverseMap();
			CreateMap<Room, GetRoomsReturnDTO>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.StatusName))
				.ForMember(dest => dest.Histories, opt => opt.MapFrom(src => src.RoomHistories))
				.ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.RoomImages))
				.ForMember(dest => dest.RoomType, opt => opt.MapFrom(src => src.RoomType.RoomTypeName)).ReverseMap();
			CreateMap<RoomHistory, HistoriesReturnDTO>().ReverseMap();
			CreateMap<RoomImage, ImageReturnDTO>().ReverseMap();
			CreateMap<CreateRateDTO, Rate>().ReverseMap();
		}
	}
}
