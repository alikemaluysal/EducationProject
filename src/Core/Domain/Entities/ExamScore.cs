using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ExamScore
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? ExamId { get; set; }

    public decimal Score { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual Student? Student { get; set; }
}
