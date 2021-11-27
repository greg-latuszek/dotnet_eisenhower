using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcEisenhower.Data.Migrations
{
    public partial class RenameIdToTeamID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Task",
                newName: "TaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskID",
                table: "Task",
                newName: "Id");
        }
    }
}
