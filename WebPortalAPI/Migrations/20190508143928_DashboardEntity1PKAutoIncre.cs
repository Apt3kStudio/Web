using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPortalAPI.Migrations
{
    public partial class DashboardEntity1PKAutoIncre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Dashboards",
               columns: table => new
               {
                   ID = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   Header = table.Column<string>(nullable: true),
                   Body = table.Column<string>(nullable: true),
                
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Dashboards", x => x.ID);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Dashboards");
        }
    }
}
