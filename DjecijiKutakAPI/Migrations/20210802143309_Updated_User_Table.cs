using Microsoft.EntityFrameworkCore.Migrations;

namespace DjecijiKutakAPI.Migrations
{
    public partial class Updated_User_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IframeUrl",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IframeUrl",
                table: "Videos");
        }
    }
}
