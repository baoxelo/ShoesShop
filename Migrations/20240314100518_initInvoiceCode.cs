using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class initInvoiceCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Invoice",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Invoice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Invoice",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceCode",
                table: "Invoice",
                type: "nvarchar(8)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceCode",
                table: "Invoice");

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Invoice",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Invoice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Invoice",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

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
    }
}
