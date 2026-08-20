using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator )
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var response =  await _mediator.Send(new GetStudentsListQuery());
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetStudent([FromRoute]int id)
        {
            var response = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(response);
        }
    }
}
