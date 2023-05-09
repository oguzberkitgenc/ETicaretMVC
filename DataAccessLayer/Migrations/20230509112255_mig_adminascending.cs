using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_adminascending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(125)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(125)", nullable: true),
                    YoutubeUrl = table.Column<string>(type: "nvarchar(125)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(125)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(125)", nullable: true),
                    NullUrl = table.Column<string>(type: "nvarchar(125)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    PostaCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    HomPageTitle = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    HomPageSubTitle = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LowerLeft = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LowerCenter = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LowerRight = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LowerLeftDesc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LowerCenterDesc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LowerRightDesc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LeftPageBreak = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CenterPageBreak = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    RightPageBreak = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    LeftPageBreakDesc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CenterPageBreakDesc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    RightPageBreakDesc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PageBreakTitle = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PageBreakTitleDesc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    BottomGreenTitle = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    BottomGreenBox = table.Column<string>(type: "nvarchar(25)", nullable: true)
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
