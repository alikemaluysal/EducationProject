using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class ExamScore : Entity
{
    public Guid? StudentId { get; set; }

    public Guid? ExamId { get; set; }

    public decimal Score { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual Student? Student { get; set; }
}
