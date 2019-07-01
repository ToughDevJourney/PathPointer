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
        FileManagement fileManagement = new FileManagement();

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
            UserSettings.AddGame(CBGamesList.Text);
            UserSettings.ShowGames(CBGamesList);
        }

        private void BtnRemoveGame_Click(object sender, EventArgs e)
        {
            UserSettings.DelGame(CBGamesList.Text);
            UserSettings.ShowGames(CBGamesList);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            string sleepHrBegin = LinesFormat.ShortFormatTime(MTBSleepBegin.Text);
            string sleepHrEnd = LinesFormat.ShortFormatTime(MTBSleepEnd.Text);
            string softMotiv = ChBSoftMotiv.Checked == true ? "1" : "0";
            string hardMotiv = ChBHardMotiv.Checked == true ? "1" : "0";
            string closeGames = ChBCloseGames.Checked == true ? "1" : "0";
            string hrsToCloseGame = TBHrsToStopGms.Text;


            fileManagement.FillCommonFileArray(TBGetStatsHrs.Text, TBFunHrsPerWeek.Text, sleepHrBegin, sleepHrEnd, TBHrsToRest.Text, //обновление настроек
                TBHrsToWork.Text, softMotiv, hardMotiv, closeGames, hrsToCloseGame);

            BtnBack_Click(null, null);
        }

        private void CheckFormat(object sender, EventArgs e) {
            MaskedTextBox time = (MaskedTextBox)sender;
            time.Text = LinesFormat.TimeFormat(time.Text);
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Вы уверены, что хотите сбросить программу?\nВся ваша статистика будет утеряна!", "Вы уверены?", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                fileManagement.ResetProgram();
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

        private void ChBMotivHints_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBMotivHints.Checked == true)
            {
                ChBHardMotiv.Checked = true;
                ChBSoftMotiv.Checked = true;
            }
            else {
                ChBHardMotiv.Checked = false;
                ChBSoftMotiv.Checked = false;
            }
        }

        private void AreAllMotivCheckBoxesEnabled(object sender, EventArgs e) {
            if (ChBHardMotiv.Checked == true && ChBSoftMotiv.Checked == true) ChBMotivHints.Checked = true;
            else if (ChBHardMotiv.Checked == false && ChBSoftMotiv.Checked == false) ChBMotivHints.Checked = false;
        }

        private void CheckTextBoxForEmptiness(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength == 0) textBox.Text = "1";
        }

    }
}
