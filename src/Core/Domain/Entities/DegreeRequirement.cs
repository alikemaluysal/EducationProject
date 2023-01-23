using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DegreeRequirement
{
    public int Id { get; set; }

    public int? Degree { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Degree? DegreeNavigation { get; set; }
}
