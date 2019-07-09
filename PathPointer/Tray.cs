using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class Tray
    {
        static NotifyIcon trayIcon;
        StatsManagement stats = new StatsManagement();

        public Tray(NotifyIcon trayIcon = null) {
            if (trayIcon != null)
            {
                Tray.trayIcon = trayIcon;
                trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            }
        }

        public void CheckNotifyNeed() {
            Random rand = new Random();
            int hintNum;

            if (ShowNotify("Goals", UserSettings.HoursToRestNotify))
            {
                trayIcon.BalloonTipTitle = "Вы уже достаточно поработали";
                trayIcon.BalloonTipText = "Самое время вам сделать передышку!";

                trayIcon.ShowBalloonTip(10000);
            }
            else if (ShowNotify("Rest", UserSettings.HoursToWorkNotify))
            {
                trayIcon.BalloonTipTitle = "К сожалению, перерыв окончен";
                trayIcon.BalloonTipText = "Пора вернуться к работе!";

                trayIcon.ShowBalloonTip(10000);
            }
            else {
                hintNum = rand.Next(5);
                if (hintNum < Texts.MotivationalHints.GetLength(0)) {
                    trayIcon.BalloonTipTitle = Texts.MotivationalHints[hintNum, 0];
                    trayIcon.BalloonTipText = Texts.MotivationalHints[hintNum, 1];                 
                }
                trayIcon.ShowBalloonTip(15000);
            }
        }

        public bool ShowNotify(string empType, int hoursToNotify) {
            DayEfficiency[] currendDayStats = stats.FillStatsArray(1, CurrentDateInfo.DayOfWeek, true);
            DayEfficiency[] previousDayStats;
            int notifyHourCheck = DateTime.Now.Hour - hoursToNotify;

            if (CurrentDateInfo.DayOfWeek == 1) previousDayStats = stats.FillStatsArray(2, 7);
            else previousDayStats = stats.FillStatsArray(1, CurrentDateInfo.DayOfWeek, true);

            string checkingEmpType = "";
            int workInRow = 0;


            for (int i = DateTime.Now.Hour - 1; i > notifyHourCheck; i--) {

                if (i < 0) checkingEmpType = previousDayStats[24 - i].EmpType;
                else checkingEmpType = currendDayStats[i].EmpType;

                if (checkingEmpType == empType) workInRow++;
                else break;
            }

            if (workInRow == hoursToNotify) return true;
            else return false;
        }



        public void ScheduleBeginMessage() {
            string prevHrSched = StatsManagement.IsHourInSchedule(DateTime.Now.Hour - 1, CurrentDateInfo.DayOfWeek);
            string curHrSched = StatsManagement.IsHourInSchedule(DateTime.Now.Hour, CurrentDateInfo.DayOfWeek);
            string endSchedTime;

            if (prevHrSched == null && curHrSched != null) {

                endSchedTime = Management.GetValueByIndex(curHrSched, 2);  //вывод расписания
                endSchedTime = Management.GetValueByIndex(endSchedTime, CurrentDateInfo.DayOfWeek - 1, "/"); //вывод расписания для конкретного дня недели
                endSchedTime = endSchedTime.Substring(endSchedTime.IndexOf(" ") + 1);
                endSchedTime = Convert.ToInt32(endSchedTime) >= 10 ? $"{endSchedTime}:00" : $"0{endSchedTime}:00";
                curHrSched = Management.GetValueByIndex(curHrSched);

                trayIcon.BalloonTipIcon = ToolTipIcon.Info;
                trayIcon.BalloonTipTitle = "Расписание";
                trayIcon.BalloonTipText = $"{curHrSched} до {endSchedTime}";

                trayIcon.ShowBalloonTip(10000);
            }
        }

        public void ProductiveMessage() {
            DayEfficiency[] statsArr;
            string message;
            int GoalHours = 1;
            int FunHours = 1;

            for (int dow = 1; dow <= 7; dow++) {
                statsArr = stats.FillStatsArray(1, dow);
                for (int i = 0; i < statsArr.Length; i++) {                   
                    if (statsArr[i].EmpType == "Goals") GoalHours++;
                    else if (statsArr[i].EmpType == "Fun") FunHours++;
                }
            }

            if (FileManagement.firstLaunch == false)
            {
                if (GoalHours < FunHours) message = Texts.funMoreThenGoals;
                else if ((FunHours / GoalHours) > 0.80) message = Texts.sameFunAsGoals;
                else message = Texts.goalsMoreThenFun;
                trayIcon.BalloonTipTitle = "PathPointer запущен - полет нормальный";
                trayIcon.BalloonTipText = message;
            }
            else {
                trayIcon.BalloonTipTitle = "PathPoooooointer";
                trayIcon.BalloonTipText = "Добро пожаловать в увлекательное приключение на пути к лучшей жизни!";
            }
            trayIcon.ShowBalloonTip(10000);
        }
    }
}
