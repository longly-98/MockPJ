using AutoMapper;
using Elfie.Serialization;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using AutoMapper.Extensions.EnumMapping;

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
			CreateMap<CreateReportDTO, Report>().ReverseMap();
			CreateMap<CreateStaffDTO, User>().ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.Username)).ReverseMap();
			CreateMap<User, StaffReturnDTO>().ReverseMap();
			CreateMap<User, AdminUpdateStaffDTO>().ReverseMap();
			CreateMap<ChangeUserRequestStatusRequestDTO, UserRequest>().ReverseMap();
			CreateMap<User, GetStudentDetailsReturnDTO>().ReverseMap();

			CreateMap<UserRequest, GetStudentOrdersReturnDTO>()
				.ForMember(dest => dest.StudentDetails, opt => opt.MapFrom(src => src.User))
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.GetName(src.Status))).ReverseMap();

			CreateMap<Report, GetReportsListReturnDTO>()
				.ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.DisplayName))
				.ForMember(dest => dest.HouseName, opt => opt.MapFrom(src => src.House.HouseName)).ReverseMap();

			CreateMap<House, GetReportedHousesListReturnDTO>()
				.ForMember(dest => dest.LandLordName, opt => opt.MapFrom(src => src.LandLord.DisplayName))
				.ForMember(dest => dest.LandLordActive, opt => opt.MapFrom(src => src.LandLord.Active))
				.ForMember(dest => dest.ReportsCount, opt => opt.MapFrom(src => src.Reports.Count)).ReverseMap();

			CreateMap<UserRequest, GetLandLordRequestsReturnDTO>()
				.ForMember(dest => dest.LandLordDetails, opt => opt.MapFrom(src => src.User))
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.GetName(src.Status))).ReverseMap();

			CreateMap<CreateAddressDTO, Address>().ReverseMap();
			CreateMap<CreateImageRequestDTO, HouseImage>().ReverseMap();
			CreateMap<CreateImageRequestDTO, RoomImage>().ReverseMap();
			CreateMap<CreateRoomRequestDTO, Room>().ReverseMap();
			CreateMap<CreateHouseRequestDTO, House>().ReverseMap();
			CreateMap<CreateLandLordRegistrationDTO, User>()
				.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address)).ReverseMap();
		}
	}
}
