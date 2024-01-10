using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class addHashedPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 375, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 375, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 375, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 375, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4032), "$2a$11$llult9ExScsR2YO0uZO19.4smG59JTzAJNQSbX5doYbK3MPUOBfXO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4040), "$2a$11$llult9ExScsR2YO0uZO19.4smG59JTzAJNQSbX5doYbK3MPUOBfXO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4041), "$2a$11$llult9ExScsR2YO0uZO19.4smG59JTzAJNQSbX5doYbK3MPUOBfXO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4042), "$2a$11$llult9ExScsR2YO0uZO19.4smG59JTzAJNQSbX5doYbK3MPUOBfXO" });

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 8, 19, 21, 517, DateTimeKind.Utc).AddTicks(4245));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3334), "Aa@123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3339), "Aa@123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3340), "Aa@123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3341), "Aa@123456" });

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3458));
        }
    }
}
