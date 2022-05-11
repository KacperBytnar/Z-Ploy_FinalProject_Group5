using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_ZPloy.Migrations
{
    public partial class zploy4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ActiveTasks_BoardOfTasksID",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "ActiveTasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_BoardOfTasksID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "BoardOfTasksID",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "picture",
                table: "Users",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Users",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "PictureName",
                table: "Tasks",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Users",
                newName: "picture");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Users",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Tasks",
                newName: "PictureName");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BoardOfTasksID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActiveTasks",
                columns: table => new
                {
                    BoardOfTasksID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveTasks", x => x.BoardOfTasksID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardOfTasksID",
                table: "Tasks",
                column: "BoardOfTasksID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ActiveTasks_BoardOfTasksID",
                table: "Tasks",
                column: "BoardOfTasksID",
                principalTable: "ActiveTasks",
                principalColumn: "BoardOfTasksID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
