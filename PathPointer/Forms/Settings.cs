using System;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            UserSettings.ShowGames(CBGamesList);
            GetSettingsValues();
        }

        private void GetSettingsValues() {
            string sleepHrBegin = UserSettings.SleepTimeBegin < 10 ? $"0{UserSettings.SleepTimeBegin}:" : $"{UserSettings.SleepTimeBegin}:";
            string sleepHrEnd = UserSettings.SleepTimeBegin < 10 ? $"0{UserSettings.SleepTimeEnd}:" : $"{UserSettings.SleepTimeEnd}:";

            MTBSleepBegin.Text = FormatLines.TimeFormat(sleepHrBegin);
            MTBSleepEnd.Text = FormatLines.TimeFormat(sleepHrEnd);

            TBHrsToRest.Text = UserSettings.HoursToRestNotify.ToString();
            TBHrsToWork.Text = UserSettings.HoursToWorkNotify.ToString();

            TBGetStatsHrs.Text = UserSettings.EmploymentCheckRange.ToString();
            TBFunHrsPerWeek.Text = UserSettings.WeekFunTime.ToString();

            ChBMotivHints.Checked = UserSettings.MotivationalHints.ToString() == Codes.fileTrue ? true : false;
            ChBCloseGames.Checked = UserSettings.StopGames.ToString() == Codes.fileTrue ? true : false;

            TBHrsToStopGms.Text = UserSettings.HrsToStopGame.ToString();
        }

        private void BtnAddGame_Click(object sender, EventArgs e)
        {
            UserSettings.AddGame(CBGamesList, CBGamesList.Text);
            UserSettings.ShowGames(CBGamesList);
        }

        private void BtnRemoveGame_Click(object sender, EventArgs e)
        {
            UserSettings.DelGame(CBGamesList.Text);
            UserSettings.ShowGames(CBGamesList);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            string sleepHrBegin = FormatLines.ShortFormatTime(MTBSleepBegin.Text);
            string sleepHrEnd = FormatLines.ShortFormatTime(MTBSleepEnd.Text);
            string motivHints = ChBMotivHints.Checked == true ? "1" : "0";
            string closeGames = ChBCloseGames.Checked == true ? "1" : "0";
            string hrsToCloseGame = TBHrsToStopGms.Text;

                FileManagement.FillCommonFile(TBGetStatsHrs.Text, TBFunHrsPerWeek.Text, sleepHrBegin, sleepHrEnd, TBHrsToRest.Text, //обновление настроек
                TBHrsToWork.Text, motivHints, closeGames, hrsToCloseGame);

            BtnBack_Click(null, null);
        }

        private void CheckFormat(object sender, EventArgs e) {
            MaskedTextBox time = (MaskedTextBox)sender;
            time.Text = FormatLines.TimeFormat(time.Text);
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Вы уверены, что хотите сбросить программу?\nВся ваша статистика будет утеряна!", "Вы уверены?", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                FileManagement.ResetProgram();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = MainMenu.CreateInstance(this);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void CheckNumberLine(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) e.Handled = true;
        }

        private void CheckTextBoxForEmptiness(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength == 0) textBox.Text = "1";
        }

    }
}
