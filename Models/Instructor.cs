using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_FrameWork2.Models
{
    [Table("Instructor", Schema = "dbo")]
    public class Instructor
    {
        #region By Convention
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int? DeptId { get; set; }

        #endregion

        #region Data Annotation
        // If you want to use data annotations, uncomment the following block
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 10)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public int Bonus { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [Required]
        [Range(21, 60)]
        public string Address { get; set; }

        public double HourRate { get; set; }

        [Required]
        [ForeignKey(nameof(Department))]
        public int DepId { get; set; }
        */
        #endregion
    }


}
