using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    public partial class Reminder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminder");

            migrationBuilder.CreateTable(
                name: "Reminder1",
                columns: table => new
                {
                    SL_no = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Case_Id = table.Column<string>(nullable: false),
                    Rdate = table.Column<DateTime>(nullable: false),
                    rms = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder1", x => x.SL_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminder1");

            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    SL_no = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Case_Id = table.Column<string>(nullable: false),
                    Rdate = table.Column<DateTime>(nullable: false),
                    rms = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.SL_no);
                });
        }
    }
}
