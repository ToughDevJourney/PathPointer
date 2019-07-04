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
    public partial class MoreStat : Form
    {
        YearsStatsBusiness business = new YearsStatsBusiness();
        YearsStatsGoals goals = new YearsStatsGoals();
        YearsStatsRest rest = new YearsStatsRest();
        YearsStatsFun fun = new YearsStatsFun();

        public MoreStat()
        {
            InitializeComponent();
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
            ColorDataGridView(fun);
            SetFormText();
        }

        private void ColorDataGridView(YearStats yearStats) {
            int contrast = 30;

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
            SetProductiveText();
            lblBusinessHrsSpent.Text = $"Потрачено часов на неотложные дела: {business.MainEmploymentHrs}";

            lblFavRest.Text = $"Любимый вид отдыха \"{ReturnFavouriteRestName(rest)}\"";
            lblRestTimeSpent.Text = rest.MainEmploymentHrs.ToString();

            lblFavFun.Text = $"Любимое развлечение \"{ReturnFavouriteRestName(fun)}\""; 
            lblFunTimeSpent.Text = fun.MainEmploymentHrs.ToString();
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

    }

}

