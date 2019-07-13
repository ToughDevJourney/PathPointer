using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public static class FileManagement
    {
        public static readonly string EfficiencyFile = Management.GetPath("Efficiency");
        public static readonly string AchivementsFile = Management.GetPath("Achivements");
        public static readonly string GamesList = Management.GetPath("GamesList");
        public static readonly string BusinessFile = Management.GetPath($"Employments\\{Texts.empBusiness}");
        public static readonly string GoalsFile = Management.GetPath($"Employments\\{Texts.empGoals}");
        public static readonly string RestFile = Management.GetPath($"Employments\\{Texts.empRest}");
        public static readonly string FunFile = Management.GetPath($"Employments\\{Texts.empFun}");
        public static readonly string intermediateFile = Management.GetPath("Intermediate File");

        public static string[] CommonFileArray { get; set; }
        public static bool firstLaunch = false;
        public static bool FirstLaunch {
            get { return firstLaunch; }
            set { firstLaunch = value; }
        }

        static FileManagement() {
            CheckAllFiles();
            if (firstLaunch == true) {
                EmploymentsGoals goals = new EmploymentsGoals();
                goals.WriteEmploymentToFile($"Установка PathPointer!{goals.GetLastCode}!1!{DateTime.Now.ToShortDateString()}");
            }
        }

        public static void CheckAllFiles() {
            CheckForDirectory();
            CheckForCommon();
            CheckForFile(AchivementsFile);
            CheckForFile(GamesList);
            CheckForCodes();
            CheckForEmployments("Business");
            CheckForEmployments("Goals");
            CheckForEmployments("Rest");
            CheckForEmployments("Fun");
            CheckForEfficiency();
        }

        private static void CheckForDirectory() {
            if (!Directory.Exists(Management.GetPath())) {
                Directory.CreateDirectory(Management.GetPath());
                FirstLaunch = true;
            }
            if (!Directory.Exists(Management.GetPath("Employments", true))) Directory.CreateDirectory(Management.GetPath("Employments", true));
            if (!Directory.Exists(Management.GetPath("Employments\\Archive", true))) Directory.CreateDirectory(Management.GetPath("Employments\\Archive", true));

        }

        private static void CheckForCommon() {
            if (!File.Exists(Management.GetPath("Common"))) FillCommonFile();
        }

        private static void CheckForFile(string filePath){
            if (!File.Exists(filePath)) using (File.Create(filePath)) { }        
        }

        public static void FillCommonFile(string statsCheckRange = "3", string weekFunHrs = "14", string sleepHrBegin = "0", 
            string sleepHrEnd = "9", string hrsToRest = "4", string hrsToWork = "1", string SoftMotiv = "1", string HadrMotiv = "0", string stopGames = "0", string HrsToStopGames = "0") {

            CommonFileArray = new string[13];
            CommonFileArray[0] = "Common info:";
            CommonFileArray[1] = $"Week Number!{CurrentDateInfo.WeekNumber}!{DateTime.Now.Year}";
            CommonFileArray[2] = "User settings:";
            CommonFileArray[3] = $"Employment Check Range!{statsCheckRange}";
            CommonFileArray[4] = $"Week Fun Time!{weekFunHrs}";
            CommonFileArray[5] = $"Sleep Time Begin!{sleepHrBegin}";
            CommonFileArray[6] = $"Sleep Time End!{sleepHrEnd}";
            CommonFileArray[7] = $"Hours To Rest Notify!{hrsToRest}";
            CommonFileArray[8] = $"Hours To Work Notify!{hrsToWork}";
            CommonFileArray[9] = $"Soft Motivation!{SoftMotiv}";
            CommonFileArray[10] = $"Hard Motivation!{HadrMotiv}";
            CommonFileArray[11] = $"Stop Games!{stopGames}";
            CommonFileArray[12] = $"Hours To Stop Game!{HrsToStopGames}";

            File.WriteAllLines(Management.GetPath("Common"), CommonFileArray);
        }

        private static void CheckForEfficiency() {
            if (!File.Exists(Management.GetPath("Efficiency")))
            {
                using (File.Create(Management.GetPath("Efficiency"))) { }
                StatsManagement.AddNewWeekIntoEfficiency(2);
            }
        }

        private static void CheckForCodes() {
            if (!File.Exists(Management.GetPath("Employments\\Codes")))
            {
                string[] codesArray = new string[4];
                codesArray[0] = "Business!0";
                codesArray[1] = "Goals!0";
                codesArray[2] = "Rest!0";
                codesArray[3] = "Fun!0";
                File.WriteAllLines(Management.GetPath("Employments\\Codes"), codesArray);
            }
        }

        private static void CheckForEmployments(string filePath) {
            if (!File.Exists(Management.GetPath($"Employments\\{filePath}")))  using (File.Create(Management.GetPath($"Employments\\{filePath}"))) { } 
            if (!File.Exists(Management.GetPath($"Employments\\Archive\\{filePath}")))  using (File.Create(Management.GetPath($"Employments\\Archive\\{filePath}"))) { } 
        }

        public static void ResetProgram() {
            Directory.Delete(Management.GetPath(), true);
            CheckAllFiles();
            StatsManagement.WriteHoursFromSchedule();
        }

    }
}
