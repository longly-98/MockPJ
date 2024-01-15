using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class changeRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.CreateTable(
                name: "UserRequests",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequestType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRequests", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_UserRequests_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.InsertData(
                table: "UserRequests",
                columns: new[] { "RequestID", "CreatedDate", "Description", "LastModifiedDate", "RequestType", "Status", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4868), null, null, 0, 0, 3 },
                    { 2, new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4871), "have AC and near school", null, 1, 0, 4 },
                    { 3, new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4872), "cheap water", null, 1, 0, 4 }
                });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 35, 923, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 35, 923, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 35, 923, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 35, 923, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(3778), "$2a$11$j/CmF8QvmZMLGDaCdm3vYO29E7Y/HbGsRixnckUoL8hrzDyMQe6I2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(3791), "$2a$11$j/CmF8QvmZMLGDaCdm3vYO29E7Y/HbGsRixnckUoL8hrzDyMQe6I2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(3794), "$2a$11$j/CmF8QvmZMLGDaCdm3vYO29E7Y/HbGsRixnckUoL8hrzDyMQe6I2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(3796), "$2a$11$j/CmF8QvmZMLGDaCdm3vYO29E7Y/HbGsRixnckUoL8hrzDyMQe6I2" });

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.CreateIndex(
                name: "IX_UserRequests_UserID",
                table: "UserRequests",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRequests");

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_Request_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.InsertData(
                table: "Request",
                columns: new[] { "RequestID", "CreatedDate", "Description", "LastModifiedDate", "RequestType", "Status", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2111), null, null, 0, 0, 3 },
                    { 2, new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2114), "have AC and near school", null, 1, 0, 4 },
                    { 3, new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2116), "cheap water", null, 1, 0, 4 }
                });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 2, 875, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 2, 875, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 2, 875, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 2, 875, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 8, 3, 13, DateTimeKind.Utc).AddTicks(9543), "$2a$11$npJQLMKo9d5tWsfJVw6nb.Nj5YpCgFSPR/DFKOc0IPfhRjBfb2CaW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 8, 3, 13, DateTimeKind.Utc).AddTicks(9555), "$2a$11$npJQLMKo9d5tWsfJVw6nb.Nj5YpCgFSPR/DFKOc0IPfhRjBfb2CaW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 8, 3, 13, DateTimeKind.Utc).AddTicks(9557), "$2a$11$npJQLMKo9d5tWsfJVw6nb.Nj5YpCgFSPR/DFKOc0IPfhRjBfb2CaW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 8, 3, 13, DateTimeKind.Utc).AddTicks(9558), "$2a$11$npJQLMKo9d5tWsfJVw6nb.Nj5YpCgFSPR/DFKOc0IPfhRjBfb2CaW" });

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 8, 3, 14, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserID",
                table: "Request",
                column: "UserID");
        }
    }
}
