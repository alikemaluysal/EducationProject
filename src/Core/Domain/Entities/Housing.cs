using Domain.Base;

namespace Domain.Entities;

public partial class Housing : Entity
{

    public Guid? StudentId { get; set; }

    public string Type { get; set; } = null!;

    public int RoomNumber { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Student? Student { get; set; }
}
