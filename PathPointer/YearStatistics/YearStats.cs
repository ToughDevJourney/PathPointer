using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    abstract class YearStats
    {
        StatsManagement stats = new StatsManagement();
        protected EmploymentsBusiness business = new EmploymentsBusiness();
        protected EmploymentsGoals goals = new EmploymentsGoals();
        protected EmploymentsRest rest = new EmploymentsRest();
        protected EmploymentsFun fun = new EmploymentsFun();

        public abstract string EmpType { get; }
        public string MainEmployment { get; set; }
        public int MainEmploymentHrs { get; set; }
        public int[,] yearEmpNum = new int[7, 52];


        public abstract Color GetCellColor(int colorCode);

        protected abstract bool CountHours(DayEfficiency employment);

        public YearStats()  //поиск статистики за целый год
        {
            int getWeek = 0;

            DayEfficiency[] dayEfficiency;

            for (int yw = 52; yw >= 1; yw--) 
            {
                getWeek++;
                for (int dow = 1; dow <= 7; dow++)
                {
                    dayEfficiency = stats.FillStatsArray(yw, dow);
                    if (dayEfficiency != null)
                    {
                        for (int hr = 0; hr < 24; hr++)
                        {
                            if (dayEfficiency[hr].EmpType == EmpType)
                            {
                                if(CountHours(dayEfficiency[hr])) yearEmpNum[dow - 1, yw - 1]++;
                            }
                        }
                    }
                    

                }
            }
        }


        protected void CheckColorCode(out int red, out int green, out int blue, int decreaseColor, Color color) {
            red = color.R - decreaseColor < 0 ? 0 : color.R - decreaseColor;
            green = color.G - decreaseColor < 0 ? 0 : color.G - decreaseColor;
            blue = color.B - decreaseColor < 0 ? 0 : color.B - decreaseColor;
        }



    }
}
