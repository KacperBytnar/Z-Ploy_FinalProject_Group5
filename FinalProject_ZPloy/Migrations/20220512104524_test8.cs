using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_ZPloy.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_PerformerID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_PerformerID",
                table: "Tasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatorID",
                table: "Tasks",
                column: "CreatorID");

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

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CreatorID",
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
    }
}
