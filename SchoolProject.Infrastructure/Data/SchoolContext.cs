using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
            
        }
        public SchoolContext(DbContextOptions<SchoolContext> options) :base(options)
        {
            
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Subject> Subjects{ get; set; }
        public DbSet<DepartmentSubject> DepartmentSubjects{ get; set; }
        public DbSet<StudentSubject> StudentSubjects{ get; set; }

    }
}
