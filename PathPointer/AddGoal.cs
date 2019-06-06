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
    public partial class AddGoal : Form
    {
        DataManagement addGoal = new DataManagement();

        public AddGoal()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string goaltName = DataManagement.checkEmploymentFormat(textName.Text);
            string goalTime = textTime.Text;

            if (goalTime == "") goalTime = "0";

            DataManagement.WriteEmpFiles($"{goaltName}!{DataManagement.Code}!{Convert.ToInt32(goalTime)}!{datePicker.Text}", DataManagement.EmpType);        //запись цели в файл

            BtnCancel_Click(null, null);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Employments empForm = new Employments();
            empForm.Show();
            this.Hide();
        }

        private void AddGoal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if (datePicker.Value < DateTime.Now) {
                datePicker.Value = DateTime.Now;
            }
        }
    }
}
