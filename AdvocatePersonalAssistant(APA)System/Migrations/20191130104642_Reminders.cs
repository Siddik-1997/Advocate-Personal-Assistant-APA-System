using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    public partial class Reminders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    SL_no = table.Column<string>(nullable: false),
                    Case_Id = table.Column<string>(nullable: false),
                    Rdate = table.Column<string>(nullable: false),
                    Rtime = table.Column<string>(nullable: false),
                    rms = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.SL_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminder");
        }
    }
}
