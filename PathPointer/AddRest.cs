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
    public partial class AddRest : Form
    {
        public AddRest()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string restName = DataManagement.CheckEmploymentFormat(textName.Text);
            string restTime = textTime.Text;

            if (restName == "")
            {
                MessageBox.Show("Пожалуйста, введите название", "Отдыхать еще рано");
            }
            else
            {
                if (restTime == "" || Convert.ToInt32(restTime) > 24) restTime = "0";

                DataManagement.WriteEmpFiles($"{restName}!{DataManagement.Code}!{Convert.ToInt32(restTime)}", DataManagement.EmpType);

                BtnCancel_Click(null, null);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Employments empForm = new Employments();
            empForm.Show();
            this.Hide();
        }

        private void AddRest_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void textTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }


    }
}
