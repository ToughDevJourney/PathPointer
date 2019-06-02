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
        public static string Shedule { get; set; }
        private int PickedDayOfWeek { get; set; }
        private bool firstBeginChange = true;
        private bool firstEndChange = true;

        public AddSchedule()
        {
            InitializeComponent();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            lblMon_Click(null, null);
        }


        private void BtnDone_Click(object sender, EventArgs e)
        {
            string[] schedArr = new string[7] { lblTimeMon.Text, lblTimeTue.Text, lblTimeWed.Text,      // инициализация массива-расписания
            lblTimeThu.Text, lblTimeFri.Text, lblTimeSat.Text, lblTimeSun.Text };

            for (int i = 0; schedArr.Length > i; i++) {
                schedArr[i] = schedArr[i].Remove(schedArr[i].IndexOf(" "), 2);             //форматирование строки в вид "09:15 17:20"
            }

            Shedule = $"Пн {schedArr[0]} Вт {schedArr[1]} Ср {schedArr[2]} Чт {schedArr[3]} Пт {schedArr[4]} Сб {schedArr[5]} Вс {schedArr[6]}";    //подготовка строки к сохранению в файл
            BtnCancel_Click(null, null);
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

        private void lblMon_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 1;
            ShowDaySchedule();
        }

        private void lblTue_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 2;
            ShowDaySchedule();
        }

        private void lblWed_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 3;
            ShowDaySchedule();
        }

        private void lblThu_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 4;
            ShowDaySchedule();
        }

        private void lblFri_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 5;
            ShowDaySchedule();
        }

        private void lblSat_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 6;
            ShowDaySchedule();
        }

        private void lblSun_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 7;
            ShowDaySchedule();
        }

        private void ShowDaySchedule(){
            switch (PickedDayOfWeek) {
                case 1:
                    DisplayTime(lblTimeMon);
                    break;
                case 2:
                    DisplayTime(lblTimeTue);
                    break;
                case 3:
                    DisplayTime(lblTimeWed);
                    break;
                case 4:
                    DisplayTime(lblTimeThu);
                    break;
                case 5:
                    DisplayTime(lblTimeFri);
                    break;
                case 6:
                    DisplayTime(lblTimeSat);
                    break;
                case 7:
                    DisplayTime(lblTimeSun);
                    break;
            }
        }

        private void UpdateSchedule()
        {
            string pickedTime = $"{TextBegin.Text} - {TextEnd.Text}";
            switch (PickedDayOfWeek)
            {
                case 1:
                    lblTimeMon.Text = pickedTime;
                    break;
                case 2:
                    lblTimeTue.Text = pickedTime;
                    break;
                case 3:
                    lblTimeWed.Text = pickedTime;
                    break;
                case 4:
                    lblTimeThu.Text = pickedTime;
                    break;
                case 5:
                    lblTimeFri.Text = pickedTime;
                    break;
                case 6:
                    lblTimeSat.Text = pickedTime;
                    break;
                case 7:
                    lblTimeSun.Text = pickedTime;
                    break;
            }
        }




        private void TextBegin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TextBegin_Leave(null, null);
                TextEnd.Focus();
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void TextEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TextEnd_Leave(null, null);
                BtnDone.Focus();
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void TextBegin_Leave(object sender, EventArgs e)
        {
            int currentPickedDay = PickedDayOfWeek;
            if (firstBeginChange == true)
            {
                for (int i = 1; i <= 7; i++)
                {
                    PickedDayOfWeek = i;
                    UpdateSchedule();
                    firstBeginChange = false;
                }
            }
            else UpdateSchedule();

            PickedDayOfWeek = currentPickedDay;
        }

        private void TextEnd_Leave(object sender, EventArgs e)
        {
            int currentPickedDay = PickedDayOfWeek;
            if (firstEndChange == true)
            {
                for (int i = 1; i <= 7; i++)
                {
                    PickedDayOfWeek = i;
                    UpdateSchedule();
                    firstEndChange = false;
                }
            }
            else UpdateSchedule();

            PickedDayOfWeek = currentPickedDay;
        }


        private void DisplayTime(Label currentLbl)
        {
            TextBegin.Text = currentLbl.Text.Remove(currentLbl.Text.IndexOf(" "), currentLbl.Text.Length - currentLbl.Text.IndexOf(" "));
            TextEnd.Text = currentLbl.Text.Substring(currentLbl.Text.IndexOf("-") + 2);
        }


    }
}
