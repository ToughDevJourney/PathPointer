using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class EmploymentsBusiness : Employments
    {
        public override string EmpType { get { return Texts.empBusiness; } }
        public override Color CellColor { get { return Color.FromArgb(255, 184, 138, 174); } }
        public override int HoursGoal { get { return 0; } set { } }
        public override int HoursDone { get { return 0; } set { } }
        public string Schedule { get; set; }
        public DateTime LastUpdate { get; set; }

        public EmploymentsBusiness(IEmploymentsOtherTypes otherEmployment = null) {
            if (otherEmployment != null) _otherEmployment = otherEmployment;
        }

        protected override void SetEmploymentValues(string fullName)
        {
            Name = Management.GetValueByIndex(fullName);
            Code = Management.GetValueByIndex(fullName, 1);
            Schedule = Management.GetValueByIndex(fullName, 2);
            LastUpdate = Convert.ToDateTime(Management.GetValueByIndex(fullName, 3));

            TypeDescription = Texts.empBusinessType;
            HoursDescription = GetScheduleMessage(Schedule);
        }

        public string GetScheduleMessage(string schedule) {
            if (schedule == Codes.noSchedule) schedule = "Для этого дела нет расписания";
            else {
                schedule = Management.GetValueByIndex(schedule, CurrentDateInfo.DayOfWeek - 1, "/");    //вывод расписания конкретного дня
                if (schedule == Codes.noScheduleForThisDay) schedule = $"Расписание на сегодня: выходной";
                else schedule = $"Расписание на сегодня: {FormatLines.ShortTimeFormatToLong(schedule)}";
            }
            return schedule;
        }
    }
}
