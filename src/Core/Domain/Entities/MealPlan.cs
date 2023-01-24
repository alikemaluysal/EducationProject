using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class MealPlan : Entity
{

    public Guid? StudentId { get; set; }

    public string Type { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Student? Student { get; set; }
}
