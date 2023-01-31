using Application.Features.Students.Commands.UploadProfilePicture;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UploadProfilePicture([FromQuery] UploadStudentProfilePicCommandRequest request) // studentId queryden gelecek
        {
            request.Files = Request.Form.Files;
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
