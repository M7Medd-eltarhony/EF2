using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("Instructor")]
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
