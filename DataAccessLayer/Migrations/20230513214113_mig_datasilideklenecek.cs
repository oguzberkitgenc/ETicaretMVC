using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_datasilideklenecek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostaCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomePagess",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BottomGreenBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BottomGreenTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterPageBreak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterPageBreakDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomPageSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomPageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftPageBreak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftPageBreakDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerCenterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerLeft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerLeftDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerRight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerRightDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageBreakTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageBreakTitleDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightPageBreak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightPageBreakDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePagess", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NullUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.ID);
                });
        }
    }
}
