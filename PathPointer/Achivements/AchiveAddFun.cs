using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class AchiveAddFun : Achivement
    {
        public override string AchivementName { get { return "Добавьте отдых"; } }
        public override string AchivementFileName { get { return "Add Fun"; } }

        public override string Description { get { return "Сомнительно достижение, но ладно"; } }

        public override Achivement PreviousAchivement { get { return null; } }

        public override void CheckCondition() {
            if (!IsAchived) DoneAchivement();
        }




    }
}
 