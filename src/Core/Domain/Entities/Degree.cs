using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Degree
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Department { get; set; }

    public virtual ICollection<DegreeRequirement> DegreeRequirements { get; } = new List<DegreeRequirement>();

    public virtual Department? DepartmentNavigation { get; set; }

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
