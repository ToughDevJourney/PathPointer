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
            if (AddSchedule.Schedule == null)
            {
                DataManagement.WriteEmpFiles($"{textName.Text}!{DataManagement.Code}!0", DataManagement.EmpType);
            }
            else
            {
                DataManagement.WriteEmpFiles($"{textName.Text}!{DataManagement.Code}!{AddSchedule.Schedule}", DataManagement.EmpType);
            }

            BtnCancel_Click(null, null);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Employments empForm = new Employments();
            empForm.Show();
            this.Hide();
        }

        private void AddBusy_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }
    }
}
