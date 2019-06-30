using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class LinesFormat
    {

        public static string TimeFormat(string checkFormat)
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

        public static string ShortFormatTime(string time)
        {
            time = time.Replace(":00", "");
            if (time[0] == '0') time = time.Substring(1);
            return time;
        }

    }
}
