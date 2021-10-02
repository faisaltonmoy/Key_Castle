using Microsoft.EntityFrameworkCore.Migrations;

namespace Key_Castle_DataAccess.Migrations
{
    public partial class initToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Admin_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Admin_id);
                });

            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    Buyer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.Buyer_id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_name = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    Seller_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.Seller_id);
                });

            migrationBuilder.CreateTable(
                name: "Buyer_Profile",
                columns: table => new
                {
                    Buyer_pro_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Item_purchase = table.Column<string>(nullable: true),
                    Buyer_photo = table.Column<string>(nullable: true),
                    Buyer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer_Profile", x => x.Buyer_pro_id);
                    table.ForeignKey(
                        name: "FK_Buyer_Profile_Buyer_Buyer_id",
                        column: x => x.Buyer_id,
                        principalTable: "Buyer",
                        principalColumn: "Buyer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Product_name = table.Column<string>(nullable: true),
                    Product_photo = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Category_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_id);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category_id",
                        column: x => x.Category_id,
                        principalTable: "Category",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seller_Profile",
                columns: table => new
                {
                    Seller_pro_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(nullable: true),
                    Seller_photo = table.Column<string>(nullable: true),
                    Item_sold = table.Column<int>(nullable: false),
                    Seller_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller_Profile", x => x.Seller_pro_id);
                    table.ForeignKey(
                        name: "FK_Seller_Profile_Seller_Seller_id",
                        column: x => x.Seller_id,
                        principalTable: "Seller",
                        principalColumn: "Seller_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Details",
                columns: table => new
                {
                    Order_details_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Product_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => x.Order_details_id);
                    table.ForeignKey(
                        name: "FK_Order_Details_Product_Product_id",
                        column: x => x.Product_id,
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Order_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    Order_details_id = table.Column<int>(nullable: false),
                    Product_id = table.Column<int>(nullable: true),
                    Buyer_id = table.Column<int>(nullable: false),
                    Seller_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Order_id);
                    table.ForeignKey(
                        name: "FK_Order_Buyer_Buyer_id",
                        column: x => x.Buyer_id,
                        principalTable: "Buyer",
                        principalColumn: "Buyer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Order_Details_Order_details_id",
                        column: x => x.Order_details_id,
                        principalTable: "Order_Details",
                        principalColumn: "Order_details_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Product_Product_id",
                        column: x => x.Product_id,
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Seller_Seller_id",
                        column: x => x.Seller_id,
                        principalTable: "Seller",
                        principalColumn: "Seller_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(

                name: "Cart",
                columns: table => new
                {
                    Cart_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total_qty = table.Column<int>(nullable: false),
                    Total_price = table.Column<int>(nullable: false),
                    Buyer_id = table.Column<int>(nullable: false),
                    Order_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Cart_id);
                    table.ForeignKey(
                        name: "FK_Cart_Buyer_Buyer_id",
                        column: x => x.Buyer_id,
                        principalTable: "Buyer",
                        principalColumn: "Buyer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Order_Order_id",
                        column: x => x.Order_id,
                        principalTable: "Order",
                        principalColumn: "Order_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Pay_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    Method = table.Column<string>(nullable: true),
                    Cart_id = table.Column<int>(nullable: true),
                    Seller_id = table.Column<int>(nullable: false),
                    Buyer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Pay_id);
                    table.ForeignKey(
                        name: "FK_Payment_Buyer_Buyer_id",
                        column: x => x.Buyer_id,
                        principalTable: "Buyer",
                        principalColumn: "Buyer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Cart_Cart_id",
                        column: x => x.Cart_id,
                        principalTable: "Cart",
                        principalColumn: "Cart_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Seller_Seller_id",
                        column: x => x.Seller_id,
                        principalTable: "Seller",
                        principalColumn: "Seller_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buyer_Profile_Buyer_id",
                table: "Buyer_Profile",
                column: "Buyer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Buyer_id",
                table: "Cart",
                column: "Buyer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Order_id",
                table: "Cart",
                column: "Order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Buyer_id",
                table: "Order",
                column: "Buyer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Order_details_id",
                table: "Order",
                column: "Order_details_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Product_id",
                table: "Order",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Seller_id",
                table: "Order",
                column: "Seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_Product_id",
                table: "Order_Details",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Buyer_id",
                table: "Payment",
                column: "Buyer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Cart_id",
                table: "Payment",
                column: "Cart_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Seller_id",
                table: "Payment",
                column: "Seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_id",
                table: "Product",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_Profile_Seller_id",
                table: "Seller_Profile",
                column: "Seller_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Buyer_Profile");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Seller_Profile");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Buyer");

            migrationBuilder.DropTable(
                name: "Order_Details");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
