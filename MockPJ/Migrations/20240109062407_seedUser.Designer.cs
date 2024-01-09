﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MockPJ.Models;

#nullable disable

namespace MockPJ.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20240109062407_seedUser")]
    partial class seedUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MockPJ.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"));

                    b.Property<string>("Addresses")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GoogleMapLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MockPJ.Models.Campus", b =>
                {
                    b.Property<int>("CampusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampusId"));

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<int>("AdressID")
                        .HasColumnType("int");

                    b.Property<string>("CampusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CampusId");

                    b.HasIndex("AddressID");

                    b.ToTable("Campuses");
                });

            modelBuilder.Entity("MockPJ.Models.Commune", b =>
                {
                    b.Property<int>("CommuneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommuneID"));

                    b.Property<string>("CommuneName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistrictID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CommuneID");

                    b.HasIndex("DistrictID");

                    b.ToTable("Communes");
                });

            modelBuilder.Entity("MockPJ.Models.District", b =>
                {
                    b.Property<int>("DistrictID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DistrictID");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("MockPJ.Models.House", b =>
                {
                    b.Property<int>("HouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseID"));

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<int?>("CampusID")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LandLordID")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("PowerPrice")
                        .HasColumnType("real");

                    b.Property<int?>("VillageID")
                        .HasColumnType("int");

                    b.Property<float>("WaterPrice")
                        .HasColumnType("real");

                    b.HasKey("HouseID");

                    b.HasIndex("AddressID")
                        .IsUnique();

                    b.HasIndex("CampusID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("LandLordID");

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("VillageID");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("MockPJ.Models.HouseImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HouseID")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ImageID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("HouseID");

                    b.HasIndex("LastModifiedBy");

                    b.ToTable("HouseImages");
                });

            modelBuilder.Entity("MockPJ.Models.Rate", b =>
                {
                    b.Property<int>("RateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RateID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HouseID")
                        .HasColumnType("int");

                    b.Property<string>("LandLordReply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("RateID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("HouseID");

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("StudentID");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("MockPJ.Models.Report", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HouseID")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReportContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ReportID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("HouseID");

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("StudentID");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("MockPJ.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuildingNumber")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentAmountOfPeople")
                        .HasColumnType("int");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<int>("HouseID")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxAmountOfPeople")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RoomPrice")
                        .HasColumnType("real");

                    b.Property<int?>("RoomTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("RoomID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("HouseID");

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("RoomTypeID");

                    b.HasIndex("StatusID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("MockPJ.Models.RoomHistory", b =>
                {
                    b.Property<int>("RoomHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomHistoryID"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("RoomHistoryID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomHistories");
                });

            modelBuilder.Entity("MockPJ.Models.RoomImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("ImageID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomImages");
                });

            modelBuilder.Entity("MockPJ.Models.RoomType", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeID");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("MockPJ.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("MockPJ.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FacebookURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookUserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoogleUserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCardBackSideImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCardFrontSideImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("AddressID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DisplayName")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Active = true,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7305),
                            DisplayName = "Admin",
                            Email = "admin@gmail.com",
                            Password = "Aa@123456",
                            PhoneNumber = "0123456789",
                            RoleID = 1
                        },
                        new
                        {
                            UserID = 2,
                            Active = true,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7310),
                            DisplayName = "Staff",
                            Email = "staff@gmail.com",
                            Password = "Aa@123456",
                            PhoneNumber = "0123456789",
                            RoleID = 2
                        },
                        new
                        {
                            UserID = 3,
                            Active = true,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7312),
                            DisplayName = "LandLord",
                            Email = "landlord@gmail.com",
                            Password = "Aa@123456",
                            PhoneNumber = "0123456789",
                            RoleID = 3
                        },
                        new
                        {
                            UserID = 4,
                            Active = true,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7313),
                            DisplayName = "Student",
                            Email = "student@gmail.com",
                            Password = "Aa@123456",
                            PhoneNumber = "0123456789",
                            RoleID = 4
                        });
                });

            modelBuilder.Entity("MockPJ.Models.UserRole", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7055),
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleID = 2,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7058),
                            RoleName = "Staff"
                        },
                        new
                        {
                            RoleID = 3,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7059),
                            RoleName = "LandLord"
                        },
                        new
                        {
                            RoleID = 4,
                            CreatedDate = new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7060),
                            RoleName = "Student"
                        });
                });

            modelBuilder.Entity("MockPJ.Models.Village", b =>
                {
                    b.Property<int>("VillageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VillageId"));

                    b.Property<int>("CommuneID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VillageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VillageId");

                    b.HasIndex("CommuneID");

                    b.ToTable("Vill");
                });

            modelBuilder.Entity("MockPJ.Models.Campus", b =>
                {
                    b.HasOne("MockPJ.Models.Address", "Address")
                        .WithMany("Campuses")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("MockPJ.Models.Commune", b =>
                {
                    b.HasOne("MockPJ.Models.District", "District")
                        .WithMany("Communes")
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("MockPJ.Models.House", b =>
                {
                    b.HasOne("MockPJ.Models.Address", "Address")
                        .WithOne("House")
                        .HasForeignKey("MockPJ.Models.House", "AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockPJ.Models.Campus", "Campus")
                        .WithMany("Houses")
                        .HasForeignKey("CampusID");

                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateHouses")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.User", "LandLord")
                        .WithMany("OwnHouses")
                        .HasForeignKey("LandLordID");

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyHouses")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("MockPJ.Models.Village", "Village")
                        .WithMany("Houses")
                        .HasForeignKey("VillageID");

                    b.Navigation("Address");

                    b.Navigation("Campus");

                    b.Navigation("Creator");

                    b.Navigation("LandLord");

                    b.Navigation("Modifier");

                    b.Navigation("Village");
                });

            modelBuilder.Entity("MockPJ.Models.HouseImage", b =>
                {
                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateHouseImages")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.House", "House")
                        .WithMany("HouseImages")
                        .HasForeignKey("HouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyHouseImages")
                        .HasForeignKey("LastModifiedBy");

                    b.Navigation("Creator");

                    b.Navigation("House");

                    b.Navigation("Modifier");
                });

            modelBuilder.Entity("MockPJ.Models.Rate", b =>
                {
                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateRates")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.House", "House")
                        .WithMany("Rates")
                        .HasForeignKey("HouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyRates")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("MockPJ.Models.User", "Student")
                        .WithMany("StudentRates")
                        .HasForeignKey("StudentID");

                    b.Navigation("Creator");

                    b.Navigation("House");

                    b.Navigation("Modifier");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MockPJ.Models.Report", b =>
                {
                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateReports")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.House", "House")
                        .WithMany("Reports")
                        .HasForeignKey("HouseID");

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyReports")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("MockPJ.Models.User", "Student")
                        .WithMany("StudentReports")
                        .HasForeignKey("StudentID");

                    b.Navigation("Creator");

                    b.Navigation("House");

                    b.Navigation("Modifier");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MockPJ.Models.Room", b =>
                {
                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateRooms")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.House", "House")
                        .WithMany("Rooms")
                        .HasForeignKey("HouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyRooms")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("MockPJ.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID");

                    b.HasOne("MockPJ.Models.Status", "Status")
                        .WithMany("Rooms")
                        .HasForeignKey("StatusID");

                    b.Navigation("Creator");

                    b.Navigation("House");

                    b.Navigation("Modifier");

                    b.Navigation("RoomType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("MockPJ.Models.RoomHistory", b =>
                {
                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateRoomHistories")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyRoomHistories")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("MockPJ.Models.Room", "Room")
                        .WithMany("RoomHistories")
                        .HasForeignKey("RoomID");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MockPJ.Models.RoomImage", b =>
                {
                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateRoomImages")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyRoomImages")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("MockPJ.Models.Room", "Room")
                        .WithMany("RoomImages")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Modifier");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MockPJ.Models.User", b =>
                {
                    b.HasOne("MockPJ.Models.Address", "Address")
                        .WithMany("Users")
                        .HasForeignKey("AddressID");

                    b.HasOne("MockPJ.Models.User", "Creator")
                        .WithMany("CreateUsers")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MockPJ.Models.User", "Modifier")
                        .WithMany("ModifyUsers")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("MockPJ.Models.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MockPJ.Models.Village", b =>
                {
                    b.HasOne("MockPJ.Models.Commune", "Commune")
                        .WithMany("Villages")
                        .HasForeignKey("CommuneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commune");
                });

            modelBuilder.Entity("MockPJ.Models.Address", b =>
                {
                    b.Navigation("Campuses");

                    b.Navigation("House")
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("MockPJ.Models.Campus", b =>
                {
                    b.Navigation("Houses");
                });

            modelBuilder.Entity("MockPJ.Models.Commune", b =>
                {
                    b.Navigation("Villages");
                });

            modelBuilder.Entity("MockPJ.Models.District", b =>
                {
                    b.Navigation("Communes");
                });

            modelBuilder.Entity("MockPJ.Models.House", b =>
                {
                    b.Navigation("HouseImages");

                    b.Navigation("Rates");

                    b.Navigation("Reports");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("MockPJ.Models.Room", b =>
                {
                    b.Navigation("RoomHistories");

                    b.Navigation("RoomImages");
                });

            modelBuilder.Entity("MockPJ.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("MockPJ.Models.Status", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("MockPJ.Models.User", b =>
                {
                    b.Navigation("CreateHouseImages");

                    b.Navigation("CreateHouses");

                    b.Navigation("CreateRates");

                    b.Navigation("CreateReports");

                    b.Navigation("CreateRoomHistories");

                    b.Navigation("CreateRoomImages");

                    b.Navigation("CreateRooms");

                    b.Navigation("CreateUsers");

                    b.Navigation("ModifyHouseImages");

                    b.Navigation("ModifyHouses");

                    b.Navigation("ModifyRates");

                    b.Navigation("ModifyReports");

                    b.Navigation("ModifyRoomHistories");

                    b.Navigation("ModifyRoomImages");

                    b.Navigation("ModifyRooms");

                    b.Navigation("ModifyUsers");

                    b.Navigation("OwnHouses");

                    b.Navigation("StudentRates");

                    b.Navigation("StudentReports");
                });

            modelBuilder.Entity("MockPJ.Models.UserRole", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("MockPJ.Models.Village", b =>
                {
                    b.Navigation("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
