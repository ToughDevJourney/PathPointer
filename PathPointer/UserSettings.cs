using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class UserSettings : Management
    {

        public static int EmploymentCheckRange { get; set; }
        public static int WeekFunTime { get; set; }
        public static int SleepTimeBegin { get; set; }
        public static int SleepTimeEnd { get; set; }

        static UserSettings() {
            UpdateAllSettings();
        }

        public static void UpdateAllSettings(){
            EmploymentCheckRange = GetFileValue("Employment Check Range");
            WeekFunTime = GetFileValue("Week Fun Time");
            SleepTimeBegin = GetFileValue("Sleep Time Begin");
            SleepTimeEnd = GetFileValue("Sleep Time End");
        }

        private static int GetFileValue(string settingName){
            SetPath("Common");
            int value = 1;
            if (File.Exists(FilePath))
            {
                string[] commonFileArr = File.ReadAllLines(FilePath);
                for (int i = 0; i < commonFileArr.Length; i++)
                {
                    if (GetValueByIndex(commonFileArr[i], 0) == settingName)
                    {
                        value = Convert.ToInt32(GetValueByIndex(commonFileArr[i], 1));
                        break;
                    }
                }
            }
            return value;
        }

    }
}
