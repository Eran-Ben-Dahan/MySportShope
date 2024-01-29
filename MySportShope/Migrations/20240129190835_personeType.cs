using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class personeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
