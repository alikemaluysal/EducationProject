using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Teacher
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int? Department { get; set; }

    public virtual ICollection<Advisor> Advisors { get; } = new List<Advisor>();

    public virtual ICollection<Announcement> Announcements { get; } = new List<Announcement>();

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual Department? DepartmentNavigation { get; set; }
}
