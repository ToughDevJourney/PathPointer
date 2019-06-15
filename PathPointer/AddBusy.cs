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
        public static string BusyName { get; set; }

        public AddBusy()
        {
            InitializeComponent();
        }

        private void AddBusy_Load(object sender, EventArgs e)
        {
            textName.Text = BusyName;
        }

        private void BtnAddSchedule_Click(object sender, EventArgs e)
        {
            BusyName = textName.Text;
            textName.Text = DataManagement.CheckEmploymentFormat(textName.Text);
            AddSchedule empForm = new AddSchedule();
            empForm.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string businessName = textName.Text;

            if (businessName == "")
            {
                MessageBox.Show("Будьте так любезны, введите название", "Телепатия временно недоступна");
            }
            else
            {
                if (AddSchedule.Schedule == null) DataManagement.WriteEmpFiles($"{textName.Text}!{DataManagement.Code}!N!N", DataManagement.EmpType);
                else DataManagement.WriteEmpFiles($"{textName.Text}!{DataManagement.Code}!{AddSchedule.Schedule}!{DateTime.Now.ToShortDateString()}", DataManagement.EmpType);
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
