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
        EmploymentsRest rest = new EmploymentsRest();
        public AddRest()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string restName = rest.CheckEmploymentFormat(textName.Text);


            if (restName == "")
            {
                MessageBox.Show("Пожалуйста, введите название", "Отдыхать еще рано");
            }
            else
            {
                rest.WriteEmploymentToFile($"{restName}!{rest.GetLastCode}");
                BtnCancel_Click(null, null);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MenuManagement.ShowForm(this, new AddEmployments());
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
