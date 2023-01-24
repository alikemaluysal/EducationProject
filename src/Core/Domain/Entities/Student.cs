using Domain.Base;
using Domain.Entities.FileEntities;

namespace Domain.Entities;

public partial class Student : Entity
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public Guid? ProfilePictureId { get; set; }
    public Guid? MajorDepartmentId { get; set; }

    public Guid? DegreeId { get; set; }

    public virtual ICollection<Advisor> Advisors { get; } = new List<Advisor>();

    public virtual ICollection<Attendance> Attendances { get; } = new List<Attendance>();

    public virtual ICollection<BookstoreOrder> BookstoreOrders { get; } = new List<BookstoreOrder>();

    public virtual ICollection<ClubMembership> ClubMemberships { get; } = new List<ClubMembership>();

    public virtual ICollection<Club> Clubs { get; } = new List<Club>();
    public virtual ProfilePicture ProfilePicture { get; set; } = null!;
    public virtual Degree? DegreeNavigation { get; set; }

    public virtual ICollection<ExamScore> ExamScores { get; } = new List<ExamScore>();

    public virtual ICollection<FinancialAid> FinancialAids { get; } = new List<FinancialAid>();

    public virtual ICollection<Housing> Housings { get; } = new List<Housing>();

    public virtual Department? MajorNavigation { get; set; }

    public virtual ICollection<MealPlan> MealPlans { get; } = new List<MealPlan>();
}
