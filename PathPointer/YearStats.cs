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

        public abstract string EmpType { get; }
        public string MainEmployment { get; set; }
        public int MainEmploymentHrs { get; set; }
        public int[,] yearEmpNum = new int[7, 52];


        public YearStats()
        {
            int getWeek = 0;

            string currentEmp;

            for (int yw = 51; yw >= 0; yw--)
            {
                getWeek++;
                for (int dow = 0; dow < 7; dow++)
                {
                    string[] weekEmp = StatsManagement.FillStatsArray(getWeek);
                    if (weekEmp != null)
                    {
                        for (int hr = 0; hr < 24; hr++)
                        {
                            currentEmp = Management.GetValueByIndex(weekEmp[hr], dow + 1, ";");
                            if (Management.GetValueByIndex(currentEmp) == EmpType)
                            {
                                CountHours(currentEmp);
                                yearEmpNum[dow, yw]++;
                            }
                        }
                    }
                    else {
                        yw = 0;
                        break;
                    }
                }
            }
        }

        public abstract Color GetCellColor(int colorCode);

        protected abstract void CountHours(string currentEmp);

    }
}
