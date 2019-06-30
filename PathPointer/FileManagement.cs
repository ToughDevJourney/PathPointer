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
        public static string[] CommonFileArray{ get; set; }
        public delegate void CheckFiles();
        public CheckFiles CheckAllFiles;

        public FileManagement() {           
            CheckAllFiles += CheckForDirectory;
            CheckAllFiles += CheckForCommon;
            CheckAllFiles += CheckForEfficiency;
            CheckAllFiles += CheckForCodes;
            CheckAllFiles += CheckForBusiness;
            CheckAllFiles += CheckForFun;
            CheckAllFiles += CheckForGoals;
            CheckAllFiles += CheckForRest;
            CheckAllFiles();
        }

        private void CheckForDirectory() {
            SetPath();
            if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);
            if (!Directory.Exists(FilePath + "\\Employments")) Directory.CreateDirectory(FilePath + "\\Employments");
            if (!Directory.Exists(FilePath + "\\Employments\\Archive")) Directory.CreateDirectory(FilePath + "\\Employments\\Archive");

        }

        private void CheckForCommon(){
            FillCommonFileArray();
            if (!CheckFileExistance("Common")) {
                File.WriteAllLines(FilePath, CommonFileArray);
            }
        }

        private void FillCommonFileArray() {
            CommonFileArray = new string[9];
            CommonFileArray[0] = "Common info:";
            CommonFileArray[1] = $"Week Number!{CurrentDateInfo.WeekNumber}";
            CommonFileArray[2] = "User settings:";
            CommonFileArray[3] = "Employment Check Range!1";
            CommonFileArray[4] = "Week Fun Time!7";
            CommonFileArray[5] = "Sleep Time Begin!0";
            CommonFileArray[6] = "Sleep Time End!7";
            CommonFileArray[7] = "Hours To Rest Notify!4";
            CommonFileArray[8] = "Hours To Rest Notify!1";
            
        }

        private void CheckForEfficiency() {
            if (!CheckFileExistance("Efficiency"))
            {
                using (File.Create(FilePath)) { }
                for (int j = 1; j <= 2; j++) CurrentDateInfo.AddNewWeekIntoEfficiency();
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


    }
}
