using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__3213E83F120E63C0", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    starttime = table.Column<TimeSpan>(name: "start_time", type: "time", nullable: false),
                    endtime = table.Column<TimeSpan>(name: "end_time", type: "time", nullable: false),
                    location = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Events__3213E83F7515042C", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    department = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Degrees__3213E83FBCAAF6D5", x => x.id);
                    table.ForeignKey(
                        name: "FK__Degrees__departm__49C3F6B7",
                        column: x => x.department,
                        principalTable: "Departments",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    firstname = table.Column<string>(name: "first_name", type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    phone = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    department = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Teachers__3213E83FF2FBF0BC", x => x.id);
                    table.ForeignKey(
                        name: "FK__Teachers__depart__5070F446",
                        column: x => x.department,
                        principalTable: "Departments",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    firstname = table.Column<string>(name: "first_name", type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    phone = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    major = table.Column<int>(type: "int", nullable: true),
                    degree = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Students__3213E83FDE006724", x => x.id);
                    table.ForeignKey(
                        name: "FK__Students__degree__4D94879B",
                        column: x => x.degree,
                        principalTable: "Degrees",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Students__major__4CA06362",
                        column: x => x.major,
                        principalTable: "Departments",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    instructor = table.Column<int>(type: "int", nullable: true),
                    credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Courses__3213E83FDF56B220", x => x.id);
                    table.ForeignKey(
                        name: "FK__Courses__instruc__534D60F1",
                        column: x => x.instructor,
                        principalTable: "Teachers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Advisors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    teacherid = table.Column<int>(name: "teacher_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Advisors__3213E83F77C186F2", x => x.id);
                    table.ForeignKey(
                        name: "FK__Advisors__studen__619B8048",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Advisors__teache__628FA481",
                        column: x => x.teacherid,
                        principalTable: "Teachers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    president = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clubs__3213E83F21050034", x => x.id);
                    table.ForeignKey(
                        name: "FK__Clubs__president__74AE54BC",
                        column: x => x.president,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "FinancialAid",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    startdate = table.Column<DateTime>(name: "start_date", type: "date", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Financia__3213E83F13765A52", x => x.id);
                    table.ForeignKey(
                        name: "FK__Financial__stude__7B5B524B",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Housing",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    roomnumber = table.Column<int>(name: "room_number", type: "int", nullable: false),
                    startdate = table.Column<DateTime>(name: "start_date", type: "date", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Housing__3213E83F27BE2FF5", x => x.id);
                    table.ForeignKey(
                        name: "FK__Housing__student__7E37BEF6",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    startdate = table.Column<DateTime>(name: "start_date", type: "date", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MealPlan__3213E83FC5E9C8A1", x => x.id);
                    table.ForeignKey(
                        name: "FK__MealPlans__stude__01142BA1",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(name: "course_id", type: "int", nullable: true),
                    teacherid = table.Column<int>(name: "teacher_id", type: "int", nullable: true),
                    title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    message = table.Column<string>(type: "text", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Announce__3213E83FD8876D20", x => x.id);
                    table.ForeignKey(
                        name: "FK__Announcem__cours__6C190EBB",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Announcem__teach__6D0D32F4",
                        column: x => x.teacherid,
                        principalTable: "Teachers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BookstoreInventory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(name: "course_id", type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    author = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    publisher = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bookstor__3213E83F2421312E", x => x.id);
                    table.ForeignKey(
                        name: "FK__Bookstore__cours__07C12930",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BookstoreOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    courseid = table.Column<int>(name: "course_id", type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bookstor__3213E83FFDA1D140", x => x.id);
                    table.ForeignKey(
                        name: "FK__Bookstore__cours__04E4BC85",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Bookstore__stude__03F0984C",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(name: "course_id", type: "int", nullable: true),
                    semester = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Classes__3213E83F45FA4B57", x => x.id);
                    table.ForeignKey(
                        name: "FK__Classes__course___5629CD9C",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DegreeRequirements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    degree = table.Column<int>(type: "int", nullable: true),
                    courseid = table.Column<int>(name: "course_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DegreeRe__3213E83FFE8D7CC4", x => x.id);
                    table.ForeignKey(
                        name: "FK__DegreeReq__cours__5EBF139D",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__DegreeReq__degre__5DCAEF64",
                        column: x => x.degree,
                        principalTable: "Degrees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(name: "course_id", type: "int", nullable: true),
                    type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    starttime = table.Column<TimeSpan>(name: "start_time", type: "time", nullable: false),
                    endtime = table.Column<TimeSpan>(name: "end_time", type: "time", nullable: false),
                    location = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Exams__3213E83FE69A249A", x => x.id);
                    table.ForeignKey(
                        name: "FK__Exams__course_id__656C112C",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(name: "course_id", type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    link = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Resource__3213E83F70704A29", x => x.id);
                    table.ForeignKey(
                        name: "FK__Resources__cours__6FE99F9F",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ClubMembership",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    clubid = table.Column<int>(name: "club_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClubMemb__3213E83FC31F831E", x => x.id);
                    table.ForeignKey(
                        name: "FK__ClubMembe__club___787EE5A0",
                        column: x => x.clubid,
                        principalTable: "Clubs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__ClubMembe__stude__778AC167",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    classid = table.Column<int>(name: "class_id", type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    present = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Attendan__3213E83FC5730306", x => x.id);
                    table.ForeignKey(
                        name: "FK__Attendanc__class__59FA5E80",
                        column: x => x.classid,
                        principalTable: "Classes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Attendanc__stude__59063A47",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ExamScores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(name: "student_id", type: "int", nullable: true),
                    examid = table.Column<int>(name: "exam_id", type: "int", nullable: true),
                    score = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ExamScor__3213E83FCDD13984", x => x.id);
                    table.ForeignKey(
                        name: "FK__ExamScore__exam___693CA210",
                        column: x => x.examid,
                        principalTable: "Exams",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__ExamScore__stude__68487DD7",
                        column: x => x.studentid,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advisors_student_id",
                table: "Advisors",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Advisors_teacher_id",
                table: "Advisors",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_course_id",
                table: "Announcements",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_teacher_id",
                table: "Announcements",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_class_id",
                table: "Attendance",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_student_id",
                table: "Attendance",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_BookstoreInventory_course_id",
                table: "BookstoreInventory",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_BookstoreOrders_course_id",
                table: "BookstoreOrders",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_BookstoreOrders_student_id",
                table: "BookstoreOrders",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_course_id",
                table: "Classes",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMembership_club_id",
                table: "ClubMembership",
                column: "club_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMembership_student_id",
                table: "ClubMembership",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_president",
                table: "Clubs",
                column: "president");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_instructor",
                table: "Courses",
                column: "instructor");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeRequirements_course_id",
                table: "DegreeRequirements",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeRequirements_degree",
                table: "DegreeRequirements",
                column: "degree");

            migrationBuilder.CreateIndex(
                name: "IX_Degrees_department",
                table: "Degrees",
                column: "department");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_course_id",
                table: "Exams",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScores_exam_id",
                table: "ExamScores",
                column: "exam_id");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScores_student_id",
                table: "ExamScores",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAid_student_id",
                table: "FinancialAid",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Housing_student_id",
                table: "Housing",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlans_student_id",
                table: "MealPlans",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_course_id",
                table: "Resources",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_degree",
                table: "Students",
                column: "degree");

            migrationBuilder.CreateIndex(
                name: "IX_Students_major",
                table: "Students",
                column: "major");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_department",
                table: "Teachers",
                column: "department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advisors");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "BookstoreInventory");

            migrationBuilder.DropTable(
                name: "BookstoreOrders");

            migrationBuilder.DropTable(
                name: "ClubMembership");

            migrationBuilder.DropTable(
                name: "DegreeRequirements");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ExamScores");

            migrationBuilder.DropTable(
                name: "FinancialAid");

            migrationBuilder.DropTable(
                name: "Housing");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
