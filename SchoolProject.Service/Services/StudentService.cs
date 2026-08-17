using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Repositories.Contract;
using SchoolProject.Service.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }
    }
}
