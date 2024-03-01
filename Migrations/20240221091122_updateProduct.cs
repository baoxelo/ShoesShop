using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class updateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CurrentPrice",
                table: "Product",
                type: "float",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPrice",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2391), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2405), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2588), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2590), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2591), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2593), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 2, 20, 15, 38, 29, 418, DateTimeKind.Local).AddTicks(2599) });
        }
    }
}
