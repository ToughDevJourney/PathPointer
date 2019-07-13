using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class AchiveAddGoal : Achivement
    {
        public override string AchivementName { get { return "Добавьте цель"; } }
        public override string AchivementFileName { get { return "Add Goal"; } }

        public override string Description { get { return "Вот это уже разговор"; } }

        public override Achivement PreviousAchivement { get { return null; } }

        public override void CheckCondition()
        {

        }
    }
}
