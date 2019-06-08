using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    static class CurrentDateInfo
    {
        private static int dayOfWeek;
        private static int hour;

        public static int DayOfWeek { get {
                dayOfWeek = (int)DateTime.Now.DayOfWeek;
                dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;
                return dayOfWeek;
            }
        }

        public static int Hour
        {
            get
            {
                hour = DateTime.Now.Hour;
                return hour;
            }
        }
    }
}
