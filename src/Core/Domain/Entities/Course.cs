using Domain.Base;

namespace Domain.Entities
{
    public class Course : Entity
    {
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
