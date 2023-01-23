using Domain.Base;

namespace Domain.Entities;

public partial class Class : Entity
{

    public Guid? CourseId { get; set; }

    public string Semester { get; set; } = null!;

    public int Year { get; set; }

    public virtual ICollection<Attendance> Attendances { get; } = new List<Attendance>();

    public virtual Course? Course { get; set; }
}
