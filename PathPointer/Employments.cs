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
    public partial class Employments : Form
    {
        public Employments()
        {
            InitializeComponent();
        }

        private void BackMain_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
            this.Hide();
        }

        private void Employments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BusinessButton_Click(object sender, EventArgs e)
        {

        }
    }
}
