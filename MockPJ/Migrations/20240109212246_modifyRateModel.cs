using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class modifyRateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LandLordReply",
                table: "Rates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Rates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LandLordReply",
                table: "Rates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Rates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(4889));
        }
    }
}
