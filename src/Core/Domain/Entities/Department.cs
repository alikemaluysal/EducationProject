using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class Department : Entity
{

    public string Name { get; set; } = null!;

    public virtual ICollection<Degree> Degrees { get; } = new List<Degree>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; } = new List<Teacher>();
}
