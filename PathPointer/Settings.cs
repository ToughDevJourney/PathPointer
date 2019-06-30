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

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
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

        }
    }
}
