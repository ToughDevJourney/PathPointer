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
        }

        private void ChBCloseGames_CheckedChanged(object sender, EventArgs e)
        {

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
            string closeGames = ChBCloseGames.Checked == true ? "1" : "0";
            string hrsToCloseGame = TBHrsToStopGms.Text;

                FileManagement.FillCommonFile(TBGetStatsHrs.Text, TBFunHrsPerWeek.Text, sleepHrBegin, sleepHrEnd, TBHrsToRest.Text, //обновление настроек
                TBHrsToWork.Text, closeGames, hrsToCloseGame);

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
