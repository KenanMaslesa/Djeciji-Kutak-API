using Microsoft.EntityFrameworkCore.Migrations;

namespace DjecijiKutakAPI.Migrations
{
    public partial class DeletedColumnPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0ef3dad1-bdd3-4685-8a20-4aedb4d7ad15");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b0e6d1c3-79ac-47d9-af17-4c841fa62c40");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e0c8d850-0f40-4357-a93d-3bd77a162611");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fb78f6ad-69a3-460b-a5e1-fce00fd99b80");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1594aeab-29a9-48d3-b3ab-f6dad54cd6d1", "58fdd353-e4f8-4a7c-a982-74a424349286", "User", "USER" },
                    { "9e489ef1-c066-406f-9d82-8ed449bc8dd5", "8740556c-80fd-4de1-870d-05008e11cf1d", "Administrator", "ADMINISTRATOR" },
                    { "9bd12834-ab68-466e-bf6d-ead97fe2fd3e", "8b4be938-5bfd-4398-b10f-b86087cd81bc", "User", "USER" },
                    { "fab067fc-dcd3-4a2c-9792-0fa0d3c2fd66", "54febad6-5efa-477a-a82e-ce276c54267d", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1594aeab-29a9-48d3-b3ab-f6dad54cd6d1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9bd12834-ab68-466e-bf6d-ead97fe2fd3e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e489ef1-c066-406f-9d82-8ed449bc8dd5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fab067fc-dcd3-4a2c-9792-0fa0d3c2fd66");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ef3dad1-bdd3-4685-8a20-4aedb4d7ad15", "7fd42103-c6bc-4355-ae2a-1c2a651fa596", "User", "USER" },
                    { "e0c8d850-0f40-4357-a93d-3bd77a162611", "aef6fffc-81e0-49b9-a806-6282d5f6625f", "Administrator", "ADMINISTRATOR" },
                    { "fb78f6ad-69a3-460b-a5e1-fce00fd99b80", "e262314b-59c4-4e41-9467-0b58e057e220", "User", "USER" },
                    { "b0e6d1c3-79ac-47d9-af17-4c841fa62c40", "27f7f769-f9a0-4b71-b63c-3b5ba2a47f84", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
