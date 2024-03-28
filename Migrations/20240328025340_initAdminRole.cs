using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class initAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "af7aa298-3dcf-44b9-8335-d3dcb2152554");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f38afb95-c923-48fe-a01f-036d58a02c2c");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8333), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8589), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8593), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8603), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8607), new DateTime(2024, 3, 28, 9, 53, 39, 569, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dcf0c365-c4e3-48ff-8788-41ebf5f6177a", null, "User", "USER" },
                    { "e0e07852-fb58-4ad3-99a1-1a1dfbb17db3", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73ff4cb6-4cf1-4f3d-a9d4-47a0b54d841c", 0, null, "https://firebasestorage.googleapis.com/v0/b/shoesshop-88775.appspot.com/o/images%2Fuseravatar.jpg?alt=media&token=dd433b00-2f14-41d5-a239-ff2421b0ede6", null, "962e3cd8-7dde-42a2-aba6-6fd93539fc68", "vuqcbao@gmail.com", true, "Vũ Quốc Bảo", false, null, null, null, "AQAAAAIAAYagAAAAECOBsOHr3V+vGaxtZChsMLwPfb0KFBsAlo7Ag3y3BJgl1jOIyb7P0FsW5+BB3ISlHQ==", "0798991358", false, "97af2f28-8c34-487b-a33e-1de16d3e219c", false, "vuqcbao@gmail.com" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e0e07852-fb58-4ad3-99a1-1a1dfbb17db3", "73ff4cb6-4cf1-4f3d-a9d4-47a0b54d841c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dcf0c365-c4e3-48ff-8788-41ebf5f6177a");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0e07852-fb58-4ad3-99a1-1a1dfbb17db3", "73ff4cb6-4cf1-4f3d-a9d4-47a0b54d841c" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e0e07852-fb58-4ad3-99a1-1a1dfbb17db3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "73ff4cb6-4cf1-4f3d-a9d4-47a0b54d841c");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5169), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5175), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5182), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5183), new DateTime(2024, 3, 28, 8, 57, 35, 420, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af7aa298-3dcf-44b9-8335-d3dcb2152554", null, "User", "USER" },
                    { "f38afb95-c923-48fe-a01f-036d58a02c2c", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
