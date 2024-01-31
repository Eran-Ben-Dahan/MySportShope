using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class AddOn2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 31, 23, 18, 17, 209, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 31, 23, 18, 17, 209, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 31, 23, 18, 17, 209, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2024, 1, 31, 23, 18, 17, 207, DateTimeKind.Local).AddTicks(1715));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 31, 23, 16, 14, 700, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 31, 23, 16, 14, 700, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 31, 23, 16, 14, 700, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2024, 1, 31, 23, 16, 14, 699, DateTimeKind.Local).AddTicks(3207));
        }
    }
}
