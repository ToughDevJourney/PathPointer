using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class Tray : Management
    {
        static NotifyIcon trayIcon; 

        public Tray(NotifyIcon trayIcon) {
            Tray.trayIcon = trayIcon;
            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
        }

        static public void CheckNotifyNeed() {
            Random rand = new Random();

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
                if (rand.Next(10) > -1) {
                    switch (rand.Next(5)) {
                        case (0):
                            trayIcon.BalloonTipTitle = "Пауло Коэльо";
                            trayIcon.BalloonTipText = "Дойдя до конца, люди смеются над страхами, мучившими их вначале.";
                            break;
                        case (1):
                            trayIcon.BalloonTipTitle = "Чак Паланик";
                            trayIcon.BalloonTipText = "Если ты не знаешь, чего хочешь, ты в итоге останешься с тем, чего точно не хочешь. ";
                            break;
                        case (2):
                            trayIcon.BalloonTipTitle = "Уолт Дисней";
                            trayIcon.BalloonTipText = "Это своего рода забава, делать невозможное.";
                            break;
                        case (3):
                            trayIcon.BalloonTipTitle = "Азим Премжи";
                            trayIcon.BalloonTipText = "Если люди не смеются над вашими целями, значит ваши цели слишком мелкие.";
                            break;
                        case (4):
                            trayIcon.BalloonTipTitle = "Стивен Каггва";
                            trayIcon.BalloonTipText = "Пробуйте и терпите неудачу, но не прерывайте ваших стараний.";
                            break;
                    }
                }
                trayIcon.ShowBalloonTip(15000);
            }
        }

        static public bool ShowNotify(string employment, int hoursToNotify) {
            string[] statsArr = StatsManagement.FillStatsArray(1, false);
            string emp = "";
            int workInRow = 0;

            for (int i = DateTime.Now.Hour - 1; i > DateTime.Now.Hour - (hoursToNotify+1); i--) {
                emp = GetValueByIndex(statsArr[i], CurrentDateInfo.DayOfWeek, ";");
                emp = GetValueByIndex(emp);
                if (emp == employment) workInRow++;            
            }

            if (workInRow == hoursToNotify) return true;
            else return false;
        }



        public void ScheduleBeginMessage() {
            string prevHrSched = StatsManagement.IsHourInSchedule(DateTime.Now.Hour - 1, CurrentDateInfo.DayOfWeek);
            string curHrSched = StatsManagement.IsHourInSchedule(DateTime.Now.Hour, CurrentDateInfo.DayOfWeek);
            string endSchedTime;

            if (prevHrSched == null && curHrSched != null) {

                endSchedTime = GetValueByIndex(curHrSched, 2);  //вывод расписания
                endSchedTime = GetValueByIndex(endSchedTime, CurrentDateInfo.DayOfWeek - 1, "/"); //вывод расписания для конкретного дня недели
                endSchedTime = endSchedTime.Substring(endSchedTime.IndexOf(" ") + 1);
                endSchedTime = Convert.ToInt32(endSchedTime) >= 10 ? $"{endSchedTime}:00" : $"0{endSchedTime}:00";
                curHrSched = GetValueByIndex(curHrSched);

                trayIcon.BalloonTipIcon = ToolTipIcon.Info;
                trayIcon.BalloonTipTitle = "Расписание";
                trayIcon.BalloonTipText = $"{curHrSched} до {endSchedTime}";

                trayIcon.ShowBalloonTip(10000);
            }
        }

        public static void ProductiveMessage() {
            string[] statsArr = StatsManagement.FillStatsArray(1, false);
            string emp;
            string message;
            int GoalHours = 1;
            int FunHours = 1;

            for (int i = 0; i < statsArr.Length; i++) {
                for (int dow = 1; dow <= 7; dow++) {
                    emp = GetValueByIndex(statsArr[i], dow, ";");
                    emp = GetValueByIndex(emp);
                    if (emp == "Goals") GoalHours++;
                    else if (emp == "Fun") FunHours++;
                }
            }

            if (GoalHours < FunHours) message = "На этой неделе вы потратили больше времени на развлечения," +
                                                  "\nчем на самосовершенствование, поднажмите!";
            else if ((FunHours / GoalHours) > 0.80) message = "Вы тратите на развлечения почти столько же времени, сколько на самосовершенствование, вы можете лучше!";

            else message = "Вы едите трудности на завтрак, так держать!";

            trayIcon.BalloonTipTitle = "PathPointer запущен - полет нормальный";
            trayIcon.BalloonTipText = message;

            trayIcon.ShowBalloonTip(10000);
        }




        void MotivationMessage() { }
    }
}
