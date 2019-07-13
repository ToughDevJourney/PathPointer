using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class AchiveAddRest : Achivement
    {
        public override string AchivementName { get { return "Добавьте вид отдыха"; } }
        public override string AchivementFileName { get { return "Add Rest"; } }

        public override string Description { get { return "Ыааааааааа... Люблю запах тяжелого труда после отдыха"; } }

        public override Button ArrowToNextAchivement { get { return BtnAddRestToNoRestAllDay; } }

        public override Achivement PreviousAchivement { get { return null; } }

        public override void CheckCondition()
        {
           
        }
    }
}
