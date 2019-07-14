using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class EmploymentsSkip : DayEfficiency
    {
        public override string EmpType { get { return _employmentType.EmpType; }  }
        public override Color CellColor { get { return _employmentType.CellColor; } }
        IDayEfficiencyType _employmentType;

        public EmploymentsSkip(IDayEfficiencyType employmentType) {
            _employmentType = employmentType;
            Name = employmentType.Name;
            TypeDescription = employmentType.TypeDescription;
        }

    }
}
