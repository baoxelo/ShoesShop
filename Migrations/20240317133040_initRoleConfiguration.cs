using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class initRoleConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9532), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9961), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9963), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 3, 17, 20, 30, 39, 414, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "095afcf6-8c85-46b7-9d62-2b3089b38e2e", null, "Administrator", "ADMINISTRATOR" },
                    { "3d997677-2e1f-4ffd-bac9-960fa52120af", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "095afcf6-8c85-46b7-9d62-2b3089b38e2e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3d997677-2e1f-4ffd-bac9-960fa52120af");

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
    }
}
