using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class DayEfficiencySkip : IDayEfficiencyType
    {
        public string Name { get { return Texts.empSkip; } }
        public string EmpType { get { return Texts.empTypeSkip; } }
        public Color CellColor { get { return Color.FromArgb(255,51,58,78); } }
        public string TypeDescription { get { return Texts.empSkipDescrip; } }
    }
}
