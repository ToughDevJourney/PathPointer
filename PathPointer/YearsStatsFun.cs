﻿using System;
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
            MainEmploymentHrs = allFunEmps.Max(s => s.Value);
            MainEmployment = allFunEmps.FirstOrDefault(s => s.Value == MainEmploymentHrs).Key;
        }

        protected override void CountHours(string currentEmp) {

            if (currentEmp != "Fun!0") //пропуск варианта "другое" из опросника
            {
                if (allFunEmps.ContainsKey(currentEmp)) allFunEmps[currentEmp] += 1;
                else allFunEmps[currentEmp] = 1;
            }

       
        }

        public override Color GetCellColor(int colorCode)
        {
            return Color.FromArgb(255, 255, colorCode, colorCode);
        }



    }
}