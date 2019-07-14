using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class DayEfficiencyNow : IDayEfficiencyType
    {
        public string Name { get { return Texts.empNow; } }
        public string EmpType { get { return Texts.empTypeNow; } }
        public Color CellColor { get { return Color.FromArgb(255, 212, 227, 230); } }
        public string TypeDescription { get { return Texts.empNowDescrip; } }
    }
}
