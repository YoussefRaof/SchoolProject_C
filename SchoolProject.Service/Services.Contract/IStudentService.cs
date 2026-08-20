using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Services.Contract
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student?> GetStudentByIdAsync(int id);
    }
}
