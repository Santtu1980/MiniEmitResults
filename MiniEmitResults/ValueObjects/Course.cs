using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEmitResults.ValueObjects
{
    public class Course
    {
        public Guid Id = new Guid();
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public decimal Length_m { get; set; }
        public List<ControlPoint> ControlPoints { get; set; }
    }
}
