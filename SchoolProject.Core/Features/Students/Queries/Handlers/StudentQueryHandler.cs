using AutoMapper;
using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Responses;
using SchoolProject.Core.GeneralResponse;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler ,  
        IRequestHandler<GetStudentsListQuery, Response <List<GetStudentListResponse>>>,
        IRequestHandler<GetStudentByIdQuery , Response<GetStudentByIdResponse>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentQueryHandler(IStudentService studentService , IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsAsync();   

            var response = _mapper.Map<List<GetStudentListResponse>>(students);

            return Success(response);
        }

        public async Task<Response<GetStudentByIdResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student is null)
                return NotFound<GetStudentByIdResponse>("Student Not Found");

            var response =  _mapper.Map<GetStudentByIdResponse>(student);
            return Success(response);

        }
    }
}
