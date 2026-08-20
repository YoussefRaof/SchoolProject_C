using Microsoft.EntityFrameworkCore;
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
        private readonly IGenericRepositoryAsync<Student> _studentRepository;

        public StudentService(IGenericRepositoryAsync<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            return await _studentRepository.GetByIdAsync(id);
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return  await  _studentRepository.GetTableNoTracking().ToListAsync();
        }
    }
}
