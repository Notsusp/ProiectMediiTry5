using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiTry5.Migrations
{
    /// <inheritdoc />
    public partial class PJ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "Job",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Job_ProjectID",
                table: "Job",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Project_ProjectID",
                table: "Job",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Project_ProjectID",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_ProjectID",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "Job");
        }
    }
}
