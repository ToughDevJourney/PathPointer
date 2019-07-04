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

            Management.SetPath("Employments\\Goals");
            using (StreamReader reader = new StreamReader(Management.FilePath)) {
                while ((readGoal = reader.ReadLine()) != null) {
                    goal = readGoal;
                    if (Management.GetValueByIndex(goal, 2) != "0") break;
                }               
            }

            if (goal != "") MainEmployment = goal;
            else MainEmployment = "Цели отсутствуют";
        }

        protected override void CountHours(string currentEmp)
        {
            spentHours++;
            if (MainEmployment == null) SetMainEmployment();
            else if (Management.GetValueByIndex(currentEmp, 1) == Management.GetValueByIndex(MainEmployment, 1)) MainEmploymentHrs++;
        }

        public override Color GetCellColor(int colorCode)
        {
            return Color.FromArgb(255, colorCode, 255, colorCode);
        }
    }
}
