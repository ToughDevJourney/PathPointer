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
            int maxRest = allRestEmps.Max(s => s.Value);
            MainEmployment = allRestEmps.FirstOrDefault(s => s.Value == maxRest).Key;
        }

        protected override void CountHours(string currentEmp)
        {
            if (currentEmp != "Rest!@") //пропуск варианта "другое"
            {
                MainEmploymentHrs++;
                if (currentEmp != "Rest!0") //пропуск сна
                {
                    if (allRestEmps.ContainsKey(currentEmp)) allRestEmps[currentEmp] += 1;
                    else allRestEmps[currentEmp] = 1;
                }
            }
        }


        public override Color GetCellColor(int colorCode)
        {
            return Color.FromArgb(255, 255, 165, colorCode);
        }
    }
}
