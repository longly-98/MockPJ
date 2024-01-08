using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class User : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserID { get; set; }
		public string? FacebookUserID { get; set; }
		public string? GoogleUserID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string DisplayName { get; set; }
		public bool Active { get; set; } = false;
		public string? ProfileImageLink { get; set; }
		public string? PhoneNumber { get; set; }
		public string? FacebookURL { get; set; }
		public string? IdentityCardFrontSideImageLink { get; set; }
		public string? IdentityCardBackSideImageLink { get; set; }
		public int? AddressID { get; set; }
		public Address Address { get; set; }
		public int RoleID { get; set; }
		public UserRole Role { get; set; }
		public int? CreatedBy { get; set; }
		public int? LastModifiedBy { get; set; }
		public User Creator { get; set; }
		public User Modifier { get; set; }
		public ICollection<RoomHistory> CreateRoomHistories { get; set; }
		public ICollection<RoomHistory> ModifyRoomHistories { get; set; }
		public ICollection<House> CreateHouses { get; set; }
		public ICollection<House> ModifyHouses { get; set; }
		public ICollection<House> OwnHouses { get; set; }
		public ICollection<Room> CreateRooms { get; set; }
		public ICollection<Room> ModifyRooms { get; set; }
		public ICollection<HouseImage> CreateHouseImages { get; set; }
		public ICollection<HouseImage> ModifyHouseImages { get; set; }
		public ICollection<RoomImage> CreateRoomImages { get; set; }
		public ICollection<RoomImage> ModifyRoomImages { get; set; }
		public ICollection<Report> StudentReports { get; set; }
		public ICollection<Report> CreateReports { get; set; }
		public ICollection<Report> ModifyReports { get; set; }
		public ICollection<Rate> StudentRates { get; set; }
		public ICollection<Rate> CreateRates { get; set; }
		public ICollection<Rate> ModifyRates { get; set; }
		public ICollection<User> CreateUsers { get; set; }
		public ICollection<User> ModifyUsers { get; set; }
	}
}
