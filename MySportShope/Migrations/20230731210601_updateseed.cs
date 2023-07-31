using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class updateseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Products_ProductID",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Products_ProductID",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "PersoneType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "SubCategorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Sizes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Orderss",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersoneType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoneType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersoneType_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orderss_PaymentId",
                table: "Orderss",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PersoneType_ProductID",
                table: "PersoneType",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Products_ProductID",
                table: "Colors",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Payments_PaymentId",
                table: "Orderss",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Products_ProductID",
                table: "Sizes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Products_ProductID",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Payments_PaymentId",
                table: "Orderss");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Products_ProductID",
                table: "Sizes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PersoneType");

            migrationBuilder.DropIndex(
                name: "IX_Orderss_PaymentId",
                table: "Orderss");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "SubCategorys");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Orderss");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Sizes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "PersoneType",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Colors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Products_ProductID",
                table: "Colors",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Products_ProductID",
                table: "Sizes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");
        }
    }
}
