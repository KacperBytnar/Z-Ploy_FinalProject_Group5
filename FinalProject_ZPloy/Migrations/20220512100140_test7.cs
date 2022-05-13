using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_ZPloy.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UserID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Tasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PerformerID",
                table: "Tasks",
                column: "PerformerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_PerformerID",
                table: "Tasks",
                column: "PerformerID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_PerformerID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_PerformerID",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserID",
                table: "Tasks",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserID",
                table: "Tasks",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
