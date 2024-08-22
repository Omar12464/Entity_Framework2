using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork2.Models
{
    [Table("Course_Inst", Schema = "dbo")]
    public class Course_Inst
    {
        public int CrsId { get; set; }
        public int InstId { get; set; }
        public string Evaluate { get; set; }
        [ForeignKey(nameof(InstId))]
        public Instructor Instructor { get; set; }
        [ForeignKey(nameof(CrsId))]

        public Course course { get; set; }

    }
}
