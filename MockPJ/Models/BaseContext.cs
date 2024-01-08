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
				new User { UserID = 1 , Email = "admin@gmail.com", RoleID = 4, Active = true, DisplayName = "Admin", PhoneNumber = "0123456789", Password = "Aa@123456" }
			);

			base.OnModelCreating(modelBuilder);
		}
	}
}
