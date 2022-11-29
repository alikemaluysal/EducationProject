using Domain.Base;

namespace Domain.Entities
{
    public class Course : Entity
    {
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }

        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        //public ICollection<Student> Students { get; set; }
        //public ICollection<Instructor> Instructors { get; set; }

    }
}
