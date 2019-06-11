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
        public static int EmploymentCheckRange {
            get {
                SetPath("Common");

                int range = 1;
                string[] commonFileArr = File.ReadAllLines(FilePath);
                for (int i = 0; i < commonFileArr.Length; i++)
                {
                    if (GetValueByIndex(commonFileArr[i], 0) == "Employment Check Range") range = Convert.ToInt32(GetValueByIndex(commonFileArr[i], 1));
                }
                return range;
            }
        }


    }
}
