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
            string funName = DataManagement.CheckEmploymentFormat(textName.Text);


            if (funName == "")
            {
                MessageBox.Show("Не сочтите за труд, введите название развлечения", "Телепатия появится в следующих обновлениях");
            }
            else
            {
                DataManagement.WriteToFile($"{funName}!{DataManagement.Code}", DataManagement.EmpType);
                CancelButton_Click(null, null);
            }
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
