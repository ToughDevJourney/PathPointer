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
            dataGridBusiness.DataSource = DataManagement.FillGrid($"Employments\\{EmpType}", ref varCells).DataSource;
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {
            string currentCellVal = dataGridBusiness.CurrentCell.Value.ToString();
            StatsManagement.WriteStats($"{EmpType}!{StatsManagement.FindCode(currentCellVal, EmpType)}");
            MenuManagement.questCheck = false;

            this.Hide();
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
