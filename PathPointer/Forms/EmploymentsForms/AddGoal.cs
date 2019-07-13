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
        EmploymentsGoals goals = new EmploymentsGoals();
        AchiveAddGoal achivement = new AchiveAddGoal();

        public AddGoal()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string goalName = goals.CheckEmploymentFormat(textName.Text);
            string goalTime = textTime.Text;

            if (goalName == "") MessageBox.Show("Пожалуйста, введите название", "Вы упустили пунктик");
            else
            {
                if (goalTime == "") goalTime = "0";

                goals.WriteEmploymentToFile($"{goalName}!{goals.GetLastCode}!{Convert.ToInt32(goalTime)}!{datePicker.Text}");        //запись цели в файл
                achivement.CheckCondition();
                BtnCancel_Click(null, null);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MenuManagement.ShowForm(this, new AddEmployments());
        }

        private void AddGoal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void textTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) e.Handled = true;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if (datePicker.Value < DateTime.Now) datePicker.Value = DateTime.Now;
        }

        private void AddGoal_Load(object sender, EventArgs e)
        {

        }
    }
}
