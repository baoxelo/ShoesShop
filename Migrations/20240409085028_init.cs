using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 255, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageLink = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 100, nullable: true),
                    Percent = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenderType = table.Column<string>(type: "nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Status = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 255, nullable: true),
                    ImageLink = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 500, nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 255, nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: true),
                    CurrentPrice = table.Column<double>(type: "REAL", nullable: true),
                    ImageLink = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscountId = table.Column<int>(type: "INTEGER", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "INTEGER", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppUserId = table.Column<string>(type: "TEXT", nullable: true),
                    TotalPrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppUserId = table.Column<string>(type: "TEXT", nullable: true),
                    InvoiceCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TotalPrice = table.Column<double>(type: "REAL", nullable: true),
                    DateOrdered = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_InvoiceStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "InvoiceStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageLink = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    SizeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItems_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductItems_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateDate", "Description", "ImageLink", "ModifyDate", "Name", "Slug", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8606), "Giày Boot da chất lượng cao sản xuất tại Việt Nam", null, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8621), "Giày Boot", "giay-boot", "Hoạt động" },
                    { 2, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8623), "Giày thể thao phù hợp với mọi hoạt động vui chơi (Nike, Adidas, Jordan, v.v)", null, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8623), "Giày thể thao", "giay-the-thao", "Hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "CreateDate", "Description", "ModifyDate", "Name", "Percent", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8799), "Không giảm", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8800), "00%", 0, "Hoạt động" },
                    { 2, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8801), "Giảm 20%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8802), "20%", 20, "Hoạt động" },
                    { 3, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8803), "Giảm 30%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8804), "30%", 30, "Hoạt động" },
                    { 4, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8805), "Giảm 40%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8805), "40%", 40, "Hoạt động" },
                    { 5, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8806), "Giảm 50%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8807), "50%", 50, "Hoạt động" },
                    { 6, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8808), "Giảm 60%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8809), "60%", 60, "Hoạt động" },
                    { 7, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8810), "Giảm 70%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8810), "70%", 70, "Hoạt động" },
                    { 8, new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8812), "Giảm 80%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8812), "80%", 80, "Hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderType" },
                values: new object[,]
                {
                    { 1, "Unisex" },
                    { 2, "Nam" },
                    { 3, "Nữ" },
                    { 4, "Trẻ em" }
                });

            migrationBuilder.InsertData(
                table: "InvoiceStatus",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "Chúng tôi sẽ sớm liên hệ với bạn", "Đang chờ xác nhận" },
                    { 2, "Đơn hàng đang được vận chuyển đến bạn", "Đang giao" },
                    { 3, "Đơn hàng đã được hoàn tất", "Hoàn tất" },
                    { 4, "Đơn hàng đã bị hủy", "Đơn hàng bị hủy" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "207d53fc-fff4-4469-8cd2-f514167e7d79", null, "Administrator", "ADMINISTRATOR" },
                    { "34dc5329-a70a-463e-a239-a3aceddd6314", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "US = 4.5, UK = 2.5, 21.3 cm", "35" },
                    { 2, "US = 5.5, UK = 3.5, 22.2 cm", "36" },
                    { 3, "US = 4, UK = 4.5, 23 cm", "37" },
                    { 4, "US = 5, UK = 5.5, 23.8 cm", "38" },
                    { 5, "US = 6, UK = 6.5, 24.6 cm", "39" },
                    { 6, "US = 7, UK = 7.5, 25.4 cm", "40" },
                    { 7, "US = 8, UK = 8.5, 26.2 cm", "41" },
                    { 8, "US = 8, UK = 8.5, 26.2 cm", "42" },
                    { 9, "US = 8, UK = 8.5, 26.2 cm", "43" },
                    { 10, "US = 8, UK = 8.5, 26.2 cm", "44" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_AppUserId",
                table: "Cart",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductItemId",
                table: "CartItem",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_AppUserId",
                table: "Invoice",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_StatusId",
                table: "Invoice",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_InvoiceId",
                table: "InvoiceItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_ProductItemId",
                table: "InvoiceItem",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DiscountId",
                table: "Product",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_GenderId",
                table: "Product",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_ProductId",
                table: "ProductItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_SizeId",
                table: "ProductItems",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "ProductItems");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "InvoiceStatus");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
