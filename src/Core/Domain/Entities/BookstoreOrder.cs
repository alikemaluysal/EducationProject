using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BookstoreOrder
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? CourseId { get; set; }

    public DateTime Date { get; set; }

    public decimal Total { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Student? Student { get; set; }
}
