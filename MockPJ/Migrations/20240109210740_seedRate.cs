using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class seedRate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "RateID", "Comment", "CreatedBy", "CreatedDate", "HouseID", "LandLordReply", "LastModifiedBy", "LastModifiedDate", "Star", "StudentID" },
                values: new object[,]
                {
                    { 1, "good", 4, new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5055), 1, "thanks", null, null, 5, 4 },
                    { 2, "good", 4, new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5058), 1, "thanks", null, null, 5, 4 },
                    { 3, "good", 4, new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5059), 2, "thanks", null, null, 5, 4 },
                    { 4, "good", 4, new DateTime(2024, 1, 9, 21, 7, 37, 102, DateTimeKind.Utc).AddTicks(5060), 3, "thanks", null, null, 5, 4 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2727));
        }
    }
}
