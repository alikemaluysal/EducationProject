using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Attendance
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? ClassId { get; set; }

    public DateTime Date { get; set; }

    public bool Present { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Student? Student { get; set; }
}
