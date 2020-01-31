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
    public class FileManagement : Management
    {
        public static string[] CommonFileArray{ get; set; }
        public delegate void CheckFiles();
        public CheckFiles CheckAllFiles;

        public FileManagement() {           
            CheckAllFiles += CheckForDirectory;
            CheckAllFiles += CheckForCommon;
            CheckAllFiles += CheckForCodes;
            CheckAllFiles += CheckForBusiness;
            CheckAllFiles += CheckForFun;
            CheckAllFiles += CheckForGoals;
            CheckAllFiles += CheckForRest;
            CheckAllFiles += CheckForEfficiency;
        }

        private void CheckForDirectory() {
            SetPath();
            if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);
            if (!Directory.Exists(FilePath + "\\Employments")) Directory.CreateDirectory(FilePath + "\\Employments");
            if (!Directory.Exists(FilePath + "\\Employments\\Archive")) Directory.CreateDirectory(FilePath + "\\Employments\\Archive");

        }

        private void CheckForCommon(){
            if (!CheckFileExistance("Common")) FillCommonFileArray(); 
        }



        public void FillCommonFileArray(string statsCheckRange = "3", string weekFunHrs = "14", string sleepHrBegin = "0", 
            string sleepHrEnd = "9", string hrsToRest = "4", string hrsToWork = "1", string SoftMotiv = "1", string HadrMotiv = "0", string stopGames = "0", string HrsToStopGames = "0") {

            SetPath("Common");

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

            File.WriteAllLines(FilePath, CommonFileArray);
        }

        private void CheckForEfficiency() {
            if (!CheckFileExistance("Efficiency"))
            {
                using (File.Create(FilePath)) { }
                CurrentDateInfo.AddNewWeekIntoEfficiency(2);
            }
        }

        private void CheckForCodes() {
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

        private void CheckForBusiness() {
            if (!CheckFileExistance("Employments\\Business")) using (File.Create(FilePath)) { }
        }

        private void CheckForGoals()
        {
            if (!CheckFileExistance("Employments\\Goals"))
            {
                using (File.Create(FilePath)) { }
                DataManagement.WriteToFile($"Установка PathPointer!{DataManagement.Code}!1!{DateTime.Today.ToShortDateString()}", "Employments\\Goals");
            }
        }

        private void CheckForRest() {
            if (!CheckFileExistance("Employments\\Rest")) using (File.Create(FilePath)) { }

        }

        private void CheckForFun()
        {
            if (!CheckFileExistance("Employments\\Fun")) using (File.Create(FilePath)) { }
        }

        private bool CheckFileExistance(string fileStr) {
            SetPath(fileStr);
            if (File.Exists(FilePath)) return true;
            else return false;
        }


        public void ResetProgram() {
            SetPath();

            Directory.Delete(FilePath, true);
            CheckAllFiles();
            StatsManagement.WriteHoursFromSchedule();
        }

    }
}
