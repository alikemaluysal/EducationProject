using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MealPlan
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public string Type { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Student? Student { get; set; }
}
