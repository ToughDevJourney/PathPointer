using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class AchiveCompleteGoal : Achivement
    {
        public override string AchivementName { get { return "Выполните цель"; } }
        public override string AchivementFileName { get { return "Complete Goal"; } }

        public override string Description { get { return "Вы уже чувствуете, как становитесь лучше?"; } }

        public override Button ArrowToNextAchivement { get { return null; } }

        public override Achivement PreviousAchivement { get { return new AchiveOneHourToGoal(); } }

        public override void CheckCondition()
        {
            if (!IsAchived && PreviousAchivement.IsAchived) DoneAchivement();
        }
    }
}
