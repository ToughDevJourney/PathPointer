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
        static int empType;




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
            empType = 0;
            FillGrid();
        }

        public void GoalsButton_Click(object sender, EventArgs e)
        {
            empType = 1;
            FillGrid();

        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            empType = 2;
            FillGrid();
        }

        private void FunButton_Click(object sender, EventArgs e)
        {
            empType = 3;
            FillGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form empForm = new AddGoal();
            switch (empType)
            {
                case 0:
                    empForm = new AddBusy();
                    break;
                case 1:
                    empForm = new AddGoal();
                    break;
                case 2:
                    empForm = new AddRest();
                    break;
                case 3:
                    empForm = new AddFun();
                    break;
            }

            empForm.Show();
            this.Hide();
        }

        public void FillGrid() {        
            switch (empType)
            {
                case 0:
                    dataGridBusiness.DataSource = DataManagement.FillGrid("Business").DataSource;
                    break;
                case 1:
                    dataGridBusiness.DataSource = DataManagement.FillGrid("Goals").DataSource;

                    break;
                case 2:
                    dataGridBusiness.DataSource = DataManagement.FillGrid("Rest").DataSource;
                    break;
                case 3:
                    dataGridBusiness.DataSource = DataManagement.FillGrid("Fun").DataSource;
                    break;
            }

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
        {       //удалить строку во время выполнения метода
            MessageBox.Show("yeah?");
            if (e.KeyCode == Keys.Delete)   //ЗАНЯТЬСЯ ЭТИМ ЗАВТРА
            {
                string cellVal = dataGridBusiness.Rows[dataGridBusiness.CurrentCell.RowIndex].Cells[dataGridBusiness.CurrentCell.ColumnIndex].Value.ToString();    //передача в cellVal значения выбранной ячейки
                DataManagement.DeleteEmpFiles(cellVal);
            }
        }
    }
}
