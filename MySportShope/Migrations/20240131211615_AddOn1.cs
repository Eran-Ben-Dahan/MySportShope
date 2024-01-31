using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class AddOn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orderss_OrdersID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Cart_CartID",
                table: "Orderss");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Clients_ClientID",
                table: "Orderss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderss",
                table: "Orderss");

            migrationBuilder.RenameTable(
                name: "Orderss",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Orderss_ClientID",
                table: "Orders",
                newName: "IX_Orders_ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_Orderss_CartID",
                table: "Orders",
                newName: "IX_Orders_CartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrdersID",
                table: "OrderItems",
                column: "OrdersID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cart_CartID",
                table: "Orders",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientID",
                table: "Orders",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrdersID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cart_CartID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orderss");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ClientID",
                table: "Orderss",
                newName: "IX_Orderss_ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CartID",
                table: "Orderss",
                newName: "IX_Orderss_CartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderss",
                table: "Orderss",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 31, 23, 13, 50, 11, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Orderss",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 31, 23, 13, 50, 11, DateTimeKind.Local).AddTicks(9148));

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orderss_OrdersID",
                table: "OrderItems",
                column: "OrdersID",
                principalTable: "Orderss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Cart_CartID",
                table: "Orderss",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Clients_ClientID",
                table: "Orderss",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
