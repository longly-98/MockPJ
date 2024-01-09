using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class addHouseSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressID",
                table: "Campuses");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "Addresses", "CreatedDate", "GoogleMapLocation", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, "so 1, ngách 1, ngõ 1, đường 1", new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4864), "111111,1111111", null },
                    { 2, "so 2, ngách 1, ngõ 1, đường 1", new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4866), "111111,1111111", null },
                    { 3, "so 3, ngách 1, ngõ 1, đường 1", new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4867), "111111,1111111", null }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "DistrictID", "CreatedDate", "DistrictName", "LastModifiedDate" },
                values: new object[] { 1, new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4962), "Dong Da", null });

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

            migrationBuilder.InsertData(
                table: "Campuses",
                columns: new[] { "CampusId", "AddressID", "CampusName", "CreatedDate", "LastModifiedDate" },
                values: new object[] { 1, 1, "Campus A", new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4940), null });

            migrationBuilder.InsertData(
                table: "Communes",
                columns: new[] { "CommuneID", "CommuneName", "CreatedDate", "DistrictID", "LastModifiedDate" },
                values: new object[] { 1, "Phuong Lien", new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(4985), 1, null });

            migrationBuilder.InsertData(
                table: "Vill",
                columns: new[] { "VillageId", "CommuneID", "CreatedDate", "LastModifiedDate", "VillageName" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5005), null, "Village A" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "HouseID", "AddressID", "CampusID", "CreatedBy", "CreatedDate", "HouseName", "Information", "LandLordID", "LastModifiedBy", "LastModifiedDate", "PowerPrice", "VillageID", "WaterPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5026), "House A", "AC, Hot water", 3, null, null, 4000f, 1, 30000f },
                    { 2, 2, 1, 1, new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5029), "House B", "AC, Hot water", 3, null, null, 4000f, 1, 30000f },
                    { 3, 3, 1, 1, new DateTime(2024, 1, 9, 10, 52, 10, 596, DateTimeKind.Utc).AddTicks(5032), "House C", "AC, Hot water", 3, null, null, 4000f, 1, 30000f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "AdressID",
                table: "Campuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7313));
        }
    }
}
