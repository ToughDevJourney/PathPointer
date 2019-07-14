using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class DayEfficiencyFuture : IDayEfficiencyType
    {
        public string Name { get { return Texts.empFuture; } }
        public string EmpType { get { return Texts.empTypeFuture; } }
        public Color CellColor { get { return Color.FromArgb(255, 25, 25, 55); } }
        public string TypeDescription { get { return Texts.empFutureDescrip; } }
    }
}
