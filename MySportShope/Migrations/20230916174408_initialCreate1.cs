using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class initialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 20, 44, 7, 614, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 20, 44, 7, 614, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 9, 16, 20, 44, 7, 614, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2023, 9, 16, 20, 44, 7, 612, DateTimeKind.Local).AddTicks(7523));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2023, 8, 19, 20, 4, 59, 885, DateTimeKind.Local).AddTicks(3418));
        }
    }
}
