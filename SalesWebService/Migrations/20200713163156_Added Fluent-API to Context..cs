using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebService.Migrations
{
    public partial class AddedFluentAPItoContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Product_Code",
                table: "Product",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_Code",
                table: "Product");
        }
    }
}
