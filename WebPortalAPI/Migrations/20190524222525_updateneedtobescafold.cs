using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class updateneedtobescafold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GoogleServicesFileURL",
                table: "FirebaseSettings",
                newName: "GoogleServicesSize");

            migrationBuilder.AddColumn<string>(
                name: "GoogleServicesData",
                table: "FirebaseSettings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleServicesData",
                table: "FirebaseSettings");

            migrationBuilder.RenameColumn(
                name: "GoogleServicesSize",
                table: "FirebaseSettings",
                newName: "GoogleServicesFileURL");
        }
    }
}
