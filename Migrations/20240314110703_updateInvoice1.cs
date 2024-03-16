using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class updateInvoice1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceCode",
                table: "Invoice",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(952), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1135), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1137), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1142), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1144), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1145), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1147), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1149), new DateTime(2024, 3, 14, 18, 7, 2, 418, DateTimeKind.Local).AddTicks(1149) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceCode",
                table: "Invoice",
                type: "nvarchar(8)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

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
    }
}
