using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class initCartAndInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5524), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5527), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5531), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5534), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 2, 27, 17, 7, 26, 832, DateTimeKind.Local).AddTicks(5539) });

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
                name: "IX_InvoiceItem_InvoiceId",
                table: "InvoiceItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_ProductItemId",
                table: "InvoiceItem",
                column: "ProductItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8707), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8911), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8913), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8915), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8917), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8919), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8924), new DateTime(2024, 2, 21, 16, 11, 21, 567, DateTimeKind.Local).AddTicks(8924) });
        }
    }
}
