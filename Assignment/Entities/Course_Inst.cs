using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course_Inst
    {
        [ForeignKey("Instructor")]
        public int inst_ID { get; set; }
        [ForeignKey("Course")]
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
