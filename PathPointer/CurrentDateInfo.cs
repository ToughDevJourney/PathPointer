using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PathPointer
{
    static class CurrentDateInfo
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

    }
}
