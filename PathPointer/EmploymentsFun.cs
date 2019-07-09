using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class EmploymentsFun : Employments
    {
        public override string EmpType { get { return "Fun"; } }
        public override int HoursGoal { get; set; }
        public override int HoursDone { get; set; }

        public EmploymentsFun(IEmploymentsOtherTypes otherEmployment = null)
        {
            if (otherEmployment != null) _otherEmployment = otherEmployment;
        }

        protected override void SetEmploymentValues(string fullName)
        {
            Name = Management.GetValueByIndex(fullName);
            Code = Management.GetValueByIndex(fullName, 1);

            HoursGoal = UserSettings.WeekFunTime;
            HoursDone = CountDoneHours(Code);

            TypeDescription = Texts.empFunType;
            HoursDescription = HoursGoal >= HoursDone ? $"Потрачено {HoursDone} из доступных {HoursGoal} часов" : $"Норма развлечений на этой неделе превышена на {HoursDone - HoursGoal} часов";
            HoursToSpendDescription = $"Каждый пол года вы тратите на развлечения {HoursGoal * 26} часов, это {(HoursGoal * 26) / 24} полных суток";
        }


    }
}
