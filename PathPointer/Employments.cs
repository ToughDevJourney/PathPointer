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
            BtnGoals_Click(null, null);
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
            dataGridBusiness.DataSource = DataManagement.FillGrid(empType, ref varCells).DataSource;  
        }

        private void BackMain_Click(object sender, EventArgs e)
        {
            
            MenuManagement.ShowMenu(this);

        }
        
        private void dataGridBusiness_KeyDown(object sender, KeyEventArgs e)
        {
            string cellVal = dataGridBusiness.Rows[dataGridBusiness.CurrentCell.RowIndex].Cells[dataGridBusiness.CurrentCell.ColumnIndex].Value.ToString();    //передача в cellVal значения выбранной ячейки

            if (e.KeyCode == Keys.Delete)
            {
                var result = MessageBox.Show($"Вы уверены, что хотите удалить \"{cellVal}\"", "Вы уверены?", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    varCells.RemoveAt(dataGridBusiness.CurrentCell.RowIndex);
                    DataManagement.DeleteEmpFiles(cellVal);
                } 
            }


            FillGrid();
        }



        private void dataGridBusiness_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataManagement.EditEmpFiles(dataGridBusiness.CurrentCell.Value.ToString(), dataGridBusiness.CurrentCell.RowIndex);  //изменение текущей строки
        }

        private void Employments_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            MenuManagement.HideForm(this, e);
        }

    }
}
