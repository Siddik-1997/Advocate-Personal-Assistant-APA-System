using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    public partial class CaseProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseProfiles",
                columns: table => new
                {
                    Case_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseName = table.Column<string>(nullable: false),
                    ClientName = table.Column<string>(nullable: false),
                    Plaintiff = table.Column<string>(nullable: false),
                    Defendant = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Fee = table.Column<string>(nullable: false),
                    Idate = table.Column<string>(nullable: false),
                    Hdate = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseProfiles", x => x.Case_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseProfiles");
        }
    }
}
