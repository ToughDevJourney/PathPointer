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
            if (allRestEmps.Values.Any())
            {
                int maxRest = allRestEmps.Max(s => s.Value);
                MainEmployment = allRestEmps.FirstOrDefault(s => s.Value == maxRest).Key;
            }
            else
            {
                MainEmployment = "отсутствует";
                MainEmploymentHrs = 0;
            }
        }

        protected override void CountHours(string currentEmp)
        {
            if (currentEmp != $"Rest!{Codes.sleep}") //пропуск сна
            {
                MainEmploymentHrs++;
                if (currentEmp != $"Rest!{Codes.anotherEmp}") //пропуск варианта "другое"
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
