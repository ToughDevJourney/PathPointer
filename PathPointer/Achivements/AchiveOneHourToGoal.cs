using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class AchiveOneHourToGoal : Achivement
    {
        public override string AchivementName { get { return "Продвиньтесь на один час к цели"; } }
        public override string AchivementFileName { get { return "One Hour To Goal"; } }

        public override string Description { get { return "Первый шаг сделан. Остлось еще 2704. Хорошего дня!"; } }

        public override Button ArrowToNextAchivement { get { return BtnHourGoalToCompleteGoal; } }

        public override Achivement PreviousAchivement { get { return new AchiveAddGoal(); } }

        public override void CheckCondition()
        {
            if (!IsAchived && PreviousAchivement.IsAchived) DoneAchivement();
        }
    }
}
