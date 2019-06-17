using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public class FileManagement : Management
    {

        public static void CheckAllFiles() {
            CheckForDirectory();
            CheckForCommon();
            CheckForEfficiency();
            CheckForCodes();
            CheckForBusiness();
            CheckForFun();
            CheckForGoals();
            CheckForRest();
        }

        private static void CheckForDirectory() {
            SetPath();
            if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);
            if (!Directory.Exists(FilePath + "\\Employments")) Directory.CreateDirectory(FilePath + "\\Employments");
            if (!Directory.Exists(FilePath + "\\Employments\\Archive")) Directory.CreateDirectory(FilePath + "\\Employments\\Archive");

        }

        private static void CheckForCommon(){
            if (!CheckFileExistance("Common")) {
                string[] fileArray = new string[4];
                var cal = new GregorianCalendar();
                int currentWeekNumber = cal.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
                fileArray[0] = "Common info:";
                fileArray[1] = $"Week Number!{currentWeekNumber}";
                fileArray[2] = "User settings:";
                fileArray[3] = "Employment Check Range!1";
                File.WriteAllLines(FilePath, fileArray);
            }
        }

        private static void CheckForEfficiency() {
            if (!CheckFileExistance("Efficiency"))
            {
                using (File.Create(FilePath)) { }
                for (int j = 1; j <= 2; j++) StatsManagement.AddNewWeekIntoEfficiency();
            }

        }

        private static void CheckForCodes() {
            if (!CheckFileExistance("Employments\\Codes"))
            {
                string[] fileArray = new string[4];
                fileArray[0] = "Business!0";
                fileArray[1] = "Goals!0";
                fileArray[2] = "Rest!0";
                fileArray[3] = "Fun!0";
                File.WriteAllLines(FilePath, fileArray);
            }
        }

        private static void CheckForBusiness() {
            if (!CheckFileExistance("Employments\\Business")) using (File.Create(FilePath)) { }
        }

        private static void CheckForGoals()
        {
            if (!CheckFileExistance("Employments\\Goals"))
            {
                using (File.Create(FilePath)) { }
                DataManagement.WriteEmpFiles($"Установка PathPointer!{DataManagement.Code}!1!{DateTime.Today.ToShortDateString()}", "Employments\\Goals");
            }
        }

        private static void CheckForRest() {
            if (!CheckFileExistance("Employments\\Rest")) using (File.Create(FilePath)) { }

        }

        private static void CheckForFun()
        {
            if (!CheckFileExistance("Employments\\Fun")) using (File.Create(FilePath)) { }
        }

        private static bool CheckFileExistance(string fileStr) {
            SetPath(fileStr);
            if (File.Exists(FilePath)) return true;
            else return false;
        }


    }
}
