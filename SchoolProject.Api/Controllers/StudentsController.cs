using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.MetaData;

namespace SchoolProject.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator )
        {
            _mediator = mediator;
        }

        [HttpGet(Router.StudentRouter.List)]
        public async Task<IActionResult> GetStudents()
        {
            var response =  await _mediator.Send(new GetStudentsListQuery());
            return Ok(response);
        }
        [HttpGet(Router.StudentRouter.GetById)]
        public async Task<IActionResult>GetStudent([FromRoute]int id)
        {
            var response = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(response);
        }
    }
}
