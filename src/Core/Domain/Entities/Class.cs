using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Class
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public string Semester { get; set; } = null!;

    public int Year { get; set; }

    public virtual ICollection<Attendance> Attendances { get; } = new List<Attendance>();

    public virtual Course? Course { get; set; }
}
