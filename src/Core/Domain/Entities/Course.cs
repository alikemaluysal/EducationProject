using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Instructor { get; set; }

    public int Credits { get; set; }

    public virtual ICollection<Announcement> Announcements { get; } = new List<Announcement>();

    public virtual ICollection<BookstoreInventory> BookstoreInventories { get; } = new List<BookstoreInventory>();

    public virtual ICollection<BookstoreOrder> BookstoreOrders { get; } = new List<BookstoreOrder>();

    public virtual ICollection<Class> Classes { get; } = new List<Class>();

    public virtual ICollection<DegreeRequirement> DegreeRequirements { get; } = new List<DegreeRequirement>();

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();

    public virtual Teacher? InstructorNavigation { get; set; }

    public virtual ICollection<Resource> Resources { get; } = new List<Resource>();
}
