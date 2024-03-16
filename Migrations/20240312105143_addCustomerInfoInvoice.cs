using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class addCustomerInfoInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Invoice",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Invoice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2384), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2465), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2916), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2923), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2926), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2929), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2930), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2932), new DateTime(2024, 3, 12, 17, 51, 42, 605, DateTimeKind.Local).AddTicks(2933) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Invoice");

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
        }
    }
}
