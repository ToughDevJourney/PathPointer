using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class AchiveNoRestWholeDay : Achivement
    {
        public override string AchivementName { get { return "Не отдохните ни разу за день"; } }
        public override string AchivementFileName { get { return "No Rest all Day"; } }

        public override string Description { get { return "Отсутствие отдыха - это не очень хорошо, но вот вам утешительный приз" +
                    "\nПодсказка:" +
                    "\nУказывайте вашу деятельность на протяжении всего дня," +
                    "\nпроопусков быть не должно, а сон не учитывается";
            } }

        public override Button ArrowToNextAchivement { get { return BtnAddRest; } }

        public override Achivement PreviousAchivement { get { return new AchiveAddRest(); } }

        public override void CheckCondition()
        {
            if (!IsAchived && PreviousAchivement.IsAchived)
            {
                int previousDayOfWeek = CurrentDateInfo.DayOfWeek == 1 ? 7 : CurrentDateInfo.DayOfWeek - 1;
                dayEfficiency = stats.FillStatsArray(1, previousDayOfWeek);

                for (int hr = 0; hr < dayEfficiency.Length; hr++)
                {
                    if (dayEfficiency[hr].EmpType == Texts.empFun || dayEfficiency[hr].EmpType == Texts.empTypeSkip || (dayEfficiency[hr].EmpType == Texts.empRest && dayEfficiency[hr].Code != Codes.sleep)) break;
                    if (hr == 23) DoneAchivement();
                }
            }
        }
    }
}
