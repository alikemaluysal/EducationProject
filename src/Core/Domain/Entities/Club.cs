using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Club
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? President { get; set; }

    public virtual ICollection<ClubMembership> ClubMemberships { get; } = new List<ClubMembership>();

    public virtual Student? PresidentNavigation { get; set; }
}
