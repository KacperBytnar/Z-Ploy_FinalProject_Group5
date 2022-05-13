using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_ZPloy.Migrations
{
    public partial class testt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserID",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Tasks",
                newName: "CreatorID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserID",
                table: "Tasks",
                newName: "IX_Tasks_CreatorID");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerformerID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_CreatorID",
                table: "Tasks",
                column: "CreatorID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_CreatorID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PerformerID",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "CreatorID",
                table: "Tasks",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_CreatorID",
                table: "Tasks",
                newName: "IX_Tasks_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserID",
                table: "Tasks",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
