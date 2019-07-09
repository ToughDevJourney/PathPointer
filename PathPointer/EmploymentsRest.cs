using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class EmploymentsRest : Employments
    {
        public override string EmpType { get { return "Rest"; } }
        public override int HoursGoal { get { return 0; } set { } }
        public override int HoursDone { get { return 0; } set { } }

        public EmploymentsRest(IEmploymentsOtherTypes otherEmployment = null)
        {
            if (otherEmployment != null) _otherEmployment = otherEmployment;
        }

        protected override void SetEmploymentValues(string fullName)
        {
            Name = Management.GetValueByIndex(fullName);
            Code = Management.GetValueByIndex(fullName, 1);

            TypeDescription = Texts.empRestType;
        }
    }
}
