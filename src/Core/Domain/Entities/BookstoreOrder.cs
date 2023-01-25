using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class BookstoreOrder : Entity
{

    public Guid? StudentId { get; set; }

    public Guid? CourseId { get; set; }

    public DateTime Date { get; set; }

    public decimal Total { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Student? Student { get; set; }
}
