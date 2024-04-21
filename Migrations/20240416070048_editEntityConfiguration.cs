using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoesShop.Migrations
{
    /// <inheritdoc />
    public partial class editEntityConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "207d53fc-fff4-4469-8cd2-f514167e7d79");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "34dc5329-a70a-463e-a239-a3aceddd6314");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1977), "Không giảm", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1978), "10%", 10 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1981), "Giảm 20%", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1982), "20%", 20 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1987), "Giảm 30%", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1988), "30%", 30 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1990), "Giảm 40%", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1991), "40%", 40 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1993), "Giảm 50%", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1994), "50%", 50 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1996), "Giảm 60%", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1997), "60%", 60 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2000), "Giảm 70%", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2001), "70%", 70 });

            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "CreateDate", "Description", "ModifyDate", "Name", "Percent", "Status" },
                values: new object[] { 9, new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2003), "Giảm 80%", new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2004), "80%", 80, "Hoạt động" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "262234fe-63dd-4f6b-9f2b-12ef2b120717", null, "Administrator", "ADMINISTRATOR" },
                    { "39f6c631-fb13-499c-9079-7cef9f9dcc4b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "262234fe-63dd-4f6b-9f2b-12ef2b120717");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "39f6c631-fb13-499c-9079-7cef9f9dcc4b");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8801), "Giảm 20%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8802), "20%", 20 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8803), "Giảm 30%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8804), "30%", 30 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8805), "Giảm 40%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8805), "40%", 40 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8806), "Giảm 50%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8807), "50%", 50 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8808), "Giảm 60%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8809), "60%", 60 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8810), "Giảm 70%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8810), "70%", 70 });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Description", "ModifyDate", "Name", "Percent" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8812), "Giảm 80%", new DateTime(2024, 4, 9, 15, 50, 26, 916, DateTimeKind.Local).AddTicks(8812), "80%", 80 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "207d53fc-fff4-4469-8cd2-f514167e7d79", null, "Administrator", "ADMINISTRATOR" },
                    { "34dc5329-a70a-463e-a239-a3aceddd6314", null, "User", "USER" }
                });
        }
    }
}
