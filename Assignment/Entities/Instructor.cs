using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30, MinimumLength = 10)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Bouns { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal HourRate { get; set; }
        [Required]
        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; }
        public Department Department { get; set; }
    }
}
