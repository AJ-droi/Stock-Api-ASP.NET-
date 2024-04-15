using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace web_api.Migrations
{
    /// <inheritdoc />
    public partial class claims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a38590e6-2ee8-4da5-bc4d-71e3b9cc1e25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d27707f6-9a44-4769-aef1-27158913d917");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0920f791-570d-4c71-803a-42ba6d5ee178", null, "User", "USER" },
                    { "19c85d2a-16c8-400d-bb44-fb1ec90520e8", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0920f791-570d-4c71-803a-42ba6d5ee178");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19c85d2a-16c8-400d-bb44-fb1ec90520e8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a38590e6-2ee8-4da5-bc4d-71e3b9cc1e25", null, "User", "USER" },
                    { "d27707f6-9a44-4769-aef1-27158913d917", null, "Admin", "ADMIN" }
                });
        }
    }
}
