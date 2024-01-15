using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class addRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Vill_VillageID",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Vill_Communes_CommuneID",
                table: "Vill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vill",
                table: "Vill");

            migrationBuilder.RenameTable(
                name: "Vill",
                newName: "Villages");

            migrationBuilder.RenameIndex(
                name: "IX_Vill_CommuneID",
                table: "Villages",
                newName: "IX_Villages_CommuneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villages",
                table: "Villages",
                column: "VillageId");

            migrationBuilder.CreateTable(
                name: "Request",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Villages_VillageID",
                table: "Houses",
                column: "VillageID",
                principalTable: "Villages",
                principalColumn: "VillageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Villages_Communes_CommuneID",
                table: "Villages",
                column: "CommuneID",
                principalTable: "Communes",
                principalColumn: "CommuneID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Villages_VillageID",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Villages_Communes_CommuneID",
                table: "Villages");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Villages",
                table: "Villages");

            migrationBuilder.RenameTable(
                name: "Villages",
                newName: "Vill");

            migrationBuilder.RenameIndex(
                name: "IX_Villages_CommuneID",
                table: "Vill",
                newName: "IX_Vill_CommuneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vill",
                table: "Vill",
                column: "VillageId");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 679, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 679, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 679, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 679, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1507), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1515), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1517), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1519), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu" });

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Vill_VillageID",
                table: "Houses",
                column: "VillageID",
                principalTable: "Vill",
                principalColumn: "VillageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vill_Communes_CommuneID",
                table: "Vill",
                column: "CommuneID",
                principalTable: "Communes",
                principalColumn: "CommuneID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
