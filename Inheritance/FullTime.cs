using Entity_FrameWork2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework2.Inheritance
{
    public class FullTime: InstructorContainer
    {
        public decimal Salary { get; set; }
        public int ShiftHours { get; set; }
    }

}
