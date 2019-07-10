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
            else MainEmployment = "отсутствует";
        }

        protected override bool CountHours(DayEfficiency employment)
        {
            bool countEmployment = false;
            if (employment.Code != Codes.sleep) //пропуск сна
            {
                MainEmploymentHrs++;
                countEmployment = true;
                if (employment.Code != Codes.anotherEmpCode) //пропуск варианта "другое"
                {
                    if (allRestEmps.ContainsKey(employment.Name)) allRestEmps[employment.Name] += 1;
                    else allRestEmps[employment.Name] = 1;
                }
            }

            return countEmployment;
        }


        public override Color GetCellColor(int colorCode)
        {
            return Color.FromArgb(255, 255, 165, colorCode);
        }
    }
}
