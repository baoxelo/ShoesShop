using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class initDateOrdered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOrdered",
                table: "Invoice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4810), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4812), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4814), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4816), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4818), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4819), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 3, 14, 17, 59, 44, 610, DateTimeKind.Local).AddTicks(4822) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOrdered",
                table: "Invoice");

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
        }
    }
}
