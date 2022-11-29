namespace Domain.Entities
{
    public class Student 
    {
        public int StudentNo {get; set;}
       public string Name {get; set;}
       public string Address {get; set;}
       public string Mobile

       public string ParentName {get; set;}
       //parent entity
        public ICollection<string> ExamGrades {get; set;}
         //note entity
      
    }
}