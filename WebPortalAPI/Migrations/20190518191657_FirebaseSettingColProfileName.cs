using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class FirebaseSettingColProfileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileName",
                table: "FirebaseSettings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileName",
                table: "FirebaseSettings");
        }
    }
}
