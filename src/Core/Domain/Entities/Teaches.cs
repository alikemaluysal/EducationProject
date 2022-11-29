namespace Domain.Entities
{
    public class Teaches
    {
        public Guid CourseId { get; set; }
        public virtual Course Course { get; set; }

        public Guid InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public DateTime TeachingYear { get; set; }
        //eğitim yılı
    }
}
