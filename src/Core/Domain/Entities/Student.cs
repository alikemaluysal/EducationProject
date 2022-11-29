namespace Domain.Entities
{
    public class Student
    {
        //public Department Department { get; set; }
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<string> ExamGrades { get; set; }
        //grade entity

    }
}