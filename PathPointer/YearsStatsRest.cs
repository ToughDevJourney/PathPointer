using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class YearsStatsRest : YearStats
    {
        Dictionary<string, int> allRestEmps = new Dictionary<string, int>();
        public override string EmpType { get { return "Rest"; } }

        public YearsStatsRest() {
            MainEmploymentHrs = allRestEmps.Max(s => s.Value);
            MainEmployment = allRestEmps.FirstOrDefault(s => s.Value == MainEmploymentHrs).Key;
        }

        protected override void CountHours(string currentEmp)
        {
            if (currentEmp != "Rest!0" && currentEmp != "Rest!@") //пропуск сна и варианта "другое"
            {
                if (allRestEmps.ContainsKey(currentEmp)) allRestEmps[currentEmp] += 1;
                else allRestEmps[currentEmp] = 1;
            }
        }


        public override Color GetCellColor(int colorCode)
        {
            return Color.FromArgb(255, 255, 165, colorCode);
        }
    }
}
