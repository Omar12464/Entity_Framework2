using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork2.Models
{
    [Table("Topic", Schema = "dbo")]
    public class Topic
    {

        #region By Convention
        public int Top_Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> courses { get; set; }=new HashSet<Course>();//Relation Many by convention
        #endregion
        #region Data Annotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        ////public int Id { get; set; }
        ////[Required]
        ////[StringLength(50,MinimumLength =10)]
        ////public string? Name { get; set; } 
        #endregion
    }
}
