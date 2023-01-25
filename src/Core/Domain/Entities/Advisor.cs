using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class Advisor : Entity
{

    public Guid? StudentId { get; set; }

    public Guid? TeacherId { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
