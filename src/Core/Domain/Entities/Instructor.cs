namespace Domain.Entities
{
    public class Instructor : Person
    {
        public ICollection<Course> Courses { get; set; }

    }
}
