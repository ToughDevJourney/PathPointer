using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public partial class TimeSpent : Form
    {
        private static string empType;
        private static int currentRange = UserSettings.EmploymentCheckRange;

        public string EmpType {
            get {
                return empType;
            }
            set {
                empType = value;
                FillGrid();
            }
        }
        public static BindingList<DataManagement> varCells;
        private static TimeSpent _timeSpent;

        private TimeSpent() {
            InitializeComponent();
            TopMost = true;
        }
        public static TimeSpent CreateInstance()
        {
            if (_timeSpent == null)
            {
                _timeSpent = new TimeSpent();
            }
            return _timeSpent;
        }

        private void TimeSpent_Load(object sender, EventArgs e)
        {
            BtnGoals_Click(null, null);
            for (int i = 1; i <= UserSettings.EmploymentCheckRange; i++)//нахождение ближайшего часа, для которого у пользователя можно запросить деятельность
            {
                if (StatsManagement.CheckIsHourAvailable(i)) currentRange = i;                
                else break;
            }
            SetLabelValue();
        }

        private void SetLabelValue() {
            string hourType;
            if (currentRange == 1) hourType = "час";
            else if (currentRange <= 4) hourType = "часа";
            else hourType = "часов";

            lblPrevHour.Text = $"Чем вы занимались {currentRange} {hourType} назад?";
        }

        private void BtnBusiness_Click(object sender, EventArgs e)
        {
            EmpType = "Business";
        }

        public void BtnGoals_Click(object sender, EventArgs e)
        {
            EmpType = "Goals";
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            EmpType = "Rest";
        }

        private void BtnFun_Click(object sender, EventArgs e)
        {
            EmpType = "Fun";
        }

        public void FillGrid()
        {
            dataGridBusiness.DataSource = DataManagement.FillGrid($"Employments\\{EmpType}", ref varCells, true).DataSource;
            dataGridBusiness.Focus();
        }
        
        private void BtnReady_Click(object sender, EventArgs e)
        {
            string currentCellVal = dataGridBusiness.CurrentCell.Value.ToString();
            if (currentCellVal == "Другое") StatsManagement.WriteStats($"{EmpType}!0", currentRange);
            else StatsManagement.WriteStats($"{EmpType}!{StatsManagement.FindCode(currentCellVal, EmpType)}", currentRange);
            MenuManagement.questCheck = false;

            currentRange--;
            SetLabelValue();
            if (currentRange <= 0) this.Hide();
        }

        private void TimeSpent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }


    }
}
