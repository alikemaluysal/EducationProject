using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class Club : Entity
{

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? PresidentId { get; set; }

    public virtual ICollection<ClubMembership> ClubMemberships { get; } = new List<ClubMembership>();

    public virtual Student? PresidentNavigation { get; set; }
}
