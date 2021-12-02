using Microsoft.EntityFrameworkCore.Migrations;

namespace PHotoFockus.Migrations
{
    public partial class AboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUsText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUsText_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUsText_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUsText_4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");
        }
    }
}
