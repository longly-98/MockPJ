using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class addIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 22, 55, 33, 949, DateTimeKind.Utc).AddTicks(3458));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 22, 45, 945, DateTimeKind.Utc).AddTicks(6801));
        }
    }
}
