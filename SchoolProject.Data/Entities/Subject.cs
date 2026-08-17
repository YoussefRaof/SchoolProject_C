using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string SubjectName { get; set; } = null!;
        public DateTime Period { get; set; }
        public virtual ICollection<StudentSubject> StudentsSubjects { get; set; } = new HashSet<StudentSubject>();
        public virtual ICollection<DepartmentSubject> DepartmetsSubjects { get; set; } = new HashSet<DepartmentSubject>();
    }

}
