using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BookstoreInventory
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Author { get; set; }

    public string? Publisher { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public virtual Course? Course { get; set; }
}
