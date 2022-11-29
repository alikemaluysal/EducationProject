namespace Domain.Entities
{
    public class Student : Person
    {
        public int StudentNo { get; set; }
        public ICollection<Grade> ExamGrades { get; set; }
        public ICollection<Course> Courses { get; set; }


        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}