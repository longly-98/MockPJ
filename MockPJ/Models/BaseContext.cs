using Microsoft.EntityFrameworkCore;

namespace MockPJ.Models
{
	public class BaseContext : DbContext
	{
		public BaseContext(DbContextOptions opt) : base(opt) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Campus> Campuses { get; set; }
		public DbSet<Commune> Communes { get; set; }
		public DbSet<District> Districts { get; set; }
		public DbSet<House> Houses { get; set; }
		public DbSet<HouseImage> HouseImages { get; set; }
		public DbSet<Rate> Rates { get; set; }
		public DbSet<Report> Reports { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<RoomHistory> RoomHistories { get; set; }
		public DbSet<RoomImage> RoomImages { get; set; }
		public DbSet<RoomType> RoomTypes { get; set; }
		public DbSet<Status> Statuses { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<Village> Vill { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasMany<House>(u => u.OwnHouses).WithOne(h => h.LandLord).HasForeignKey(h => h.LandLordID);
			modelBuilder.Entity<User>().HasMany<House>(u => u.CreateHouses).WithOne(h => h.Creator).HasForeignKey(h => h.CreatedBy);
			modelBuilder.Entity<User>().HasMany<House>(u => u.ModifyHouses).WithOne(h => h.Modifier).HasForeignKey(h => h.LastModifiedBy);

			modelBuilder.Entity<User>().HasMany<HouseImage>(u => u.CreateHouseImages).WithOne(hi => hi.Creator).HasForeignKey(hi => hi.CreatedBy);
			modelBuilder.Entity<User>().HasMany<HouseImage>(u => u.ModifyHouseImages).WithOne(hi => hi.Modifier).HasForeignKey(hi => hi.LastModifiedBy);

			modelBuilder.Entity<User>().HasMany<Room>(u => u.CreateRooms).WithOne(r => r.Creator).HasForeignKey(r => r.CreatedBy);
			modelBuilder.Entity<User>().HasMany<Room>(u => u.ModifyRooms).WithOne(r => r.Modifier).HasForeignKey(r => r.LastModifiedBy);

			modelBuilder.Entity<User>().HasMany<Rate>(u => u.StudentRates).WithOne(r => r.Student).HasForeignKey(r => r.StudentID);
			modelBuilder.Entity<User>().HasMany<Rate>(u => u.CreateRates).WithOne(r => r.Creator).HasForeignKey(r => r.CreatedBy);
			modelBuilder.Entity<User>().HasMany<Rate>(u => u.ModifyRates).WithOne(r => r.Modifier).HasForeignKey(r => r.LastModifiedBy);

			modelBuilder.Entity<User>().HasMany<Report>(u => u.StudentReports).WithOne(r => r.Student).HasForeignKey(r => r.StudentID);
			modelBuilder.Entity<User>().HasMany<Report>(u => u.CreateReports).WithOne(h => h.Creator).HasForeignKey(h => h.CreatedBy);
			modelBuilder.Entity<User>().HasMany<Report>(u => u.ModifyReports).WithOne(h => h.Modifier).HasForeignKey(h => h.LastModifiedBy);

			modelBuilder.Entity<User>().HasMany<RoomImage>(u => u.CreateRoomImages).WithOne(ri => ri.Creator).HasForeignKey(ri => ri.CreatedBy);
			modelBuilder.Entity<User>().HasMany<RoomImage>(u => u.ModifyRoomImages).WithOne(ri => ri.Modifier).HasForeignKey(ri => ri.LastModifiedBy);

			modelBuilder.Entity<User>().HasMany<RoomHistory>(u => u.CreateRoomHistories).WithOne(rh => rh.Creator).HasForeignKey(rh => rh.CreatedBy);
			modelBuilder.Entity<User>().HasMany<RoomHistory>(u => u.ModifyRoomHistories).WithOne(rh => rh.Modifier).HasForeignKey(rh => rh.LastModifiedBy);

			modelBuilder.Entity<User>().HasMany<User>(u => u.CreateUsers).WithOne(u => u.Creator).HasForeignKey(u => u.CreatedBy);
			modelBuilder.Entity<User>().HasMany<User>(u => u.ModifyUsers).WithOne(u => u.Modifier).HasForeignKey(u => u.LastModifiedBy);

			modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
			modelBuilder.Entity<User>().HasIndex(u => u.DisplayName).IsUnique();

			modelBuilder.Entity<UserRole>().HasData(
				new UserRole { RoleID = 1, RoleName = "Admin" },
				new UserRole { RoleID = 2, RoleName = "Staff" },
				new UserRole { RoleID = 3, RoleName = "LandLord" },
				new UserRole { RoleID = 4, RoleName = "Student" }
			);

			modelBuilder.Entity<User>().HasData(
				new User { UserID = 1, Email = "admin@gmail.com", RoleID = 1, Active = true, DisplayName = "Admin", PhoneNumber = "0123456789", Password = "Aa@123456" },
				new User { UserID = 2, Email = "staff@gmail.com", RoleID = 2, Active = true, DisplayName = "Staff", PhoneNumber = "0123456789", Password = "Aa@123456" },
				new User { UserID = 3, Email = "landlord@gmail.com", RoleID = 3, Active = true, DisplayName = "LandLord", PhoneNumber = "0123456789", Password = "Aa@123456" },
				new User { UserID = 4, Email = "student@gmail.com", RoleID = 4, Active = true, DisplayName = "Student", PhoneNumber = "0123456789", Password = "Aa@123456" }
			);

			modelBuilder.Entity<Address>().HasData(
				new Address { AddressID = 1, Addresses = "so 1, ngách 1, ngõ 1, đường 1", GoogleMapLocation = "111111,1111111" },
				new Address { AddressID = 2, Addresses = "so 2, ngách 1, ngõ 1, đường 1", GoogleMapLocation = "111111,1111111" },
				new Address { AddressID = 3, Addresses = "so 3, ngách 1, ngõ 1, đường 1", GoogleMapLocation = "111111,1111111" }
			);

			modelBuilder.Entity<Campus>().HasData(
				new Campus { CampusId = 1, AddressID = 1, CampusName = "Campus A" }
			);

			modelBuilder.Entity<District>().HasData(
				new District { DistrictID = 1, DistrictName = "Dong Da" }
			);

			modelBuilder.Entity<Commune>().HasData(
				new Commune { CommuneID = 1, CommuneName = "Phuong Lien", DistrictID = 1 }
			);

			modelBuilder.Entity<Village>().HasData(
				new Village { VillageId = 1, VillageName = "Village A", CommuneID = 1 }
			);

			modelBuilder.Entity<House>().HasData(
				new House { HouseID = 1, AddressID = 1, CampusID = 1, CreatedBy = 1, HouseName = "House A", Information = "AC, Hot water", LandLordID = 3, PowerPrice = 4000, VillageID = 1, WaterPrice = 30000 },
				new House { HouseID = 2, AddressID = 2, CampusID = 1, CreatedBy = 1, HouseName = "House B", Information = "AC, Hot water", LandLordID = 3, PowerPrice = 4000, VillageID = 1, WaterPrice = 30000 },
				new House { HouseID = 3, AddressID = 3, CampusID = 1, CreatedBy = 1, HouseName = "House C", Information = "AC, Hot water", LandLordID = 3, PowerPrice = 4000, VillageID = 1, WaterPrice = 30000 }
			);

			modelBuilder.Entity<HouseImage>().HasData(
				new HouseImage { ImageID = 1, HouseID = 1, ImageLink = "link" },
				new HouseImage { ImageID = 2, HouseID = 1, ImageLink = "link" },
				new HouseImage { ImageID = 3, HouseID = 2, ImageLink = "link" },
				new HouseImage { ImageID = 4, HouseID = 2, ImageLink = "link" },
				new HouseImage { ImageID = 5, HouseID = 3, ImageLink = "link" },
				new HouseImage { ImageID = 6, HouseID = 3, ImageLink = "link" },
				new HouseImage { ImageID = 7, HouseID = 3, ImageLink = "link" }
			);

			modelBuilder.Entity<Status>().HasData(
				new Status { StatusID = 1, StatusName = "Available" },
				new Status { StatusID = 2, StatusName = "Not Available" }
			);

			modelBuilder.Entity<RoomType>().HasData(
				new RoomType { RoomTypeID = 1, RoomTypeName = "Shared hostel" },
				new RoomType { RoomTypeID = 2, RoomTypeName = "Apartment" },
				new RoomType { RoomTypeID = 3, RoomTypeName = "Mini apartment" },
				new RoomType { RoomTypeID = 4, RoomTypeName = "Homestays" }
			);

			modelBuilder.Entity<Room>().HasData(
				new Room
				{
					RoomID = 1,
					RoomName = "101",
					RoomTypeID = 1,
					StatusID = 1,
					Area = "20m2",
					HouseID = 1,
					BuildingNumber = 1,
					CurrentAmountOfPeople = 0,
					FloorNumber = 1,
					MaxAmountOfPeople = 3,
					RoomPrice = 1000000
				},
				new Room
				{
					RoomID = 2,
					RoomName = "102",
					RoomTypeID = 1,
					StatusID = 1,
					Area = "20m2",
					HouseID = 1,
					BuildingNumber = 1,
					CurrentAmountOfPeople = 1,
					FloorNumber = 1,
					MaxAmountOfPeople = 3,
					RoomPrice = 900000
				},
				new Room
				{
					RoomID = 3,
					RoomName = "103",
					RoomTypeID = 3,
					StatusID = 1,
					Area = "25m2",
					HouseID = 2,
					BuildingNumber = 2,
					CurrentAmountOfPeople = 0,
					FloorNumber = 1,
					MaxAmountOfPeople = 3,
					RoomPrice = 3000000
				},
				new Room
				{
					RoomID = 4,
					RoomName = "104",
					RoomTypeID = 3,
					StatusID = 1,
					Area = "28m2",
					HouseID = 2,
					BuildingNumber = 1,
					CurrentAmountOfPeople = 0,
					FloorNumber = 1,
					MaxAmountOfPeople = 3,
					RoomPrice = 4000000
				},
				new Room
				{
					RoomID = 5,
					RoomName = "105",
					RoomTypeID = 2,
					StatusID = 1,
					Area = "40m2",
					HouseID = 3,
					BuildingNumber = 1,
					CurrentAmountOfPeople = 0,
					FloorNumber = 1,
					MaxAmountOfPeople = 3,
					RoomPrice = 10000000
				}
			);

			modelBuilder.Entity<RoomImage>().HasData(
				new RoomImage { ImageID = 1, ImageLink = "link", RoomID = 1 },
				new RoomImage { ImageID = 2, ImageLink = "link", RoomID = 2 },
				new RoomImage { ImageID = 3, ImageLink = "link", RoomID = 3 },
				new RoomImage { ImageID = 4, ImageLink = "link", RoomID = 4 },
				new RoomImage { ImageID = 5, ImageLink = "link", RoomID = 5 }
			);

			modelBuilder.Entity<Rate>().HasData(
				new Rate { RateID  = 1, HouseID = 1, Comment = "good", LandLordReply = "thanks", Star = 5, StudentID = 4, CreatedBy = 4 },
				new Rate { RateID = 2, HouseID = 1, Comment = "good", LandLordReply = "thanks", Star = 5, StudentID = 4, CreatedBy = 4 },
				new Rate { RateID = 3, HouseID = 2, Comment = "good", LandLordReply = "thanks", Star = 5, StudentID = 4, CreatedBy = 4 },
				new Rate { RateID = 4, HouseID = 3, Comment = "good", LandLordReply = "thanks", Star = 5, StudentID = 4, CreatedBy = 4 }
			);

			base.OnModelCreating(modelBuilder);
		}
	}
}
