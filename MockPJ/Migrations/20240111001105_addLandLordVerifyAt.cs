using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockPJ.Migrations
{
    /// <inheritdoc />
    public partial class addLandLordVerifyAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VerrifiedAt",
                table: "Users",
                type: "datetime2",
                nullable: true);

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
                columns: new[] { "CreatedDate", "Password", "VerrifiedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1507), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "VerrifiedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1515), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "VerrifiedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1517), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password", "VerrifiedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1519), "$2a$11$vQdn.f4i13TVk5ylDm4rbeTa8UfZQAO7fcHZjNzruDwrrygRBGLuu", null });

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 11, 0, 11, 4, 804, DateTimeKind.Utc).AddTicks(1837));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerrifiedAt",
                table: "Users");

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
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8608), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8614), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8616), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8617), "$2a$11$ldoEhyWuw8MQvJNlJFKAeOIb0WEE0Y/xjPvUNkJRTkvzLic2e.joq" });

            migrationBuilder.UpdateData(
                table: "Vill",
                keyColumn: "VillageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 30, 32, 447, DateTimeKind.Utc).AddTicks(8896));
        }
    }
}
