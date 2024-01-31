using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class AddOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "Orderss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartQuantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Cart_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartId", "CartQuantity", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 5, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 31, 23, 13, 50, 11, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2024, 1, 31, 23, 13, 50, 10, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CartID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CartID", "Price" },
                values: new object[] { 1, 30.0 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CartID", "Price" },
                values: new object[] { 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CartID", "OrderDate" },
                values: new object[] { 1, new DateTime(2024, 1, 31, 23, 13, 50, 11, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CartID", "OrderDate" },
                values: new object[] { 1, new DateTime(2024, 1, 31, 23, 13, 50, 11, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.CreateIndex(
                name: "IX_Orderss_CartID",
                table: "Orderss",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CartID",
                table: "OrderItems",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Cart_CartID",
                table: "OrderItems",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Cart_CartID",
                table: "Orderss",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Cart_CartID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Cart_CartID",
                table: "Orderss");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Orderss_CartID",
                table: "Orderss");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CartID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "Orderss");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "OrderItems");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "Price",
                value: 25.5);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "Price",
                value: 25.5);

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
    }
}
