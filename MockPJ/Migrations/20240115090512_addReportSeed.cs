using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class addReportSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "CampusId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Communes",
                keyColumn: "CommuneID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "HouseImages",
                keyColumn: "ImageID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "HouseID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "RateID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportID", "CreatedBy", "CreatedDate", "HouseID", "LastModifiedBy", "LastModifiedDate", "ReportContent", "StudentID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8650), 1, null, null, "no no no", 4 },
                    { 2, null, new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8652), 2, null, null, "not good", 4 },
                    { 3, null, new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8653), 3, null, null, "won't return", 4 }
                });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "RoomTypeID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "UserRequests",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "UserRequests",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "UserRequests",
                keyColumn: "RequestID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 474, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 474, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 474, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 474, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7756), "$2a$11$pGT4oIX/Ic4UAED.JbPsS.WLWIzoopLMa.vmUsCHA82.8Zx9L7.8O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7769), "$2a$11$pGT4oIX/Ic4UAED.JbPsS.WLWIzoopLMa.vmUsCHA82.8Zx9L7.8O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7771), "$2a$11$pGT4oIX/Ic4UAED.JbPsS.WLWIzoopLMa.vmUsCHA82.8Zx9L7.8O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(7773), "$2a$11$pGT4oIX/Ic4UAED.JbPsS.WLWIzoopLMa.vmUsCHA82.8Zx9L7.8O" });

            migrationBuilder.UpdateData(
                table: "Villages",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 9, 5, 11, 618, DateTimeKind.Utc).AddTicks(8058));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "UserRequests",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "UserRequests",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "UserRequests",
                keyColumn: "RequestID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 21, 29, 36, 61, DateTimeKind.Utc).AddTicks(4872));

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
        }
    }
}
