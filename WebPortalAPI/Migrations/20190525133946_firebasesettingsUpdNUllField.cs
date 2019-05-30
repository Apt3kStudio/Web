using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class firebasesettingsUpdNUllField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "GoogleServicesSize",
                table: "FirebaseSettings",
                nullable: true,
                oldClrType: typeof(long));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "GoogleServicesSize",
                table: "FirebaseSettings",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
