using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_yenidatalar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(25)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Adres = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PostaCode = table.Column<string>(type: "nvarchar(25)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    InstagramUrl = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    YoutubeUrl = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NullUrl = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "SocialMedia");
        }
    }
}
