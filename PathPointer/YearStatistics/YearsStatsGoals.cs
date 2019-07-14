using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class YearsStatsGoals : YearStats
    {
        public override string EmpType { get { return "Goals"; } }
        public int spentHours;

        public void SetMainEmployment() {
            string readGoal = "";
            string goal = "";

            using (StreamReader reader = new StreamReader(Management.GetPath($"Employments\\{EmpType}"))) {
                while ((readGoal = reader.ReadLine()) != null) {
                    goal = readGoal;
                    if (Management.GetValueByIndex(goal, 2) != "0") break;
                }               
            }

            if (goal != "") MainEmployment = goal;
            else MainEmployment = "Цели отсутствуют";
        }

        protected override bool CountHours(DayEfficiency employment)
        {
            spentHours++;
            if (MainEmployment == null) SetMainEmployment();
            else if (employment.Code == Management.GetValueByIndex(MainEmployment, 1)) MainEmploymentHrs++;
            return true;
        }

        public override Color GetCellColor(int colorCode)
        {
            int red;
            int green;
            int blue;

            CheckColorCode(out red, out green, out blue, colorCode, goals.CellColor);

            return Color.FromArgb(255, red, green, blue);
        }




    }
}
