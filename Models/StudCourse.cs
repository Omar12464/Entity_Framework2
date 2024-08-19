using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork2.Models
{
    [Table("StudCourse", Schema = "dbo")]
    internal class StudCourse
    {

        public int StudId { get; set; }
        public int crsId { get; set; }
        public string Grade { get; set; }

    }
}
