using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceApp.DataAccess.Migrations
{
    public partial class mig_entities_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantityPerUnit",
                table: "Products",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "QuantityPerUnit");
        }
    }
}
