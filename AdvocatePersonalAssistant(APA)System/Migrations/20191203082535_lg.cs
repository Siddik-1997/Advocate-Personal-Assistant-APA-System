using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    public partial class lg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Login",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "LId",
                table: "Login",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "LId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "LId",
                table: "Login");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Login",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "UserId");
        }
    }
}
