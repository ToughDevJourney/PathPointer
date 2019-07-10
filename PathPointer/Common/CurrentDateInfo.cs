using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PathPointer
{
    class CurrentDateInfo
    {
        private static int weekNumber;
        private static int dayOfWeek;

        public static int DayOfWeek
        {
            get {
                dayOfWeek = (int)DateTime.Now.DayOfWeek;
                dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;
                return dayOfWeek;
            }
        }

        public static int WeekNumber
        {
            get
            {
                var cal = new GregorianCalendar();
                weekNumber = cal.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, System.DayOfWeek.Monday);
                return weekNumber;
            }
        }

        public static void CheckWeekRelevance()
        {
            StatsManagement stats = new StatsManagement();
            string commonFile = Management.GetPath("Common");
            int fileWeekNumber;
            int fileYear;
            int numberOfWeeks = 0;

            string[] commonFileArr = File.ReadAllLines(commonFile);

            for (int i = 0; i < commonFileArr.Length; i++)
            {
                if (Management.GetValueByIndex(commonFileArr[i], 0) == "Week Number")
                {
                    fileYear = Convert.ToInt32(Management.GetValueByIndex(commonFileArr[i], 2));
                    fileWeekNumber = Convert.ToInt32(Management.GetValueByIndex(commonFileArr[i], 1));

                    if (fileWeekNumber != WeekNumber || fileYear != DateTime.Now.Year)
                    {
                        if (DateTime.Now.Year - fileYear == 1 && weekNumber == 52 || DateTime.Now.Year == fileYear) numberOfWeeks = weekNumber - fileWeekNumber; 
                        else
                        {
                            numberOfWeeks = (DateTime.Now.Year - fileYear - 1) * 54;    //разница между годами
                            numberOfWeeks += 52 - fileWeekNumber; //пропущенные недели года последнего использования
                            numberOfWeeks += weekNumber;    //недели этого года                          
                        }

                        StatsManagement.AddNewWeekIntoEfficiency(numberOfWeeks);
                        commonFileArr[i] = $"Week Number!{WeekNumber}!{DateTime.Now.Year}";
                        File.WriteAllLines(commonFile, commonFileArr);
                        break;
                    }
                }
            }
        }






    }
}
