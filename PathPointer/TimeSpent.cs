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
    public partial class TimeSpent : Form
    {
        public static string empType = "Goals";
        public static BindingList<DataManagement> varCells;

        public TimeSpent()
        {
            InitializeComponent();
        }

        private void BtnBusiness_Click(object sender, EventArgs e)
        {
            empType = "Business";
            FillGrid();
        }

        public void BtnGoals_Click(object sender, EventArgs e)
        {
            empType = "Goals";
            FillGrid();

        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            empType = "Rest";
            FillGrid();
        }

        private void BtnFun_Click(object sender, EventArgs e)
        {
            empType = "Fun";
            FillGrid();
        }

        public void FillGrid()
        {
            dataGridBusiness.DataSource = DataManagement.FillGrid(empType, ref varCells).DataSource;
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {

        }
    }
}
