using Entity_FrameWork2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework2.Inheritance
{
    public class Parttime: InstructorContainer
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }
    }
}
