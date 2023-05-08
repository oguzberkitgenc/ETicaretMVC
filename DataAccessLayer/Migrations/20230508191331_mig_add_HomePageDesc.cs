using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_HomePageDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePageDesc",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Product1 = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Payment = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    SaleNow = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Support = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    News = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    SubMainTitle = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    SubMainDescription = table.Column<string>(type: "nvarchar(400)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePageDesc");
        }
    }
}
