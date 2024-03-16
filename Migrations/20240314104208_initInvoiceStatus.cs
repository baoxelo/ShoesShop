using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class initInvoiceStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InvoiceStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatus", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(174), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(354), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(356), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(358), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(359), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 3, 14, 17, 42, 7, 667, DateTimeKind.Local).AddTicks(365) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_StatusId",
                table: "Invoice",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_InvoiceStatus_StatusId",
                table: "Invoice",
                column: "StatusId",
                principalTable: "InvoiceStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_InvoiceStatus_StatusId",
                table: "Invoice");

            migrationBuilder.DropTable(
                name: "InvoiceStatus");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_StatusId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Invoice");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 948, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 3, 14, 17, 5, 17, 948, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 948, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 3, 14, 17, 5, 17, 948, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(81), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(84), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(89), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(91), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(95), new DateTime(2024, 3, 14, 17, 5, 17, 949, DateTimeKind.Local).AddTicks(95) });
        }
    }
}
