using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEmitResults.ValueObjects
{
    public class ControlPoint
    {
        public int OrderNumber { get; set; }
        public int IdNumber { get; set; }
        public bool IsInterval { get; set; }
        public bool[] BackUpLabelMatrix { get; set; }
    }
}
