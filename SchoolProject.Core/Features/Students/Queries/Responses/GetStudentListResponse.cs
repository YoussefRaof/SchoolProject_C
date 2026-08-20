using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Responses
{
    public class GetStudentListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
       
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? DepartmentName { get; set; }


    }
}
