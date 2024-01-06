using Microsoft.EntityFrameworkCore;

namespace MockPJ.Models
{
	public class BaseContext : DbContext
	{
		public BaseContext(DbContextOptions opt) :base(opt) { }

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

			base.OnModelCreating(modelBuilder);
		}
	}
}
