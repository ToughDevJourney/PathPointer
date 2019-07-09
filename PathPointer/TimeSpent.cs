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
        Employments employments = new EmploymentsGoals();
        Tray tray = new Tray();
        public static BindingList<DataManagement> varCells;
        private static TimeSpent _timeSpent;
        private static int currentRange;


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

            currentRange = UserSettings.EmploymentCheckRange;

            for (int i = 1; i <= UserSettings.EmploymentCheckRange; i++)    //нахождение ближайшего часа, для которого у пользователя можно запросить деятельность
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
            employments = new EmploymentsBusiness();
            FillGrid();
        }

        public void BtnGoals_Click(object sender, EventArgs e)
        {
            employments = new EmploymentsGoals();
            FillGrid();
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            employments = new EmploymentsRest();
            FillGrid();
        }

        private void BtnFun_Click(object sender, EventArgs e)
        {
            employments = new EmploymentsFun();
            FillGrid();
        }

        public void FillGrid()
        {
            dataGridBusiness.DataSource = employments.FillGrid(ref varCells, true).DataSource;
            dataGridBusiness.Focus();
        }
        
        private void BtnReady_Click(object sender, EventArgs e)
        {
            string employmentName = dataGridBusiness.CurrentCell.Value.ToString();

            if (employmentName == "Другое") StatsManagement.WriteStats($"{employments.EmpType}!{Codes.anotherEmpCode}", currentRange);
            else {
                employments.SetEmploymentValuesByName(employmentName);
                StatsManagement.WriteStats($"{employments.EmpType}!{employments.Code}", currentRange);
                if (employments.EmpType == "Goals") CheckIsGoalDone();
            }
            MenuManagement.questCheck = false;  //ИСПРАВИТЬ
            UpdateMainMenuDGV();

            currentRange--;
            SetLabelValue();

            if (currentRange <= 0) {
                FileManagement.firstLaunch = false;
                tray.CheckNotifyNeed();
                this.Hide();
            }
        }

        private void CheckIsGoalDone() {
            string goalStatus;

            if ((employments.HoursGoal <= employments.HoursDone || employments.DateGoal < DateTime.Now) && employments.HoursGoal != 0)
            {
                goalStatus = employments.DateGoal.Day < DateTime.Now.Day ? "просрочена" : "достигнута";

                var result = MessageBox.Show($"Ваша цель \"{employments.Name}\" {goalStatus}" +
                    $"\nСделать из нее постоянную цель?", $"Цель {goalStatus}!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) employments.WriteEmploymentToFile($"{employments.Name} (постоянный)!{employments.GetLastCode}!0!{DateTime.Now.ToShortDateString()}");

                employments.DeleteEmpFromFile(employments.Name);
                FillGrid();
            }
        }

        private void UpdateMainMenuDGV() {
            MainMenu mainManu = MainMenu.CreateInstance(null);
            mainManu.DataGridDayOfWeek_CellClick(null, null);
            mainManu.DataGridBusiness.CurrentCell = mainManu.DataGridBusiness[DateTime.Now.Hour - (currentRange + 1), 0];
            mainManu.DataGridBusiness_CellClick(null, null);
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
