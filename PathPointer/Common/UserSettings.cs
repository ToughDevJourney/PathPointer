using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    static class UserSettings
    {
        private static string GamesListFileName { get { return "GamesList"; } }
        private static string SettingsFileName { get { return "Common"; } }
        public static int EmploymentCheckRange { get; set; }
        public static int WeekFunTime { get; set; }
        public static int SleepTimeBegin { get; set; }
        public static int SleepTimeEnd { get; set; }
        public static int HoursToWorkNotify { get; set; }
        public static int HoursToRestNotify { get; set; }
        public static int MotivationalHints { get; set; }
        public static bool StopGames { get; set; }
        public static int HrsToStopGame { get; set; }
        private static int AlreadyPlayedHrs { get; set; }

        static UserSettings() {
            UpdateAllSettings();        
        }

        public static void UpdateAllSettings() {
            EmploymentCheckRange = FileManagement.firstLaunch ? 1 : GetSettingValue("Employment Check Range");
            WeekFunTime = GetSettingValue("Week Fun Time");
            SleepTimeBegin = GetSettingValue("Sleep Time Begin");
            SleepTimeEnd = GetSettingValue("Sleep Time End");
            MotivationalHints = GetSettingValue("Motivational Hints");
            HoursToWorkNotify = GetSettingValue("Hours To Rest Notify");
            HoursToRestNotify = GetSettingValue("Hours To Work Notify");
            StopGames = GetSettingValue("Stop Games") == 1 ? true : false;
            HrsToStopGame = GetSettingValue("Hours To Stop Game");
        }

        private static int GetSettingValue(string settingName) {
            int value = 1;

            string[] commonFileArr = File.ReadAllLines(Management.GetPath(SettingsFileName));
            for (int i = 0; i < commonFileArr.Length; i++)
            {
                if (Management.GetValueByIndex(commonFileArr[i]) == settingName)
                {
                    value = Convert.ToInt32(Management.GetValueByIndex(commonFileArr[i], 1));
                    break;
                }
            }
            
            return value;
        }


        public static void ShowGames(ComboBox GamesComboBox) {
            GamesComboBox.Items.Clear();
            string[] gamesArr = File.ReadAllLines(Management.GetPath(GamesListFileName));
            foreach (var line in gamesArr) GamesComboBox.Items.Add(line);
            GamesComboBox.Text = "";
        }

        public static void AddGame(ComboBox GamesComboBox, string gameName) {
            bool gameAlreadyAdded = false;
            foreach (string line in GamesComboBox.Items) {
                if (line == gameName) gameAlreadyAdded = true;
            }

            if (gameAlreadyAdded) MessageBox.Show("Игра с таким именем уже добавлена!", "Уже готово!");
            else DataManagement.WriteLineToFile(gameName, GamesListFileName);
        }

        public static void DelGame(string gameName)
        {
            DataManagement.DeleteLineFromFile(gameName, "GamesList");
        }

        public static void CloseGame(){
            string[] gamesArr = File.ReadAllLines(Management.GetPath(GamesListFileName));
            bool processWasFound = false;

            foreach (string gameName in gamesArr) {
            Process[] games = Process.GetProcessesByName(gameName);

                if (games.Length != 0) processWasFound = true;

                foreach (Process game in games)
                {                   
                    if(AlreadyPlayedHrs == HrsToStopGame)
                    { 
                        game.Kill();
                        game.WaitForExit();
                        game.Dispose();
                        AlreadyPlayedHrs = 0;
                    }
                    AlreadyPlayedHrs++;
                }               
            }

            if (processWasFound == false) AlreadyPlayedHrs = 0; //если пользователь сам вышел из игры
        }


    }
}
