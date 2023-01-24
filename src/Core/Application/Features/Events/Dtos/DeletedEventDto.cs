using Core.Application.Dtos;

namespace Application.Features.Events.Dtos;

public class DeletedEventDto : IDto
{
    public int Id { get; set; }
}