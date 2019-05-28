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
    public partial class AddSchedule : Form
    {
        public static string shedule;

        public AddSchedule()
        {
            InitializeComponent();
        }


        private void BtnDone_Click(object sender, EventArgs e)
        {
            string[] schedArr = new string[7] { lblTimeMon.Text, lblTimeTue.Text, lblTimeWed.Text,      // инициализация массива-расписания
            lblTimeThu.Text, lblTimeFri.Text, lblTimeSat.Text, lblTimeSun.Text };

            for (int i = 0; schedArr.Length > i; i++) {
                schedArr[i] = schedArr[i].Remove(schedArr[i].IndexOf(" "), 2);             //форматирование строки в вид "09:15 17:20"
            }

            shedule = $"Пн {schedArr[0]} Вт {schedArr[1]} Ср {schedArr[2]} Чт {schedArr[3]} Пт {schedArr[4]} Сб {schedArr[5]} Вс {schedArr[6]}";    //подготовка строки к сохранению в файл
            BtnCancel_Click(null,null);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AddBusy empForm = new AddBusy();
            empForm.Show();
            this.Hide();
        }

        private void AddSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }
    }
}
