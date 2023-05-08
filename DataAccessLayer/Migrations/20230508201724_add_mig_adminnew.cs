using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_mig_adminnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    YoutubeUrl = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    GMail = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Hotmail = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Payment = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    SaleNow = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Support = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    News = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    SubMainTitle = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    SubMainDescription = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
