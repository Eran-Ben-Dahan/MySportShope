using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportShope.API.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersoneTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    CardMonth = table.Column<int>(type: "int", nullable: false),
                    CardYear = table.Column<int>(type: "int", nullable: false),
                    CardCvv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PersoneTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoneTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Building = table.Column<int>(type: "int", nullable: false),
                    House = table.Column<int>(type: "int", nullable: false),
                    Zip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubCategorys_Categorys_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categorys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orderss",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    ShippingAddresID = table.Column<int>(type: "int", nullable: false),
                    PaymentID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecialDiscount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderss", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orderss_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false),
                    PersoneTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_PersoneTypes_PersoneTypeID",
                        column: x => x.PersoneTypeID,
                        principalTable: "PersoneTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SubCategorys_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "SubCategorys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoxSizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxSizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BoxSizes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    ColorsID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProduct", x => new { x.ColorsID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_ColorProduct_Colors_ColorsID",
                        column: x => x.ColorsID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersID = table.Column<int>(type: "int", nullable: false),
                    productID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orderss_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orderss",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sizes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "ID", "Name", "PersoneTypeID" },
                values: new object[,]
                {
                    { 1, "Shoes", 1 },
                    { 2, "Sportswear", 1 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "BDay", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eran0099@gmail.com", "Eran", "Ben Dahan", 548050910 });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Red" },
                    { 2, "yellow" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "CardCvv", "CardMonth", "CardNumber", "CardYear", "PaymentDate" },
                values: new object[] { 1, 123, 2, 134456775, 2024, new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.InsertData(
                table: "PersoneTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Men" },
                    { 2, "Women" },
                    { 3, "Kids" },
                    { 4, "Men & Women" }
                });

            migrationBuilder.InsertData(
                table: "ShippingAddres",
                columns: new[] { "ID", "Building", "City", "Country", "House", "StreetName", "Zip" },
                values: new object[] { 1, 13, "Netanya", "Israel", 5, "Rotem", 5677 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "ClientID", "LastLogin", "Password", "Type", "Username" },
                values: new object[] { 1, 0, new DateTime(2023, 8, 19, 20, 4, 59, 885, DateTimeKind.Local).AddTicks(3418), "1234", 999, "Eran" });

            migrationBuilder.InsertData(
                table: "Orderss",
                columns: new[] { "ID", "ClientID", "OrderDate", "PaymentID", "ShippingAddresID", "SpecialDiscount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4095), 1, 1, 0 },
                    { 2, 1, new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4108), 1, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "SubCategorys",
                columns: new[] { "ID", "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Running shoes" },
                    { 2, 1, "Basketball shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Manufacturer", "Name", "PersoneTypeID", "SubCategoryID" },
                values: new object[] { 1, "A beautiful and comfortable shoe", "Nike", "Sport Shoes ", 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Manufacturer", "Name", "PersoneTypeID", "SubCategoryID" },
                values: new object[] { 2, "Butebull Tshert", "Nike", "Sport Tshert ", 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Manufacturer", "Name", "PersoneTypeID", "SubCategoryID" },
                values: new object[] { 3, "Ball", "Nike", "Ball ", 1, 1 });

            migrationBuilder.InsertData(
                table: "BoxSizes",
                columns: new[] { "ID", "Height", "Length", "ProductID", "Weight", "Width" },
                values: new object[,]
                {
                    { 1, 2.5, 10.0, 1, 5.0, 5.0 },
                    { 2, 3.0, 8.0, 2, 3.0, 4.0 },
                    { 3, 1.0, 10.0, 3, 5.0, 9.0 }
                });

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "ColorsID", "ProductID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "Alt", "Description", "Name", "ProductID", "Title", "URL" },
                values: new object[] { 1, "Black Sport Shoes ", "A beautiful and comfortable shoe", "Sport Shoes ", 1, "Shoes", "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/88c3280a-1b77-4cf9-957f-d71b91e90393/revolution-6-road-running-shoes-sP4fgd.png" });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "OrdersID", "Price", "Quantity", "productID" },
                values: new object[,]
                {
                    { 1, 1, 25.5, 2, 1 },
                    { 2, 1, 25.5, 2, 2 },
                    { 3, 2, 25.5, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "ProductID", "SizeName" },
                values: new object[] { 1, 1, "49" });

            migrationBuilder.CreateIndex(
                name: "IX_BoxSizes_ProductID",
                table: "BoxSizes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductID",
                table: "ColorProduct",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductID",
                table: "Images",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrdersID",
                table: "OrderItems",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_productID",
                table: "OrderItems",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Orderss_ClientID",
                table: "Orderss",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PersoneTypeID",
                table: "Products",
                column: "PersoneTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryID",
                table: "Products",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_ProductID",
                table: "Sizes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorys_CategoryID",
                table: "SubCategorys",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxSizes");

            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ShippingAddres");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Orderss");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "PersoneTypes");

            migrationBuilder.DropTable(
                name: "SubCategorys");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}
