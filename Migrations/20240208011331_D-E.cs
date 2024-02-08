using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiTry5.Migrations
{
    /// <inheritdoc />
    public partial class DE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Department",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentID",
                table: "Employee",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Department",
                newName: "DepartmentId");
        }
    }
}
