using Microsoft.EntityFrameworkCore.Migrations;

namespace PHotoFockus.Migrations
{
    public partial class FockusCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FockusCartItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<int>(type: "int", nullable: false),
                    productid = table.Column<int>(type: "int", nullable: true),
                    FockusCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FockusCartItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_FockusCartItem_Product_productid",
                        column: x => x.productid,
                        principalTable: "Product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FockusCartItem_productid",
                table: "FockusCartItem",
                column: "productid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FockusCartItem");
        }
    }
}
