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
            DataManagement.WriteEmpFiles($"{textName.Text}!{DataManagement.GetCode()}!{Convert.ToInt32(textTime.Text)}");
            BtnCancel_Click(null, null);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Employments empForm = new Employments();
            empForm.Show();
            this.Hide();
        }
    }
}
