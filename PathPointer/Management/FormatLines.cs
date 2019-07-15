using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class FormatLines
    {

        public static string TimeFormat(string checkFormat) // приведение времени в вид "05:15"
        {
            int hoursADay = 24;

            if (checkFormat == "Выходной")
            {
                checkFormat = "00:00";
            }
            else
            {
                checkFormat = checkFormat.Substring(0, 2);
                if (checkFormat[0] == ' ')
                {
                    checkFormat = "00:00";
                }
                else
                {
                    if (checkFormat[1] == ' ')
                    {
                        checkFormat = $"0{checkFormat[0]}:00";
                    }
                    else
                    {
                        if (checkFormat[0] == 0)
                        {
                            checkFormat = $"0{checkFormat}:00";
                        }
                        else
                        {
                            if (Convert.ToInt32(checkFormat) >= hoursADay)
                            {
                                checkFormat = "23:00";
                            }
                            else
                            {
                                checkFormat = $"{checkFormat}:00";
                            }
                        }
                    }
                }
            }
            return checkFormat;
        }

        public static string ShortFormatTime(string time)   //приведение времени из вида "05:00" в "5"
        {
            time = time.Replace(":00", "");
            if (time[0] == '0') time = time.Substring(1);
            return time;
        }


        public static string ShortTimeFormatToLong(string time)   //форматирование времени из вида "5 15" в  вид "05:00 - 15:00"
        {
                string beginTime = time.Remove(time.IndexOf(" "));
                string endTime = time.Substring(time.IndexOf(" ") + 1);

                beginTime = beginTime.Length == 2 ? $"{beginTime}:00" : $"0{beginTime}:00";
                endTime = endTime.Length == 2 ? $"{endTime}:00" : $"0{endTime}:00";

                time = $"{beginTime} - {endTime}";

            return time;
        }

    }
}
