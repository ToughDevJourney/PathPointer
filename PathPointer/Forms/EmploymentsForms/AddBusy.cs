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
        Employments business = new EmploymentsBusiness();

        public AddBusy()
        {
            InitializeComponent();
        }

        private void AddBusy_Load(object sender, EventArgs e)
        {
            textName.Text = BusyName;
            if (AddSchedule.Schedule != null) {
                labelSched.Text = "Расписание добавлено";
                BtnAddSchedule.Text = "Изменить";
            }
        }

        private void BtnAddSchedule_Click(object sender, EventArgs e)
        {
            BusyName = textName.Text;
            textName.Text = business.CheckEmploymentFormat(textName.Text);
            AddSchedule empForm = new AddSchedule();
            empForm.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string businessName = textName.Text;
            businessName = business.CheckEmploymentFormat(businessName);

            if (businessName == "") MessageBox.Show("Будьте так любезны, введите название", "Телепатия временно недоступна");
            else {              
                if (AddSchedule.Schedule == null) business.WriteEmploymentToFile($"{businessName}!{business.GetLastCode}!N!{DateTime.Now.ToShortDateString()}");
                else business.WriteEmploymentToFile($"{businessName}!{business.GetLastCode}!{AddSchedule.Schedule}!{DateTime.Now.ToShortDateString()}");
            }
            BtnCancel_Click(null, null);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MenuManagement.ShowForm(this, new AddEmployments());
        }

        private void AddBusy_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }


    }
}
