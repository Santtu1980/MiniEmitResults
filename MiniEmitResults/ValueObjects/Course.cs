using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEmitResults.ValueObjects
{
    public class Course
    {
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public decimal Length_m { get; set; }
        public List<Dictionary<int, int>> CheckPoints { get; set; }
    }
}
