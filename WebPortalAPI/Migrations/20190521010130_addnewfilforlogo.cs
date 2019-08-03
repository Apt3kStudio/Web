using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class addnewfilforlogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "logo",
                table: "LandingPages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "logo",
                table: "LandingPages");
        }
    }
}
