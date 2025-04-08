using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern.Observer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_welcomeMessages",
                table: "welcomeMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userProcesses",
                table: "userProcesses");

            migrationBuilder.RenameTable(
                name: "welcomeMessages",
                newName: "WelcomeMessages");

            migrationBuilder.RenameTable(
                name: "userProcesses",
                newName: "UserProcesses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WelcomeMessages",
                table: "WelcomeMessages",
                column: "WelcomeMessageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProcesses",
                table: "UserProcesses",
                column: "UserProcessID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WelcomeMessages",
                table: "WelcomeMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProcesses",
                table: "UserProcesses");

            migrationBuilder.RenameTable(
                name: "WelcomeMessages",
                newName: "welcomeMessages");

            migrationBuilder.RenameTable(
                name: "UserProcesses",
                newName: "userProcesses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_welcomeMessages",
                table: "welcomeMessages",
                column: "WelcomeMessageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userProcesses",
                table: "userProcesses",
                column: "UserProcessID");
        }
    }
}
