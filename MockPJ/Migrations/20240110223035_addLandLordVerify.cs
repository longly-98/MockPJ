using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class addLandLordVerify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Verified",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 316, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 316, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 316, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 316, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Verified" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8608), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq", false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "Verified" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8614), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq", false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "Verified" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8616), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq", false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password", "Verified" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8617), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq", false });

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8896));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Verified",
                table: "Users");

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
    }
}
