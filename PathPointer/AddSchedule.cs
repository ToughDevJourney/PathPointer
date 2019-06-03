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
        private bool beginChanged = false;
        private bool endChanged = false;
        private Label pickedDayOfWeek;



        public AddSchedule()
        {
            InitializeComponent();

        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            lblMon_Click(null, null);
            pickedDayOfWeek = lblMon;
            MouseEnterFontEvent(lblMon);
        }


        private void BtnDone_Click(object sender, EventArgs e)
        {
            string[] schedArr = new string[7] { lblTimeMon.Text, lblTimeTue.Text, lblTimeWed.Text,      // инициализация массива-расписания
            lblTimeThu.Text, lblTimeFri.Text, lblTimeSat.Text, lblTimeSun.Text };

            schedArr = FormatTime(schedArr);

            Shedule = $"Пн {schedArr[0]} Вт {schedArr[1]} Ср {schedArr[2]} Чт {schedArr[3]} Пт {schedArr[4]} Сб {schedArr[5]} Вс {schedArr[6]}";    //подготовка строки к сохранению в файл
            BtnCancel_Click(null, null);
        }




        private void ShowDaySchedule(Label pickedLabel) {
            Label intermediateLbl = pickedDayOfWeek;

            pickedDayOfWeek = pickedLabel;


            MouseEnterFontEvent(pickedDayOfWeek);
            MouseLeaveFontEvent(intermediateLbl);





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
            TextBegin.Text = FormatChecking(TextBegin.Text);
            if (firstBeginChange == true && beginChanged == true) ChangeAllDays(ref firstBeginChange);  //при первом изменении, изменяется расписание всех дней
            else UpdateSchedule();

        }

        private void TextEnd_Leave(object sender, EventArgs e)
        {
            TextEnd.Text = FormatChecking(TextEnd.Text);
            if (firstEndChange == true && endChanged == true) ChangeAllDays(ref firstEndChange);
            else UpdateSchedule();

        }

        private string FormatChecking(string checkTime) {

            string checkFormat = checkTime;
            int hoursADay = 24;

            if (checkFormat.Length == 0)
            {
                checkFormat = "00:00";
            }
            else
            {
                if (checkFormat.Length == 1)
                {
                    checkFormat = $"0{checkFormat}:00";
                }
                else
                {
                    checkFormat = checkFormat.Substring(0, 2);

                    if (checkFormat[0] == 0)
                    {
                        checkFormat = $"0{checkFormat}:00";
                    }
                    else
                    {
                        if (Convert.ToInt32(checkFormat) >= hoursADay)
                        {
                            checkFormat = "23:00";
                        }
                        else {
                            checkFormat = $"{checkFormat}:00";
                        }
                    }
                }
            }


            return checkFormat;
        }



        private void ChangeAllDays(ref bool pickedChange) {     //при первом изменении часов, изменяются часы всех дней недели
            int currentPickedDay = PickedDayOfWeek;

            for (int i = 1; i <= 7; i++)
            {
                PickedDayOfWeek = i;
                UpdateSchedule();
            }

            pickedChange = false;
            PickedDayOfWeek = currentPickedDay;
        }

        private void DisplayTime(Label currentLbl)
        {
            TextBegin.Text = currentLbl.Text.Remove(currentLbl.Text.IndexOf(" "), currentLbl.Text.Length - currentLbl.Text.IndexOf(" "));
            TextEnd.Text = currentLbl.Text.Substring(currentLbl.Text.IndexOf("-") + 2);
        }

        private string[] FormatTime(string[] scheduleArray) //форматирование строки в вид "9:00 17:00"
        {

            for (int i = 0; scheduleArray.Length > i; i++)
            {
                scheduleArray[i] = scheduleArray[i].Remove(scheduleArray[i].IndexOf(" "), 2);
                if (scheduleArray[i][6] == '0') scheduleArray[i] = scheduleArray[i].Remove(6, 1);
                if (scheduleArray[i][0] == '0') scheduleArray[i] = scheduleArray[i].Remove(0, 1);
            }

            return scheduleArray;
        }

        private void TextBegin_TextChanged(object sender, EventArgs e)
        {
            beginChanged = true;
        }

        private void TextEnd_TextChanged(object sender, EventArgs e)
        {
            endChanged = true;
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

        private void TimeClick(Label label){
            if (label.Text != "Выходной")
            {
                label.Text = "Выходной";
            }
            else {
                TextBegin.Text = FormatChecking(TextBegin.Text);
                TextEnd.Text = FormatChecking(TextEnd.Text);
                label.Text = $"{TextBegin.Text} - {TextEnd.Text}";
            }
        }

        private void MouseEnterFontEvent(Label label) {
            label.Font = new Font(label.Font, FontStyle.Bold);
        }

        private void MouseLeaveFontEvent(Label label)
        {
            if (label != pickedDayOfWeek) {
                label.Font = new Font(label.Font, FontStyle.Regular);
            }
        }

        private void lblMon_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblMon);
        }
        private void lblTue_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTue);
        }
        private void lblWed_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblWed);
        }
        private void lblThu_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblThu);
        }
        private void lblFri_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblFri);
        }
        private void lblSat_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblSat);
        }
        private void lblSun_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblSun);
        }
        private void lblTimeMon_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTimeMon);
        }
        private void lblTimeTue_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTimeTue);
        }
        private void lblTimeWed_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTimeWed);
        }
        private void lblTimeFri_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTimeFri);
        }
        private void lblTimeThu_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTimeThu);
        }
        private void lblTimeSat_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTimeSat);
        }
        private void lblTimeSun_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterFontEvent(lblTimeSun);
        }

        private void lblMon_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblMon);
        }
        private void lblTue_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTue);
        }
        private void lblWed_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblWed);
        }
        private void lblThu_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblThu);
        }
        private void lblFri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblFri);
        }
        private void lblSat_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblSat);
        }
        private void lblSun_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblSun);
        }
        private void lblTimeMon_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTimeMon);
        }
        private void lblTimeTue_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTimeTue);
        }
        private void lblTimeWed_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTimeWed);
        }
        private void lblTimeThu_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTimeThu);
        }
        private void lblTimeFri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTimeFri);
        }
        private void lblTimeSat_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTimeSat);
        }
        private void lblTimeSun_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFontEvent(lblTimeSun);
        }

        private void lblTimeMon_Click(object sender, EventArgs e)
        {
            TimeClick(lblTimeMon);
        }
        private void lblTimeTue_Click(object sender, EventArgs e)
        {
            TimeClick(lblTimeTue);
        }
        private void lblTimeWed_Click(object sender, EventArgs e)
        {
            TimeClick(lblTimeWed);
        }
        private void lblTimeThu_Click(object sender, EventArgs e)
        {
            TimeClick(lblTimeThu);
        }
        private void lblTimeFri_Click(object sender, EventArgs e)
        {
            TimeClick(lblTimeFri);
        }
        private void lblTimeSat_Click(object sender, EventArgs e)
        {
            TimeClick(lblTimeSat);
        }
        private void lblTimeSun_Click(object sender, EventArgs e)
        {
            TimeClick(lblTimeSun);
        }

        private void lblMon_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 1;
            ShowDaySchedule(lblMon);
        }
        private void lblTue_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 2;
            ShowDaySchedule(lblTue);
        }
        private void lblWed_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 3;
            ShowDaySchedule(lblWed);
        }
        private void lblThu_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 4;
            ShowDaySchedule(lblThu);
        }
        private void lblFri_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 5;
            ShowDaySchedule(lblFri);
        }
        private void lblSat_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 6;
            ShowDaySchedule(lblSat);
        }
        private void lblSun_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 7;
            ShowDaySchedule(lblSun);
        }
    }
}
