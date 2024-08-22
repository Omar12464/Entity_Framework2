using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework2.Inheritance
{
    public abstract class InstructorContainer
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int? ManagerId { get; set; }
    }
}
