using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    public partial class pm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rtime",
                table: "Reminder");

            migrationBuilder.DropColumn(
                name: "Mtime",
                table: "Message");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Rdate",
                table: "Reminder",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Mdate",
                table: "Message",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Idate",
                table: "CaseProfiles",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Hdate",
                table: "CaseProfiles",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rdate",
                table: "Reminder",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "Rtime",
                table: "Reminder",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Mdate",
                table: "Message",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "Mtime",
                table: "Message",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Idate",
                table: "CaseProfiles",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Hdate",
                table: "CaseProfiles",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
