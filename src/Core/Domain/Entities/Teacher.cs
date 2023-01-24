using Domain.Base;
using Domain.Entities.FileEntities;

namespace Domain.Entities;

public partial class Teacher : Entity
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;
    public Guid? ProfilePictureId { get; set; }
    public Guid? DepartmentId { get; set; }

    public virtual ICollection<Advisor> Advisors { get; } = new List<Advisor>();

    public virtual ICollection<Announcement> Announcements { get; } = new List<Announcement>();
    public virtual ProfilePicture ProfilePicture { get; set; } = null!;


    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual Department? DepartmentNavigation { get; set; }
}
