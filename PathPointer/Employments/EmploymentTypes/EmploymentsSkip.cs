using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class EmploymentsSkip : DayEfficiency
    {
        public override string EmpType { get { return _employmentType.EmpType; }  }
        IDayEfficiencyType _employmentType;

        public EmploymentsSkip(IDayEfficiencyType employmentType) {
            _employmentType = employmentType;
            Name = employmentType.Name;
            TypeDescription = employmentType.TypeDescription;
        }

    }
}
