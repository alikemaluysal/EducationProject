using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.Students.Commands.UploadProfilePicture
{
    public class UploadStudentProfilePicCommandRequest : IRequest<bool>
    {
        public string StudentId { get; set; }
        public IFormFileCollection Files;
    }
}
