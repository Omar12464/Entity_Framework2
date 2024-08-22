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
    [Table("StudCourse", Schema = "dbo")]
    public class StudCourse
    {
        //[Key]
        //[Column(Order = 0)]
        public int StudId { get; set; }
        //[Key]
        //[Column(Order = 1)]
        public int crsId { get; set; }
        public string Grade { get; set; }
        [ForeignKey(nameof(StudId))]
        public Student Student { get; set; }
        [ForeignKey(nameof(crsId))]

        public Course Course { get; set; }

    }
}
