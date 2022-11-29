using Domain.Base;

namespace Domain.Entities
{
    public class Grade : Entity
    {
        public int NumericGrade { get; set; }
        public string LetterGrade { get; set; }
        //enum?
        public virtual Course Course { get; set; }
        //public Exam Exam { get; set; }

    }
}
