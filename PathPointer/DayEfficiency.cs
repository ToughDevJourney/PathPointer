using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public abstract class DayEfficiency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public abstract string EmpType { get; }
        public string TypeDescription { get; set; }
        public string HoursDescription { get; set; }
        public string HoursToSpendDescription { get; set; }
    }
}
