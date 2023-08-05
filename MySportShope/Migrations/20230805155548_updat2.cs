using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class updat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Products_ProductID",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Payments_PaymentId",
                table: "Orderss");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoneType_Products_ProductID",
                table: "PersoneType");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorys_Categorys_CategoryID",
                table: "SubCategorys");

            migrationBuilder.DropIndex(
                name: "IX_Colors_ProductID",
                table: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoneType",
                table: "PersoneType");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "SubCategorys");

            migrationBuilder.DropColumn(
                name: "BoxSizeID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Colors");

            migrationBuilder.RenameTable(
                name: "PersoneType",
                newName: "PersoneTypes");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Products",
                newName: "SubCategoryID");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Orderss",
                newName: "PaymentID");

            migrationBuilder.RenameIndex(
                name: "IX_Orderss_PaymentId",
                table: "Orderss",
                newName: "IX_Orderss_PaymentID");

            migrationBuilder.RenameIndex(
                name: "IX_PersoneType_ProductID",
                table: "PersoneTypes",
                newName: "IX_PersoneTypes_ProductID");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "SubCategorys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "Orderss",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersoneTypeID",
                table: "Categorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "BoxSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoneTypes",
                table: "PersoneTypes",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    ColorsID = table.Column<int>(type: "int", nullable: false),
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProduct", x => new { x.ColorsID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_ColorProduct_Colors_ColorsID",
                        column: x => x.ColorsID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryID",
                table: "Products",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Orderss_ClientID",
                table: "Orderss",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_PersoneTypeID",
                table: "Categorys",
                column: "PersoneTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BoxSizes_ProductID",
                table: "BoxSizes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductsID",
                table: "ColorProduct",
                column: "ProductsID");

            migrationBuilder.AddForeignKey(
                name: "FK_BoxSizes_Products_ProductID",
                table: "BoxSizes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_PersoneTypes_PersoneTypeID",
                table: "Categorys",
                column: "PersoneTypeID",
                principalTable: "PersoneTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductID",
                table: "Images",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Clients_ClientID",
                table: "Orderss",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Payments_PaymentID",
                table: "Orderss",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoneTypes_Products_ProductID",
                table: "PersoneTypes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategorys_SubCategoryID",
                table: "Products",
                column: "SubCategoryID",
                principalTable: "SubCategorys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorys_Categorys_CategoryID",
                table: "SubCategorys",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoxSizes_Products_ProductID",
                table: "BoxSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_PersoneTypes_PersoneTypeID",
                table: "Categorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Clients_ClientID",
                table: "Orderss");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Payments_PaymentID",
                table: "Orderss");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoneTypes_Products_ProductID",
                table: "PersoneTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategorys_SubCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorys_Categorys_CategoryID",
                table: "SubCategorys");

            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orderss_ClientID",
                table: "Orderss");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_PersoneTypeID",
                table: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_BoxSizes_ProductID",
                table: "BoxSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoneTypes",
                table: "PersoneTypes");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersoneTypeID",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "BoxSizes");

            migrationBuilder.RenameTable(
                name: "PersoneTypes",
                newName: "PersoneType");

            migrationBuilder.RenameColumn(
                name: "SubCategoryID",
                table: "Products",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "PaymentID",
                table: "Orderss",
                newName: "PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Orderss_PaymentID",
                table: "Orderss",
                newName: "IX_Orderss_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_PersoneTypes_ProductID",
                table: "PersoneType",
                newName: "IX_PersoneType_ProductID");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "SubCategorys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "SubCategorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BoxSizeID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Orderss",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoneType",
                table: "PersoneType",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ProductID",
                table: "Colors",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Products_ProductID",
                table: "Colors",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductID",
                table: "Images",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Payments_PaymentId",
                table: "Orderss",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersoneType_Products_ProductID",
                table: "PersoneType",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorys_Categorys_CategoryID",
                table: "SubCategorys",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "ID");
        }
    }
}
