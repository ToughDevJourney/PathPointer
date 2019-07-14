using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    class YearsStatsBusiness : YearStats
    {
        public override string EmpType{ get { return "Business"; } }


        protected override bool CountHours(DayEfficiency employment) {
            MainEmploymentHrs++;
            return true;
        }

        public override Color GetCellColor(int colorCode) {
            int red;
            int green;
            int blue;

            CheckColorCode(out red, out green, out blue, colorCode, business.CellColor);

            return Color.FromArgb(255, red, green, blue);
        }
    }
}
