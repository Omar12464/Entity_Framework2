using Entity_Framework2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork2.Models
{
    [Table("Department", Schema = "dbo")]
    public class Department
    {
        public Department() 
        { 
        }
        #region ByConvention
        public int Id { get; set; }

        public string Name { get; set; }

        public int? InsId { get; set; }
        public int HiringDate { get; set; }
        public int DateOfCreation { get; set; }

        [ForeignKey(nameof(InsId))]
        public ICollection<Instructor>? instructors { get; set; } = new HashSet<Instructor>();
        [ForeignKey("StudentID")]
        public ICollection<Student>? Student { get; set; }

        #endregion
        #region Data Annotations
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required]
        //[StringLength(50, MinimumLength = 15)]
        //public string Name { get; set; }
        //[Required]
        //[ForeignKey(nameof(Instructor))]
        //public int InsId { get; set; }
        //[Required]
        //public int HiringDate { get; set; } 
        #endregion

    }
}
