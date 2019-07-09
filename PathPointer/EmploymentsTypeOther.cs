using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class EmploymentsTypeOther : IEmploymentsOtherTypes
    {
        
        public string EmploymentName { get { return Texts.empSleep; } }
        public string TypeDescription { get { return Texts.empSleepType; } }
    }
}
