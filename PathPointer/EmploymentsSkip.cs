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
        IEmploymentsSkip _employmentType;

        public EmploymentsSkip(IEmploymentsSkip employmentType) {
            _employmentType = employmentType;
            Name = employmentType.Name;
            TypeDescription = employmentType.TypeDescription;
        }

    }
}
