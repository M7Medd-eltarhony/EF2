using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30, MinimumLength = 10)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [ForeignKey("Topic")]
        public int Top_ID { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();
        public Topic Topic { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
