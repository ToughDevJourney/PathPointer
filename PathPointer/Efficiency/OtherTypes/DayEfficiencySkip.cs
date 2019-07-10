using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class DayEfficiencySkip : IDayEfficiencyType
    {
        public string Name { get { return Texts.empSkip; } }
        public string EmpType { get { return Texts.empTypeSkip; } }
        public string TypeDescription { get { return Texts.empSkipDescrip; } }
    }
}
