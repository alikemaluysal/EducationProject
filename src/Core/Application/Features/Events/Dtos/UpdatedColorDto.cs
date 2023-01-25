namespace Application.Features.Events.Dtos;

public class UpdatedEventDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime Date { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Location { get; set; } = null!;
}