using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class EmploymentsGoals : Employments
    {
        public override string EmpType { get { return Texts.empGoals; } }
        public override int HoursGoal { get; set; }
        public override int HoursDone { get; set; }

        public EmploymentsGoals(IEmploymentsOtherTypes otherEmployment = null)
        {
            if (otherEmployment != null) _otherEmployment = otherEmployment;
        }

        protected override void SetEmploymentValues(string fullName)
        {
            Name = Management.GetValueByIndex(fullName);
            Code = Management.GetValueByIndex(fullName, 1);
            HoursGoal = Convert.ToInt32(Management.GetValueByIndex(fullName, 2));
            DateGoal = Convert.ToDateTime(Management.GetValueByIndex(fullName, 3));

            HoursDone = CountDoneHours(Code, HoursGoal);
            TypeDescription = Texts.empGoalType;
            HoursDescription = GetHoursToSpendMessage(HoursGoal, HoursDone);
            HoursToSpendDescription = GetSpentHoursMessage(HoursGoal, HoursDone, DateGoal);
        }


        public void TurnGoalIntoConst(int goalCode)
        {
            string[] goalsFile = File.ReadAllLines(FilePath);
            string goalName = Management.GetValueByIndex(goalsFile[goalCode]);

            goalsFile[goalCode] = $"{goalName}!{Management.GetValueByIndex(goalsFile[goalCode], 1)}!0!{Management.GetValueByIndex(goalsFile[goalCode], 3)}!";

            File.WriteAllLines(FilePath, goalsFile);
            WriteEmploymentToFile(goalName, true);
            DeleteEmpFromFile(goalName);
        }

        public static string GetHoursToSpendMessage(int hoursGoal, int doneHours)
        {
            string message;

            if (hoursGoal == 0) message = $"На эту цель вы потратили уже {doneHours} часов!";
            else if (hoursGoal <= doneHours) message = $"Цель выполнена, на ее выполнение вы потратили {hoursGoal} часов!" +
                    $"\nНо не спешите расслабляться, у вас еще много дел впереди!";
            else message = $"Выполнено {doneHours} из {hoursGoal} часов";

            return message;
        }

        public static string GetSpentHoursMessage(int hoursGoal, int doneHours, DateTime dateGoal) {
            string message;
            int needDays = (int)(dateGoal - DateTime.Now).TotalDays;

            if (hoursGoal > doneHours && hoursGoal != 0)
            {
                if (needDays < 0) message = "Увы, время вышло, старайтесь лучше в следующий раз";
                else if (needDays == 0 && 24 - DateTime.Now.Hour >= hoursGoal - doneHours) message = "Цель должна быть выполнена уже сегодня! Спешите!";
                else if ((needDays == 0 && 24 - DateTime.Now.Hour < hoursGoal - doneHours) || (needDays * 24 - (hoursGoal - doneHours) < 0)) message = "Увы, но даже если вы возьметесь за дело прямо сейчас, уже не успеете :(";
                else message = $"В среднем, чтобы достичь этой цели до {dateGoal.ToShortDateString()}, вы должны тратить по {(hoursGoal - doneHours) / needDays} часов в сутки";
            }
            else if (hoursGoal == 0) message = $"Постоянная цель, создана {dateGoal.ToShortDateString()}";
            else message = $"Цель выполнена {dateGoal.ToLongDateString()}";
            return message;
        }



        public void GetReadyPercent()
        {

        }


    }
}
