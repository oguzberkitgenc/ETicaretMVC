using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_yenidatalar2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
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
                    Adres = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    PostaCode = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HomePagess",
                columns: table => new
                {
                    HomPageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomPageSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerLeft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerRight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerLeftDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerCenterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerRightDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftPageBreak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterPageBreak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightPageBreak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftPageBreakDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterPageBreakDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightPageBreakDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageBreakTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageBreakTitleDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BottomGreenTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BottomGreenBox = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
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
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "HomePagess");

            migrationBuilder.DropTable(
                name: "SocialMedias");
        }
    }
}
