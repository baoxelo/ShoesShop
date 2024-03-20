using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class updateRoleName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "095afcf6-8c85-46b7-9d62-2b3089b38e2e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3d997677-2e1f-4ffd-bac9-960fa52120af");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(293), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(349), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(548), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(553), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(555), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 3, 17, 23, 18, 27, 994, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eb377ca3-7165-46fc-a878-e72dd1d848fc", null, "administrator", "ADMINISTRATOR" },
                    { "f09d5138-7db9-4cba-aac0-73f72d415b01", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "eb377ca3-7165-46fc-a878-e72dd1d848fc");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f09d5138-7db9-4cba-aac0-73f72d415b01");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
