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
        public static string empType = "Goals";
        public static BindingList<DataManagement> varCells;



        public Employments()
        {
            InitializeComponent();
        }

        private void Employments_Load(object sender, EventArgs e)
        {
            GoalsButton_Click(null, null);
        }

        private void BusinessButton_Click(object sender, EventArgs e)
        {
            empType = "Business";
            FillGrid();
        }

        public void GoalsButton_Click(object sender, EventArgs e)
        {
            empType = "Goals";
            FillGrid();

        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            empType = "Rest";
            FillGrid();
        }

        private void FunButton_Click(object sender, EventArgs e)
        {
            empType = "Fun";
            FillGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form empForm = new AddGoal();
            switch (empType)
            {
                case "Business":
                    empForm = new AddBusy();
                    break;
                case "Goals":
                    empForm = new AddGoal();
                    break;
                case "Rest":
                    empForm = new AddRest();
                    break;
                case "Fun":
                    empForm = new AddFun();
                    break;
            }

            empForm.Show();
            this.Hide();
        }

        public void FillGrid() {



            dataGridBusiness.DataSource = DataManagement.FillGrid().DataSource;




        }

        private void BackMain_Click(object sender, EventArgs e)
        {
            OpenMenu.ShowMenu();
            this.Hide();
        }

        private void Employments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void dataGridBusiness_KeyDown(object sender, KeyEventArgs e)
        {       

            if (e.KeyCode == Keys.Delete)
            {


                string cellVal = dataGridBusiness.Rows[dataGridBusiness.CurrentCell.RowIndex].Cells[dataGridBusiness.CurrentCell.ColumnIndex].Value.ToString();    //передача в cellVal значения выбранной ячейки
                varCells.RemoveAt(dataGridBusiness.CurrentCell.RowIndex);
                DataManagement.DeleteEmpFiles(cellVal);

                
            }
        }

        private void BtnHight_Click(object sender, EventArgs e)
        {

        }
    }
}
