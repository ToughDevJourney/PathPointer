using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class UserSettings : Management
    {
       

        public static int EmploymentCheckRange { get; set; }
        public static int WeekFunTime { get; set; }
        public static int SleepTimeBegin { get; set; }
        public static int SleepTimeEnd { get; set; }
        public static int HoursToWorkNotify { get; set; }
        public static int HoursToRestNotify { get; set; }

        static UserSettings() {
            UpdateAllSettings();


            if (!File.Exists(FilePath)) using (File.Create(FilePath)) { };

        }

        public static void UpdateAllSettings() {
            EmploymentCheckRange = GetFileValue("Employment Check Range");
            WeekFunTime = GetFileValue("Week Fun Time");
            SleepTimeBegin = GetFileValue("Sleep Time Begin");
            SleepTimeEnd = GetFileValue("Sleep Time End");
            HoursToWorkNotify = GetFileValue("Hours To Work Notify");
            HoursToRestNotify = GetFileValue("Hours To Rest Notify");
        }

        private static int GetFileValue(string settingName) {
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


        public static void ShowGames(ComboBox GamesComboBox){
            SetPath("GamesList");
            if(!File.Exists(FilePath)) using (File.Create(FilePath)) { }
            GamesComboBox.Items.Clear();
            string[] gamesArr = File.ReadAllLines(FilePath);
            foreach (var line in gamesArr) GamesComboBox.Items.Add(line);
            GamesComboBox.Text = "";
        }

        public static void AddGame(string gameName) {
            if (!DataManagement.IsLineInFile(gameName, "GamesList")) DataManagement.WriteToFile(gameName, "GamesList");
            else MessageBox.Show("Игра с таким именем уже добавлена!", "Уже готово!");
        }

        public static void DelGame(string gameName)
        {
            DataManagement.DeleteLineFromFile(gameName, "GamesList");
        }

    }
}
