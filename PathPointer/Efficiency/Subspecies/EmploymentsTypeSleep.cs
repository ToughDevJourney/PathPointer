using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class EmploymentsTypeSleep : IEmploymentsOtherTypes
    {
        public string EmploymentName { get { return Texts.empSleep; } }
        public string EmploymentCode { get { return Codes.sleep; } }
        public string TypeDescription { get { return Texts.empSleepType; } }
    }
}
