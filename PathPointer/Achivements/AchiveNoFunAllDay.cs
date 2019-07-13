using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class AchiveNoFunAllDay : Achivement
    {
        public override string AchivementName { get { return "Нет времени на развлечения"; } }
        public override string AchivementFileName { get { return "No Fun All Day"; } }

        public override string Description { get { return "Кому нужна личная жизнь, когда можно стать успешным?" +
                    "\nПодсказка:" +
                    "\nУказывайте вашу деятельность на протяжении всего дня, проопусков быть не должно"; } }

        public override Button ArrowToNextAchivement { get { return null; } }

        public override Achivement PreviousAchivement { get { return new AchiveAddFun(); } }

        public override void CheckCondition()
        {
            if (!IsAchived && PreviousAchivement.IsAchived)
            {
                int previousDayOfWeek = CurrentDateInfo.DayOfWeek == 1 ? 7 : CurrentDateInfo.DayOfWeek - 1;
                dayEfficiency = stats.FillStatsArray(1, previousDayOfWeek);

                for (int hr = 0; hr < dayEfficiency.Length; hr++) {
                    if (dayEfficiency[hr].EmpType == Texts.empFun || dayEfficiency[hr].EmpType == Texts.empTypeSkip) break;
                    if (hr == 23) DoneAchivement();
                }
            }
        }
    }
}
