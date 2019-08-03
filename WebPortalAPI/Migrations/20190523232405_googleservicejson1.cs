using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class googleservicejson1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "GoogleServicesFileURL",
                table: "FirebaseSettings",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GoogleServicesFileURL",
                table: "FirebaseSettings",
                nullable: true,
                oldClrType: typeof(long));
        }
    }
}
