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
            DataManagement.WriteEmpFiles($"{textName.Text}!{DataManagement.Code}!{Convert.ToInt32(textTime.Text)}!{datePicker.Text}");        //запись цели в файл
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
    }
}
