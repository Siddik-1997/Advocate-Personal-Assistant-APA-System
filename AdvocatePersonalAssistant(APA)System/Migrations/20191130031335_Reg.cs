using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    public partial class Reg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsereName",
                table: "Registration",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Registration",
                newName: "UsereName");
        }
    }
}
