using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }




        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teaches> Teaches { get; set; }
        public DbSet<Takes> Takes { get; set; }
    }

    

}
