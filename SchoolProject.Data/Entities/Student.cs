using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; } = null!;
        [StringLength(500)]
        public string Address { get; set; } = null!;
        [StringLength(500)]
        public string Phone { get; set; } = null!;
        public int? DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; } =null!;

        public virtual ICollection<StudentSubject> StudentsSubjects { get; set; } = new HashSet<StudentSubject>();
    }
}
