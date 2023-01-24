using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class Resource : Entity
{

    public Guid? CourseId { get; set; }

    public string Name { get; set; } = null!;

    public string Link { get; set; } = null!;

    public virtual Course? Course { get; set; }
}
