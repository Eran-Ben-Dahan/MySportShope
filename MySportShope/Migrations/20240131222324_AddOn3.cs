using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class AddOn3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 2, 1, 0, 23, 23, 446, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 2, 1, 0, 23, 23, 446, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 2, 1, 0, 23, 23, 446, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2024, 2, 1, 0, 23, 23, 445, DateTimeKind.Local).AddTicks(174));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Products");

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
    }
}
