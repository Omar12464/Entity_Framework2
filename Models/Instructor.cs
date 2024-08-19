using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork2.Models
{
    [Table("Instructor", Schema = "dbo")]

    internal class Instructor
    {
        #region By Convention
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public Double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int DepId { get; set; }
        #endregion
        #region Data Annotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required]
        //[StringLength(80,MinimumLength = 10)]
        //[Column(TypeName="varchar")]

        //public string Name { get; set; }
        //public int Bonus { get; set; }
        //[Column(TypeName="money")]
        //[DataType(DataType.Currency)]
        //public Double Salary { get; set; }
        //[Required]
        //[Range(21,60)]
        //public string Address { get; set; }
        //public double HourRate { get; set; }
        //[Required]
        //[ForeignKey(nameof(Department))]
        //public int DepId { get; set; } 
        #endregion
    }
}
