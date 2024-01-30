using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class productDTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 29, 22, 59, 26, 450, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 29, 22, 59, 26, 450, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 29, 22, 59, 26, 450, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2024, 1, 29, 22, 59, 26, 448, DateTimeKind.Local).AddTicks(6740));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 29, 21, 8, 35, 238, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 29, 21, 8, 35, 238, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 29, 21, 8, 35, 238, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2024, 1, 29, 21, 8, 35, 236, DateTimeKind.Local).AddTicks(8813));
        }
    }
}
