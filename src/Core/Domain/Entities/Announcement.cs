using Core.Persistence.Repositories;

namespace Domain.Entities;

public partial class Announcement : Entity
{

    public Guid? CourseId { get; set; }

    public Guid? TeacherId { get; set; }

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
