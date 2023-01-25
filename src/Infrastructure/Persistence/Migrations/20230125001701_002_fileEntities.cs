using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _002fileEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "department",
                table: "Degrees",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Degrees_department",
                table: "Degrees",
                newName: "IX_Degrees_departmentId");

            migrationBuilder.RenameColumn(
                name: "instructor",
                table: "Courses",
                newName: "instructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_instructor",
                table: "Courses",
                newName: "IX_Courses_instructorId");

            migrationBuilder.RenameColumn(
                name: "president",
                table: "Clubs",
                newName: "presidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_president",
                table: "Clubs",
                newName: "IX_Clubs_presidentId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ProfilePictureId",
                table: "Teachers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Teachers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ProfilePictureId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Resources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Resources",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MealPlans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "MealPlans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Housing",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Housing",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "FinancialAid",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "FinancialAid",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ExamScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ExamScores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Exams",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Events",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Degrees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Degrees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DegreeRequirements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "DegreeRequirements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Courses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Clubs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Clubs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ClubMembership",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ClubMembership",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Classes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Classes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BookstoreOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "BookstoreOrders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BookstoreInventory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "BookstoreInventory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Attendance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Attendance",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Announcements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Advisors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Advisors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProfilePicture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePicture", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ProfilePictureId",
                table: "Teachers",
                column: "ProfilePictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProfilePictureId",
                table: "Students",
                column: "ProfilePictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ProfilePicture_ProfilePictureId",
                table: "Students",
                column: "ProfilePictureId",
                principalTable: "ProfilePicture",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_ProfilePicture_ProfilePictureId",
                table: "Teachers",
                column: "ProfilePictureId",
                principalTable: "ProfilePicture",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_ProfilePicture_ProfilePictureId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_ProfilePicture_ProfilePictureId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "ProfilePicture");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ProfilePictureId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_ProfilePictureId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ProfilePictureId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ProfilePictureId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Housing");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Housing");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "FinancialAid");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "FinancialAid");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ExamScores");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ExamScores");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Degrees");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Degrees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DegreeRequirements");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DegreeRequirements");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ClubMembership");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ClubMembership");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BookstoreOrders");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "BookstoreOrders");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BookstoreInventory");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "BookstoreInventory");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Advisors");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Degrees",
                newName: "department");

            migrationBuilder.RenameIndex(
                name: "IX_Degrees_departmentId",
                table: "Degrees",
                newName: "IX_Degrees_department");

            migrationBuilder.RenameColumn(
                name: "instructorId",
                table: "Courses",
                newName: "instructor");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_instructorId",
                table: "Courses",
                newName: "IX_Courses_instructor");

            migrationBuilder.RenameColumn(
                name: "presidentId",
                table: "Clubs",
                newName: "president");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_presidentId",
                table: "Clubs",
                newName: "IX_Clubs_president");
        }
    }
}
