using Domain.Base;

namespace Domain.Entities;

public partial class Degree : Entity
{

    public string Name { get; set; } = null!;

    public Guid? DepartmentId { get; set; }

    public virtual ICollection<DegreeRequirement> DegreeRequirements { get; } = new List<DegreeRequirement>();

    public virtual Department? DepartmentNavigation { get; set; }

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
