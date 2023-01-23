using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ClubMembership
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? ClubId { get; set; }

    public virtual Club? Club { get; set; }

    public virtual Student? Student { get; set; }
}
