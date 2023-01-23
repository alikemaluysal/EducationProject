using Domain.Base;

namespace Domain.Entities;

public partial class ClubMembership : Entity
{

    public Guid? StudentId { get; set; }

    public Guid? ClubId { get; set; }

    public virtual Club? Club { get; set; }

    public virtual Student? Student { get; set; }
}
