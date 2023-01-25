using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class Attendance : Entity
{

    public Guid? StudentId { get; set; }

    public Guid? ClassId { get; set; }

    public DateTime Date { get; set; }

    public bool Present { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Student? Student { get; set; }
}
