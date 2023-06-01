using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_basket_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Baskets");

            migrationBuilder.AddColumn<int>(
                name: "Piece",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Sales",
                table: "Baskets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Piece",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Sales",
                table: "Baskets");

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
