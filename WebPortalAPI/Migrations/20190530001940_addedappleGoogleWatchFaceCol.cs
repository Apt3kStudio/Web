using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class addedappleGoogleWatchFaceCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppleStore",
                table: "LandingPages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GooglePlay",
                table: "LandingPages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WatchFace",
                table: "LandingPages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppleStore",
                table: "LandingPages");

            migrationBuilder.DropColumn(
                name: "GooglePlay",
                table: "LandingPages");

            migrationBuilder.DropColumn(
                name: "WatchFace",
                table: "LandingPages");
        }
    }
}
