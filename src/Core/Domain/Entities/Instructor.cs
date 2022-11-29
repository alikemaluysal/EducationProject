namespace Domain.Entities
{
    public class Instructor
    {
        public ICollection<Course> Courses { get; set; }
    }
}
