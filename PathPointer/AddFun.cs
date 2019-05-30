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
            DataManagement.WriteEmpFiles($"{textName.Text}!{DataManagement.Code}!{Convert.ToInt32(textTime.Text)}", DataManagement.EmpType);
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
    }
}
