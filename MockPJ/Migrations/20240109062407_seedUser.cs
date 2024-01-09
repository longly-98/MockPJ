using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class seedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Villages_VillageID",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Villages_Communes_CommuneID",
                table: "Villages");

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
                columns: new[] { "CreatedDate", "RoleID" },
                values: new object[] { new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7305), 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Active", "AddressID", "CreatedBy", "CreatedDate", "DisplayName", "Email", "FacebookURL", "FacebookUserID", "GoogleUserID", "IdentityCardBackSideImageLink", "IdentityCardFrontSideImageLink", "LastModifiedBy", "LastModifiedDate", "Password", "PhoneNumber", "ProfileImageLink", "RoleID" },
                values: new object[,]
                {
                    { 2, true, null, null, new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7310), "Staff", "staff@gmail.com", null, null, null, null, null, null, null, "Aa@123456", "0123456789", null, 2 },
                    { 3, true, null, null, new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7312), "LandLord", "landlord@gmail.com", null, null, null, null, null, null, null, "Aa@123456", "0123456789", null, 3 },
                    { 4, true, null, null, new DateTime(2024, 1, 9, 6, 24, 6, 622, DateTimeKind.Utc).AddTicks(7313), "Student", "student@gmail.com", null, null, null, null, null, null, null, "Aa@123456", "0123456789", null, 4 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

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

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 23, 39, 58, 170, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 23, 39, 58, 170, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 23, 39, 58, 170, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 23, 39, 58, 170, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "RoleID" },
                values: new object[] { new DateTime(2024, 1, 8, 23, 39, 58, 170, DateTimeKind.Utc).AddTicks(5620), 4 });

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
    }
}
