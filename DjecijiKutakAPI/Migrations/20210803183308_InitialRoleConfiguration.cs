using Microsoft.EntityFrameworkCore.Migrations;

namespace DjecijiKutakAPI.Migrations
{
    public partial class InitialRoleConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6e828515-130c-4830-bbe2-fc9172002586");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9880b6a1-954a-4289-bc0c-994c7414764d");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d47b1ae8-3dca-4122-99f4-dfc5d51f8998", "3c639c92-8a87-47df-8f91-41fc5f8b4691", "User", "USER" },
                    { "4510ed21-3ec5-4951-9635-f195d83a72d2", "b7f12995-dacd-4442-b426-06f3104da1d9", "Administrator", "ADMINISTRATOR" },
                    { "707f7c12-1f63-4d1b-a4d0-8538318ed9fb", "4cc74e4b-c5d6-4220-8937-e5ba7e6a40a0", "User", "USER" },
                    { "6f0e42ef-2469-4e5c-b09f-9926c683a845", "9110abfd-bbe3-40de-81a3-d9c5e59597bd", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4510ed21-3ec5-4951-9635-f195d83a72d2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6f0e42ef-2469-4e5c-b09f-9926c683a845");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "707f7c12-1f63-4d1b-a4d0-8538318ed9fb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d47b1ae8-3dca-4122-99f4-dfc5d51f8998");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9880b6a1-954a-4289-bc0c-994c7414764d", "e4b6d54a-8025-4ae2-ba0b-40e81e5ee4b0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e828515-130c-4830-bbe2-fc9172002586", "8a004381-7869-4e71-9e5a-346f7c4fa364", "Administrator", "ADMINISTRATOR" });
        }
    }
}
