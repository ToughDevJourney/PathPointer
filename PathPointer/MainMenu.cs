using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PathPointer
{
    public partial class MainMenu : Form
    {

        public static int pickedDayOfWeek;
        public static BindingList<StatsManagement> statCells;


        public MainMenu()
        {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            const int miliseconds = 1000;
            const int minutes = 60;
            int interval;

            FileManagement.CheckAllFiles();
            StatsManagement.CheckWeekRelevance();
            StatsManagement.WriteHoursFromSchedule();
            MenuManagement.AreAllFormsClosed = false;

            FillDaysOfWeek();
            DataGridDayOfWeek_CellClick(null, null);
            DataGridBusiness.CurrentCell = DataGridBusiness[DateTime.Now.Hour - 1, 0];
            DataGridBusiness_CellClick(null, null);

            DateTime dateTime1 = new DateTime();   //"будильник" на вызов формы в ближайшие "00" минут
            dateTime1 = DateTime.Now;
            dateTime1 = dateTime1.AddHours(1).AddMinutes(-dateTime1.Minute);
            interval = dateTime1.Subtract(DateTime.Now).Minutes * minutes * miliseconds;



            TimerHour.Interval = interval == 0 ? 1 : interval;
            if (StatsManagement.CheckIsHourAvailable()) ShowQuest();
        }


        private void MainMenu_Shown(object sender, EventArgs e)
        {
        }


        private void EmployButton_Click(object sender, EventArgs e)
        {
            Employments employments = new Employments();
            MenuManagement.AreAllFormsClosed = false;
            employments.Show();

            this.Hide();
        }


        private void BtnMoreStats_Click(object sender, EventArgs e)
        {
        }

        private void pathPointerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrayIcon_MouseDoubleClick(null,null);
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MenuManagement.TrayShow(this);
        }



        private void TimerHour_Tick(object sender, EventArgs e)
        {
            const int interval60Mins = 60 * 60 * 1000;
            TimerHour.Interval = interval60Mins;
            FileManagement.CheckAllFiles();
            StatsManagement.CheckWeekRelevance();
            if (StatsManagement.CheckIsHourAvailable()) ShowQuest();
        }

        public static void ShowQuest()
        {

            TimeSpent form = TimeSpent.CreateInstance();
            form.Show();

        }

        private void FillDaysOfWeek() {     //заполнение таблицы дней недели с учетом сдвига
            DataGridDayOfWeek.RowCount = 1;
            DataGridDayOfWeek.ColumnCount = 7;
            int dayOfWeek = 7;

            for (int i = 0; i < 7; i++)
            {
                dayOfWeek--;
                DataGridDayOfWeek.Rows[0].Cells[i].Value = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.AddDays(-dayOfWeek).DayOfWeek);
            }
            DataGridDayOfWeek.CurrentCell = DataGridDayOfWeek[6,0];


        }

        private void DataGridDayOfWeek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pickedDayOfWeek = Convert.ToInt32(DateTime.Now.AddDays(-(6 - DataGridDayOfWeek.CurrentCell.ColumnIndex)).DayOfWeek);
            StatsManagement.FillGrid(ref DataGridBusiness);  //вывод деятельности за 24 часа выбранного дня недели
            DataGridBusiness_CellClick(null, null);
            PointToDayOfWeek(DataGridDayOfWeek.CurrentCell.ColumnIndex);
            DataGridDayOfWeek.ClearSelection();
        }

        public void DataGridBusiness_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StatsManagement.DisplayMainStats(ref lblEmployName, ref lblEmployType, ref lblDoneHours, ref lblMustSpend, DataGridBusiness.CurrentCell.ColumnIndex);
            if (DataGridBusiness.CurrentCell.ColumnIndex < 10) lblEmploymentHour.Text = $"0{DataGridBusiness.CurrentCell.ColumnIndex.ToString()}:00";
            else lblEmploymentHour.Text = $"{DataGridBusiness.CurrentCell.ColumnIndex.ToString()}:00";
            PointToBusiness(DataGridBusiness.CurrentCell.ColumnIndex);
            DataGridBusiness.ClearSelection();
        }

        private void PointToDayOfWeek(int index) {           
            dayOfWeekPointer.Rows.Clear();
            dayOfWeekPointer.ColumnCount = 7;
            dayOfWeekPointer.RowCount = 1;
            dayOfWeekPointer.Rows[0].Cells[index].Value = "↓";
        }
        private void PointToBusiness(int index) {
            businessPointer.Rows.Clear();
            businessPointer.ColumnCount = 24;
            businessPointer.RowCount = 1;
            businessPointer.Rows[0].Cells[index].Value = "↑";
        }


        public void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            MenuManagement.AreAllFormsClosed = true;
        }
    }
}
