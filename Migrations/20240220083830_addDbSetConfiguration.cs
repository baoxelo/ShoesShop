using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class addDbSetConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateDate", "Description", "ImageLink", "ModifyDate", "Name", "Slug", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2391), "Giày Boot da chất lượng cao sản xuất tại Việt Nam", null, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2403), "Giày Boot", "giay-boot", "Hoạt động" },
                    { 2, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2405), "Giày thể thao phù hợp với mọi hoạt động vui chơi (Nike, Adidas, Jordan, v.v)", null, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2406), "Giày thể thao", "giay-the-thao", "Hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "CreateDate", "Description", "ModifyDate", "Name", "Percent", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2585), "Không giảm", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2586), "00%", 0, "Hoạt động" },
                    { 2, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2588), "Giảm 20%", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2588), "20%", 20, "Hoạt động" },
                    { 3, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2590), "Giảm 30%", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2590), "30%", 30, "Hoạt động" },
                    { 4, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2591), "Giảm 40%", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2592), "40%", 40, "Hoạt động" },
                    { 5, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2593), "Giảm 50%", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2594), "50%", 50, "Hoạt động" },
                    { 6, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2595), "Giảm 60%", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2595), "60%", 60, "Hoạt động" },
                    { 7, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2597), "Giảm 70%", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2597), "70%", 70, "Hoạt động" },
                    { 8, new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2598), "Giảm 80%", new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2599), "80%", 80, "Hoạt động" }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
