﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public partial class MoreStat : Form
    {
        YearsStatsBusiness business = new YearsStatsBusiness();
        YearsStatsGoals goals = new YearsStatsGoals();
        YearsStatsRest rest = new YearsStatsRest();
        YearsStatsFun fun = new YearsStatsFun();

        public MoreStat()
        {
            InitializeComponent();
            FillChart();
        }

        private void MoreStat_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = MainMenu.CreateInstance(this);
        }

        private void MoreStat_Load(object sender, EventArgs e)
        {
            DGVMoreStats.RowCount = 7;
            DGVMoreStats.ColumnCount = 52;
            ColorDataGridView(goals);
            SetFormText();
        }

        private void ColorDataGridView(YearStats yearStats) {
            int contrast = 30;

            int rowsCount = DGVMoreStats.Rows.Count;
            DGVMoreStats.Rows.Clear();
            DGVMoreStats.Rows.Add(rowsCount);

            for (int yw = 0; yw < 52; yw++)
            {
                for (int dow = 0; dow < 7; dow++)
                {
                    if (yearStats.yearEmpNum[dow, yw] > 0)
                    {
                        int colorCode = 200 - 30 * contrast;
                        colorCode = colorCode < 0 ? 0 : colorCode;
                        DGVMoreStats.Rows[dow].Cells[yw].Style.BackColor = yearStats.GetCellColor(colorCode);
                    }
                }

            }
        }


        private void SetFormText()
        {
            SetCloseToDreamText();
            lblYearGoalsHrs.Text = $"Потрачено на цели: {goals.spentHours} часов";

            SetProductiveText();
            lblBusinessHrsSpent.Text = $"Потрачено часов на неотложные дела: {business.MainEmploymentHrs}";

            lblFavRest.Text = $"Любимый вид отдыха \"{ReturnFavouriteRestName(rest)}\"";
            lblRestTimeSpent.Text = $"Потрачено часов на отдых: {rest.MainEmploymentHrs.ToString()}";

            lblFavFun.Text = $"Любимое развлечение \"{ReturnFavouriteRestName(fun)}\"";
            lblFunTimeSpent.Text = $"Потрачено часов на развелечения: {fun.MainEmploymentHrs.ToString()}";

            SetGoalPercentText();
            SetReachedGoals();
        }

        private void SetCloseToDreamText() {
            string goalName = Management.GetValueByIndex(goals.MainEmployment);
            string goalHrs = goals.MainEmploymentHrs.ToString();

            if (Management.GetValueByIndex(goals.MainEmployment, 2) == "0") lblCloseToDream.Text = $"На цель \"{goalName}\" вы потратили уже {goalHrs} часов";
            else lblCloseToDream.Text = $"Вы ближе к своей цели \"{goalName}\" уже на {goalHrs}";
        }

        private void SetProductiveText() {
            int productiveToday = goals.yearEmpNum[CurrentDateInfo.DayOfWeek - 1, 51];
            int productiveYesterday = CurrentDateInfo.DayOfWeek == 1 ? goals.yearEmpNum[6, 50] : goals.yearEmpNum[CurrentDateInfo.DayOfWeek - 2, 51];
            double productivePercent;
            if (productiveToday > productiveYesterday)
            {
                productivePercent = Math.Round(((double)productiveToday / (double)productiveYesterday - 1) * 100);
                lblProductive.Text = $"Сегодня вы продуктивнее, чем вчера на {productivePercent}%";
            }
            else if (productiveToday < productiveYesterday)
            {
                productivePercent = Math.Round(((double)productiveYesterday / (double)productiveToday - 1) * 100);
                lblProductive.Text = $"Вчера вы были продуктивнее на {productivePercent}%";
            }
            else lblProductive.Text = $"Ваша продуктивность такая же, как и вчера";
        }

        private string ReturnFavouriteRestName(YearStats restKind) {
            string restName = "";
            string restCode = Management.GetValueByIndex(restKind.MainEmployment, 1);
            string restType = restKind.EmpType;

            restName = StatsManagement.FindEmploymentByCode(restCode, restType);
            if (restName == "") restName = StatsManagement.FindEmploymentByCode(restCode, restType, true);
            if (restName != "") restName = Management.GetValueByIndex(restName);
            return restName;
        }

        private void SetReachedGoals() {
            Management.SetPath("Employments\\Archive\\Goals");
            string[] allGoals = File.ReadAllLines(Management.FilePath);

            if (allGoals.Length == 0) lblReachedGoals.Text = "Вы еще не достигли ни одной цели";
            else lblReachedGoals.Text = $"Вы достигли уже {allGoals.Length.ToString()} целей";

        }

        private void SetGoalPercentText() {
            string goalName = Management.GetValueByIndex(goals.MainEmployment);

            int hoursGoal = Convert.ToInt32(Management.GetValueByIndex(goals.MainEmployment, 2));
            double hoursDone = goals.MainEmploymentHrs;
            double goalPercentDone = 0;

            if (hoursGoal != 0)
            {
                goalPercentDone = Math.Round((hoursDone / 100) * hoursGoal, 2);
                lblGoalPercent.Text = $"Ваша мечта {goalName} стала реальностью уже на {goalPercentDone}%";
            }
            else lblGoalPercent.Text = $"Постоянная цель была создана {Management.GetValueByIndex(goals.MainEmployment, 3)}";
        }

        private void FillChart() {
            int index = ChartEmpRatio.Series[0].Points.AddXY("", goals.spentHours);
            ChartEmpRatio.Series[0].Points[index].Color = Color.LightGreen;

            index = ChartEmpRatio.Series[0].Points.AddXY("", business.MainEmploymentHrs);
            ChartEmpRatio.Series[0].Points[index].Color = Color.Blue;

            index = ChartEmpRatio.Series[0].Points.AddXY("", fun.MainEmploymentHrs);
            ChartEmpRatio.Series[0].Points[index].Color = Color.Red;

            index = ChartEmpRatio.Series[0].Points.AddXY("", rest.MainEmploymentHrs);
            ChartEmpRatio.Series[0].Points[index].Color = Color.Orange;
        }

        private void ShowYearStats(object sender, EventArgs e) {
            Button empType = (Button)sender;
            switch (empType.Tag) {
                case "Business":
                    ColorDataGridView(business);
                    break;
                case "Goals":
                    ColorDataGridView(goals);
                    break;
                case "Rest":
                    ColorDataGridView(rest);
                    break;
                case "Fun":
                    ColorDataGridView(fun);
                    break;
            }
        }
    }

}

