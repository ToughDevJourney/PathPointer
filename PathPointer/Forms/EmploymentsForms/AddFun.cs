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
        EmploymentsFun fun = new EmploymentsFun();
        AchiveAddFun achivement = new AchiveAddFun();
        public AddFun()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string funName = fun.CheckEmploymentFormat(textName.Text);


            if (funName == "") MessageBox.Show("Не сочтите за труд, введите название развлечения", "Телепатия появится в следующих обновлениях");
            else
            {
                fun.WriteEmploymentToFile($"{funName}!{fun.GetLastCode}");
                achivement.CheckCondition();
                CancelButton_Click(null, null);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MenuManagement.ShowForm(this, new AddEmployments());
        }

        private void AddFun_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void textTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) e.Handled = true;
        }

        private void AddFun_Load(object sender, EventArgs e)
        {

        }
    }
}
