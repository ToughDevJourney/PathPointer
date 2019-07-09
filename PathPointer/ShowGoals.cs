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
        EmploymentsGoals goals = new EmploymentsGoals();
        public static BindingList<DataManagement> varCells;

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
            DGVGoals.DataSource = goals.FillGrid(ref varCells, true).DataSource;
            DGVGoals.Focus();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = MainMenu.CreateInstance(this);
        }

        private void dataGridBusiness_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            goals.FindEmploymentByName(DGVGoals.CurrentCell.Value.ToString());
        }


    }
}
