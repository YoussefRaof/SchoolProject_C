using AutoMapper;
using MediatR;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.GeneralResponse;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
    public class StudentCommandHandler : ResponseHandler, IRequestHandler<CreateStudentCommand, Response<string>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentCommandHandler(IStudentService studentService , IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentMapper = _mapper.Map<Student>(request);
            var result = await _studentService.CreateStudentAsync(studentMapper);
            if (result.Equals("Success"))
                return Created("Student Added Successsfully");
            else if (result.Equals("Student Name Already Exists"))
                return UnprocessableEntity<string>("Failed");

            return BadRequest<string>();

            
        }
    }
}
