using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class YearsStatsFun : YearStats
    {
        public override string EmpType { get { return "Fun"; } }
        Dictionary<string, int> allFunEmps = new Dictionary<string, int>();

        public YearsStatsFun()
        {
            if (allFunEmps.Values.Any())
            {
                int maxFun = allFunEmps.Max(s => s.Value);
                MainEmployment = allFunEmps.FirstOrDefault(s => s.Value == maxFun).Key;
            }
            else MainEmployment = "отсутствует";
        }

        protected override bool CountHours(DayEfficiency employment) {
            MainEmploymentHrs++;
            if (employment.Code != Codes.anotherEmpCode) //пропуск варианта "другое" из опросника
            {
                if (allFunEmps.ContainsKey(employment.Name)) allFunEmps[employment.Name] += 1;
                else allFunEmps[employment.Name] = 1;
            }

            return true;       
        }

        public override Color GetCellColor(int colorCode)
        {
            int red;
            int green;
            int blue;

            CheckColorCode(out red, out green, out blue, colorCode, fun.CellColor);

            return Color.FromArgb(255, red, green, blue);
        }



    }
}
