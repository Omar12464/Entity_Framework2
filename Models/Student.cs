using Entity_FrameWork2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework2.Models
{
    [Table("Student", Schema = "dbo")]
    public class Student
    {
        #region Convention
        //public int? Id { get; set; }
        //public string Fname { get; set; }
        //public string LName { get; set; }
        //public string Address { get; set; }
        //public int? Age { get; set; }
        //public int DepId { get; set; } 
        #endregion
        #region Data Annotation
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 15)]
        [Column(TypeName = "varchar")]
        public string Fname { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 15)]
        [Column(TypeName = "varchar")]
        public string LName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 15)]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }

        public int? Age { get; set; }
        [Required]
        [ForeignKey(nameof(Age))]
        public int? DepId { get; set; }

        #endregion
    }
}
