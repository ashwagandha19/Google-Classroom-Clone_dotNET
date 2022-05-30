using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagementSystem.Migrations
{
    public partial class updateddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Enrollments_EnrollmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Gradings_GradingId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_EnrollmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GradingId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EnrollmentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradingId",
                table: "Students");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "Gradings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EnrollmentStudent",
                columns: table => new
                {
                    EnrollmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrollmentStudent", x => new { x.EnrollmentsId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_EnrollmentStudent_Enrollments_EnrollmentsId",
                        column: x => x.EnrollmentsId,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnrollmentStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gradings_StudentId",
                table: "Gradings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_EnrollmentStudent_StudentsId",
                table: "EnrollmentStudent",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gradings_Students_StudentId",
                table: "Gradings",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gradings_Students_StudentId",
                table: "Gradings");

            migrationBuilder.DropTable(
                name: "EnrollmentStudent");

            migrationBuilder.DropIndex(
                name: "IX_Gradings_StudentId",
                table: "Gradings");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Gradings");

            migrationBuilder.AddColumn<Guid>(
                name: "EnrollmentId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GradingId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_EnrollmentId",
                table: "Students",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradingId",
                table: "Students",
                column: "GradingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Enrollments_EnrollmentId",
                table: "Students",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Gradings_GradingId",
                table: "Students",
                column: "GradingId",
                principalTable: "Gradings",
                principalColumn: "Id");
        }
    }
}
