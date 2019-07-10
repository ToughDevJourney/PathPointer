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
    public partial class ShowGoals : Form
    {
        StatsManagement stats = new StatsManagement();
        EmploymentsGoals goals = new EmploymentsGoals();
        public static BindingList<DataManagement> varCells;
        private static int AverageGoalHoursThisWeek { get; set; }

        public ShowGoals()
        {
            InitializeComponent();
        }

        private void Goals_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void Goals_Load(object sender, EventArgs e)
        {
            DGVGoals.DataSource = goals.FillGrid(ref varCells).DataSource;
            DGVGoals.Focus();

            DGVGoals_CellClick(null,null);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = MainMenu.CreateInstance(this);
        }

        private void DGVGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            goals.SetEmploymentValuesByName(DGVGoals.CurrentCell.Value.ToString());
            GetAverageGoalsHoursThisWeek();
            SetFormText();
        }

        private void SetFormText() {
            lblPercentsDone.Text = GetPercentsDoneText();

            lblHoursDone.Text = $"Пройдено часов до цели: {goals.HoursDone.ToString()}";
            lblHoursGoal.Text = goals.HoursGoal != 0? $"Необходимо часов для выполнения цели: {goals.HoursGoal.ToString()}" : "";
            lblHoursPerDayToDone.Text = GetHoursPerDayToDoneText();
            lblAverageHoursADay.Text = GetAverageWeekHoursText();
        }

        private string GetPercentsDoneText() {
            double percentDone;
            string labelText;

            if (goals.HoursGoal == 0) labelText = "Постоянная цель";
            else if (goals.HoursGoal <= goals.HoursDone) labelText = "Цель выполнена";
            else {
                percentDone = Math.Round(((double)goals.HoursGoal / 100) * goals.HoursDone, 2);
                labelText = $"Цель выполнена на {percentDone}%";
            }
            return labelText;
        }

        private string GetHoursPerDayToDoneText()
        {
            double needHoursADay;
            int daysToDone;
            int needDays = (int)(goals.DateGoal - DateTime.Now).TotalDays;
            string labelText;

            if (AverageGoalHoursThisWeek != 0 && needDays != 0) {
                needHoursADay = (double)needDays / AverageGoalHoursThisWeek;
                if (needHoursADay <= 1) labelText = "У вас отлично получается, продолжайте в том же духе!";
                else {
                    needHoursADay++;
                    daysToDone = (int)((goals.HoursGoal - goals.HoursDone) / needHoursADay);
                    labelText = $"Если вы будете тратить на эту цель по {needHoursADay} часа в день," +
                        $"\nто достигните ее через {daysToDone} дней";
                }
            }
            else labelText = goals.HoursToSpendDescription;


            return labelText;
        }

        private void GetAverageGoalsHoursThisWeek() {
            DayEfficiency[] dayEfficiency;

            for (int dow = CurrentDateInfo.DayOfWeek; dow >= 1; dow--)
            {
                dayEfficiency = stats.FillStatsArray(1, dow);

                for (int hr = 0; hr < 24; hr++)
                {
                    if (dayEfficiency[hr].EmpType == goals.EmpType && dayEfficiency[hr].Code == goals.Code) AverageGoalHoursThisWeek++;
                }
            }
            if(AverageGoalHoursThisWeek != 0) AverageGoalHoursThisWeek /= CurrentDateInfo.DayOfWeek;
        }

        private string GetAverageWeekHoursText() {
            string labelText;
            int needDays;

            if (AverageGoalHoursThisWeek == 0)
            {
                labelText = "На этой неделе вы не уделили этой цели внимания";
            }
            else {
                needDays = (int)(goals.DateGoal - DateTime.Now).TotalDays;
                labelText = $"В среднем, на этой неделе, вы приближаетесь к цели на {AverageGoalHoursThisWeek} часа в день";
                if (goals.HoursGoal != 0) labelText += $",\nТакими темпами, вы достигните ее через {needDays} дня, поднажмите!";
            }

            return labelText;
        }


    }
}

