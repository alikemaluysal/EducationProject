namespace Domain.Entities
{
    public class Student
    {
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }

        public ICollection<Grade> ExamGrades { get; set; }
        //note entity
        public ICollection<Course> Courses { get; set; }

    }
}