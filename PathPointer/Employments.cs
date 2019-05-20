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
        int empType = 1;
        DataLists emp = new DataLists();
           //


        public Employments()
        {
            InitializeComponent();
        }

        private void Employments_Load(object sender, EventArgs e)
        {
            GoalsButton_Click(null,null);
        }

        private void BusinessButton_Click(object sender, EventArgs e)
        {
            dataGridBusiness.DataSource = emp.FillGrid("Business").DataSource;
            empType = 0;
        }

        private void GoalsButton_Click(object sender, EventArgs e)
        {
            dataGridBusiness.DataSource = emp.FillGrid("Goals").DataSource;
            empType = 1;

        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            dataGridBusiness.DataSource = emp.FillGrid("Rest").DataSource;
            empType = 2;
        }

        private void FunButton_Click(object sender, EventArgs e)
        {
              dataGridBusiness.DataSource = emp.FillGrid("Fun").DataSource;
       
            empType = 3;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddGoal goalForm = new AddGoal();
            goalForm.Show();
            this.Hide();
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

    }
}
