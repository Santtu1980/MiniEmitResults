using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEmitResults.ValueObjects
{
    public class Result
    {
        public Guid CourseId { get; set; }
        public int Time { get; set; }
        public string CompetitorName { get; set; }
        public int EmitCardNumber { get; set; }
    }
}
