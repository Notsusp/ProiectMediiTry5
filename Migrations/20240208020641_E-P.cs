using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiTry5.Migrations
{
    /// <inheritdoc />
    public partial class EP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Project",
                newName: "ProjectName");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Project",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Job",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ProjectID",
                table: "Employee",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Project_ProjectID",
                table: "Employee",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Project_ProjectID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ProjectID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "Project",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Project",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Job",
                newName: "Id");
        }
    }
}
