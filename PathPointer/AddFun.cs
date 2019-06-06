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
    public partial class AddFun : Form
    {
        public AddFun()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string funName = DataManagement.checkEmploymentFormat(textName.Text);
            string funTime = textTime.Text;

            if (funTime == "" || Convert.ToInt32(funTime) > 24) funTime = "1";

            DataManagement.WriteEmpFiles($"{funName}!{DataManagement.Code}!{Convert.ToInt32(funTime)}", DataManagement.EmpType);
            CancelButton_Click(null, null);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Employments empForm = new Employments();
            empForm.Show();
            this.Hide();
        }

        private void AddFun_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void textTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) e.Handled = true;
        }
    }
}
