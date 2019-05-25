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
    public partial class AddBusy : Form
    {
        public AddBusy()
        {
            InitializeComponent();
        }

        private void BtnAddSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule empForm = new AddSchedule();
            empForm.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (AddSchedule.shedule == null)
            {
                DataManagement.WriteEmpFiles(textName.Text + "!");
            }
            else
            {
                DataManagement.WriteEmpFiles($"{textName.Text}!{AddSchedule.shedule}");
            }

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
