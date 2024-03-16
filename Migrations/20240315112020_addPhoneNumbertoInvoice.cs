using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class addPhoneNumbertoInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Invoice",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7363), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7365), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7367), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7369), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7371), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7372), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 3, 15, 18, 20, 19, 859, DateTimeKind.Local).AddTicks(7376) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Invoice");

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
    }
}
