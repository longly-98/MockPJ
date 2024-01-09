using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class updateRoomSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomName",
                table: "RoomTypes",
                newName: "RoomTypeName");

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

            migrationBuilder.InsertData(
                table: "HouseImages",
                columns: new[] { "ImageID", "CreatedBy", "CreatedDate", "HouseID", "ImageLink", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2777), 1, "link", null, null },
                    { 2, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2779), 1, "link", null, null },
                    { 3, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2780), 2, "link", null, null },
                    { 4, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2781), 2, "link", null, null },
                    { 5, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2782), 3, "link", null, null },
                    { 6, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2783), 3, "link", null, null },
                    { 7, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2783), 3, "link", null, null }
                });

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

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "RoomTypeID", "CreatedDate", "LastModifiedDate", "RoomTypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2879), null, "Shared hostel" },
                    { 2, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2881), null, "Apartment" },
                    { 3, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2881), null, "Mini apartment" },
                    { 4, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2882), null, "Homestays" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusID", "CreatedDate", "LastModifiedDate", "StatusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2811), null, "Available" },
                    { 2, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2813), null, "Not Available" }
                });

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

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomID", "Area", "BuildingNumber", "CreatedBy", "CreatedDate", "CurrentAmountOfPeople", "FloorNumber", "HouseID", "LastModifiedBy", "LastModifiedDate", "MaxAmountOfPeople", "RoomName", "RoomPrice", "RoomTypeID", "StatusID" },
                values: new object[,]
                {
                    { 1, "20m2", 1, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2907), 0, 1, 1, null, null, 3, "101", 1000000f, 1, 1 },
                    { 2, "20m2", 1, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2913), 1, 1, 1, null, null, 3, "102", 900000f, 1, 1 },
                    { 3, "25m2", 2, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2916), 0, 1, 2, null, null, 3, "103", 3000000f, 3, 1 },
                    { 4, "28m2", 1, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2917), 0, 1, 2, null, null, 3, "104", 4000000f, 3, 1 },
                    { 5, "40m2", 1, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2919), 0, 1, 3, null, null, 3, "105", 10000000f, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "RoomImages",
                columns: new[] { "ImageID", "CreatedBy", "CreatedDate", "ImageLink", "LastModifiedBy", "LastModifiedDate", "RoomID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2942), "link", null, null, 1 },
                    { 2, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2946), "link", null, null, 2 },
                    { 3, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2947), "link", null, null, 3 },
                    { 4, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2948), "link", null, null, 4 },
                    { 5, null, new DateTime(2024, 1, 9, 17, 1, 28, 675, DateTimeKind.Utc).AddTicks(2949), "link", null, null, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "RoomTypeName",
                table: "RoomTypes",
                newName: "RoomName");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5005));
        }
    }
}
