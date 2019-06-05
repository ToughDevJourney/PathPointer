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
        public static string empType;
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
            empType = "Business";
            FillGrid();
        }

        public void BtnGoals_Click(object sender, EventArgs e)
        {
            empType = "Goals";
            FillGrid();
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            empType = "Rest";
            FillGrid();
        }

        private void BtnFun_Click(object sender, EventArgs e)
        {
            empType = "Fun";
            FillGrid();
        }

        public void FillGrid()
        {
            dataGridBusiness.DataSource = DataManagement.FillGrid($"Employments\\{empType}", ref varCells).DataSource;
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {

            string currentCellVal = dataGridBusiness.CurrentCell.Value.ToString();

            StatsManagement.WriteStats($"{empType}!{DataManagement.FindCode(currentCellVal)}", "Efficiency");
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
