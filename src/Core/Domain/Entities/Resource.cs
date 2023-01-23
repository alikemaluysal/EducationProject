using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Resource
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public string Name { get; set; } = null!;

    public string Link { get; set; } = null!;

    public virtual Course? Course { get; set; }
}
