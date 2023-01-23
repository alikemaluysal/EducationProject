using Domain.Base;

namespace Domain.Entities;

public partial class DegreeRequirement : Entity
{

    public Guid? DegreeId { get; set; }

    public Guid? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Degree? DegreeNavigation { get; set; }
}
