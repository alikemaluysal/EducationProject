using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Advisor
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? TeacherId { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
