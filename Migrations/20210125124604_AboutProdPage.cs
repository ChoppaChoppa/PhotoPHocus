using Microsoft.EntityFrameworkCore.Migrations;

namespace PHotoFockus.Migrations
{
    public partial class AboutProdPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "AboutProdPage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutProdPage", x => x.id);
                    table.ForeignKey(
                        name: "FK_AboutProdPage_Product_productid",
                        column: x => x.productid,
                        principalTable: "Product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutProdPage_productid",
                table: "AboutProdPage",
                column: "productid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
