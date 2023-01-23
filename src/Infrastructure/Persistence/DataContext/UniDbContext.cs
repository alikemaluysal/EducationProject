using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataContext;

public partial class UniDbContext : DbContext
{
    public UniDbContext()
    {
    }

    public UniDbContext(DbContextOptions<UniDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Advisor> Advisors { get; set; }

    public virtual DbSet<Announcement> Announcements { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<BookstoreInventory> BookstoreInventories { get; set; }

    public virtual DbSet<BookstoreOrder> BookstoreOrders { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<ClubMembership> ClubMemberships { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Degree> Degrees { get; set; }

    public virtual DbSet<DegreeRequirement> DegreeRequirements { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<ExamScore> ExamScores { get; set; }

    public virtual DbSet<FinancialAid> FinancialAids { get; set; }

    public virtual DbSet<Housing> Housings { get; set; }

    public virtual DbSet<MealPlan> MealPlans { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=UniDB;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Advisor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Advisors__3213E83F77C186F2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

            entity.HasOne(d => d.Student).WithMany(p => p.Advisors)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Advisors__studen__619B8048");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Advisors)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK__Advisors__teache__628FA481");
        });

        modelBuilder.Entity<Announcement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Announce__3213E83FD8876D20");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.Course).WithMany(p => p.Announcements)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Announcem__cours__6C190EBB");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Announcements)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK__Announcem__teach__6D0D32F4");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Attendan__3213E83FC5730306");

            entity.ToTable("Attendance");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Present).HasColumnName("present");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Class).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__Attendanc__class__59FA5E80");

            entity.HasOne(d => d.Student).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Attendanc__stude__59063A47");
        });

        modelBuilder.Entity<BookstoreInventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bookstor__3213E83F2421312E");

            entity.ToTable("BookstoreInventory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Publisher)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("publisher");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Course).WithMany(p => p.BookstoreInventories)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Bookstore__cours__07C12930");
        });

        modelBuilder.Entity<BookstoreOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bookstor__3213E83FFDA1D140");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("total");

            entity.HasOne(d => d.Course).WithMany(p => p.BookstoreOrders)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Bookstore__cours__04E4BC85");

            entity.HasOne(d => d.Student).WithMany(p => p.BookstoreOrders)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Bookstore__stude__03F0984C");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Classes__3213E83F45FA4B57");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Semester)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("semester");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Course).WithMany(p => p.Classes)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Classes__course___5629CD9C");
        });

        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clubs__3213E83F21050034");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PresidentId).HasColumnName("president");

            entity.HasOne(d => d.PresidentNavigation).WithMany(p => p.Clubs)
                .HasForeignKey(d => d.PresidentId)
                .HasConstraintName("FK__Clubs__president__74AE54BC");
        });

        modelBuilder.Entity<ClubMembership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClubMemb__3213E83FC31F831E");

            entity.ToTable("ClubMembership");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClubId).HasColumnName("club_id");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Club).WithMany(p => p.ClubMemberships)
                .HasForeignKey(d => d.ClubId)
                .HasConstraintName("FK__ClubMembe__club___787EE5A0");

            entity.HasOne(d => d.Student).WithMany(p => p.ClubMemberships)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__ClubMembe__stude__778AC167");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Courses__3213E83FDF56B220");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Credits).HasColumnName("credits");
            entity.Property(e => e.InstructorId).HasColumnName("instructor");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.InstructorNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.InstructorId)
                .HasConstraintName("FK__Courses__instruc__534D60F1");
        });

        modelBuilder.Entity<Degree>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Degrees__3213E83FBCAAF6D5");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DepartmentId).HasColumnName("department");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.Degrees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Degrees__departm__49C3F6B7");
        });

        modelBuilder.Entity<DegreeRequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DegreeRe__3213E83FFE8D7CC4");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.DegreeId).HasColumnName("degree");

            entity.HasOne(d => d.Course).WithMany(p => p.DegreeRequirements)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__DegreeReq__cours__5EBF139D");

            entity.HasOne(d => d.DegreeNavigation).WithMany(p => p.DegreeRequirements)
                .HasForeignKey(d => d.DegreeId)
                .HasConstraintName("FK__DegreeReq__degre__5DCAEF64");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3213E83F120E63C0");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Events__3213E83F7515042C");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Exams__3213E83FE69A249A");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Exams__course_id__656C112C");
        });

        modelBuilder.Entity<ExamScore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExamScor__3213E83FCDD13984");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ExamId).HasColumnName("exam_id");
            entity.Property(e => e.Score)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("score");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Exam).WithMany(p => p.ExamScores)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK__ExamScore__exam___693CA210");

            entity.HasOne(d => d.Student).WithMany(p => p.ExamScores)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__ExamScore__stude__68487DD7");
        });

        modelBuilder.Entity<FinancialAid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Financia__3213E83F13765A52");

            entity.ToTable("FinancialAid");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("end_date");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.Student).WithMany(p => p.FinancialAids)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Financial__stude__7B5B524B");
        });

        modelBuilder.Entity<Housing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Housing__3213E83F27BE2FF5");

            entity.ToTable("Housing");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("end_date");
            entity.Property(e => e.RoomNumber).HasColumnName("room_number");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.Student).WithMany(p => p.Housings)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Housing__student__7E37BEF6");
        });

        modelBuilder.Entity<MealPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MealPlan__3213E83FC5E9C8A1");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("end_date");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.Student).WithMany(p => p.MealPlans)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__MealPlans__stude__01142BA1");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Resource__3213E83F70704A29");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Course).WithMany(p => p.Resources)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Resources__cours__6FE99F9F");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3213E83FDE006724");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DegreeId).HasColumnName("degree");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MajorDepartmentId).HasColumnName("major");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");

            entity.HasOne(d => d.DegreeNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.DegreeId)
                .HasConstraintName("FK__Students__degree__4D94879B");

            entity.HasOne(d => d.MajorNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.MajorDepartmentId)
                .HasConstraintName("FK__Students__major__4CA06362");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teachers__3213E83FF2FBF0BC");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DepartmentId).HasColumnName("department");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Teachers__depart__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
