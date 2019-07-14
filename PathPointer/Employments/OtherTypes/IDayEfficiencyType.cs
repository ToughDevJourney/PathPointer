using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public interface IDayEfficiencyType
    {
        string Name { get; }
        string EmpType { get; }
        Color CellColor { get; }
        string TypeDescription { get; }

    }
}
