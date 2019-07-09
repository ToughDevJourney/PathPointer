using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class DayEfficiencyNow : IEmploymentsSkip
    {
        public string Name { get { return Texts.empNow; } }
        public string EmpType { get { return Texts.empTypeNow; } }
        public string TypeDescription { get { return Texts.empNowDescrip; } }
    }
}
