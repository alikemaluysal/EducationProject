using Domain.Base;

namespace Domain.Entities;

public partial class BookstoreInventory : Entity
{

    public Guid? CourseId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Author { get; set; }

    public string? Publisher { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public virtual Course? Course { get; set; }
}
