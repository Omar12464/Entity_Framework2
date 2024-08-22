using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork2.Models
{
    [Table("Course", Schema = "dbo")]//By Data Annotation

    public class Course
    {
        #region By Convention
        public int? Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public int TopicId { get; set; }

        public Topic topics { get; set; }//Relation One by convention

        public ICollection<StudCourse> coursestudent { get; set; }=new HashSet<StudCourse>();
        public ICollection<Course_Inst> CourseInstructor { get; set; } = new HashSet<Course_Inst>();

        #region Data Annotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int? Id { get; set; }
        //[MinLength(1)]
        //[Required]
        //public int Duration { get; set; }
        //[Required]
        //[StringLength(100, MinimumLength = 15)]
        //[Column(TypeName = "varchar")]
        //public string? Name { get; set; }
        //public string? Description { get; set; }
        //[Required]
        //[ForeignKey(nameof(Topic))]
        //public int TopId { get; set; } 
        #endregion
        #region Fluent Api

        #endregion
        #endregion
    }
}

