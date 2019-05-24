using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class googleservicejson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleServicesFileURL",
                table: "FirebaseSettings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleServicesFileURL",
                table: "FirebaseSettings");
        }
    }
}
