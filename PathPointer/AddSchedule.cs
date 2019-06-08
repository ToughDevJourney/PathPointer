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
        public static string Schedule { get; set; }
        private int PickedDayOfWeek { get; set; }
        private Label[] lblsTimeOfDaysOfWeek = new Label[7];
        private bool firstBeginChange = true;
        private bool firstEndChange = true;
        private bool beginChanged = false;
        private bool endChanged = false;
        private Label pickedLabelDayOfWeek;



        public AddSchedule()
        {
            InitializeComponent();

        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            InitializeDaysOfWeekArray();
            pickedLabelDayOfWeek = lblMon;
            lblMon_Click(null, null);
            MouseEnterFontEvent(lblMon);
            if (AddBusy.BusyName == "") lblBusinessName.Text = "Неназванное дело";
            else lblBusinessName.Text = AddBusy.BusyName;
        }
        private void InitializeDaysOfWeekArray() {
            lblsTimeOfDaysOfWeek[0] = lblTimeMon;
            lblsTimeOfDaysOfWeek[1] = lblTimeTue;
            lblsTimeOfDaysOfWeek[2] = lblTimeWed;
            lblsTimeOfDaysOfWeek[3] = lblTimeThu;
            lblsTimeOfDaysOfWeek[4] = lblTimeFri;
            lblsTimeOfDaysOfWeek[5] = lblTimeSat;
            lblsTimeOfDaysOfWeek[6] = lblTimeSun;
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            string[] schedArr = new string[7] { lblTimeMon.Text, lblTimeTue.Text, lblTimeWed.Text,      // инициализация массива-расписания
            lblTimeThu.Text, lblTimeFri.Text, lblTimeSat.Text, lblTimeSun.Text };

            schedArr = ExportFormatTime(schedArr);

            Schedule = $"{schedArr[0]}{schedArr[1]}{schedArr[2]}{schedArr[3]}{schedArr[4]}{schedArr[5]}{schedArr[6]}";    //подготовка строки к сохранению в файл
            BtnCancel_Click(null, null);
        }
        private void TextBegin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TextBegin_Leave(null, null);
                TextEnd.Focus();
            }
        }
        private void TextEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TextEnd_Leave(null, null);
                TextBegin.Focus();
            }
        }
        private void TextBegin_Leave(object sender, EventArgs e)
        {
            TextBegin.Text = FormatChecking(TextBegin.Text);
            BeginTimeIsLessThenEndTimeCheck();
            if (firstBeginChange == true && beginChanged == true) ChangeAllDays(ref firstBeginChange);  //при первом изменении, изменяется расписание всех дней
            else FromTimePickToSchedule();
        }
        private void TextEnd_Leave(object sender, EventArgs e)
        {
            TextEnd.Text = FormatChecking(TextEnd.Text);
            BeginTimeIsLessThenEndTimeCheck();
            if (firstEndChange == true && endChanged == true) ChangeAllDays(ref firstEndChange);
            else FromTimePickToSchedule();
        }

        private string[] ExportFormatTime(string[] scheduleArray) //форматирование строки в вид "9 17!"
        {

            for (int i = 0; scheduleArray.Length > i; i++)
            {
                if (scheduleArray[i][0] == 'В') //если по расписанию выхожной
                {
                    scheduleArray[i] = "H!";
                    continue;
                }
                scheduleArray[i] = scheduleArray[i].Replace(" - ", " ");
                scheduleArray[i] = scheduleArray[i].Replace(":00", "");
                scheduleArray[i] = scheduleArray[i].Replace(":00", "");

                if (scheduleArray[i][3] == '0') scheduleArray[i] = scheduleArray[i].Remove(6, 1);
                if (scheduleArray[i][0] == '0') scheduleArray[i] = scheduleArray[i].Remove(0, 1);
                scheduleArray[i] += "!";
            }

            return scheduleArray;
        }
        private string FormatChecking(string checkFormat)
        {


            int hoursADay = 24;

            if (checkFormat == "Выходной")
            {
                checkFormat = "00:00";
            }
            else
            {
                checkFormat = checkFormat.Substring(0, 2);
                if (checkFormat[0] == ' ')
                {
                    checkFormat = "00:00";
                }
                else
                {
                    if (checkFormat[1] == ' ')
                    {
                        checkFormat = $"0{checkFormat[0]}:00";
                    }
                    else
                    {
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
                            else
                            {
                                checkFormat = $"{checkFormat}:00";
                            }
                        }
                    }
                }
            }
            return checkFormat;
        }


        private void DayOfWeekClick(Label pickedLabel)
        {
            Label intermediateLbl = pickedLabelDayOfWeek;
            Label currentLbl = lblsTimeOfDaysOfWeek[PickedDayOfWeek];

            pickedLabelDayOfWeek = pickedLabel;      //отмена выделения предыдущего выбранного дня недели
            MouseEnterFontEvent(pickedLabelDayOfWeek);
            MouseLeaveFontEvent(intermediateLbl);

            if (currentLbl.Text == "Выходной")
            {
                TextBegin.Text = "08:00";
                TextEnd.Text = "15:00";
                currentLbl.Text = "08:00 - 15:00";
            }
            else
            {
                TextBegin.Text = currentLbl.Text.Remove(currentLbl.Text.IndexOf(" "));
                TextEnd.Text = currentLbl.Text.Substring(currentLbl.Text.IndexOf("-") + 2);
            }
        }

        private void FromTimePickToSchedule()
        {
            string pickedTime = $"{TextBegin.Text} - {TextEnd.Text}";
            lblsTimeOfDaysOfWeek[PickedDayOfWeek].Text = pickedTime;
        }

        private void BeginTimeIsLessThenEndTimeCheck() {
            int beginTime = Convert.ToInt32(TextBegin.Text.Remove(2));
            int endTime = Convert.ToInt32(TextEnd.Text.Remove(2));

            if (beginTime > endTime) TextEnd.Text = TextBegin.Text;
        }


        private void ChangeAllDays(ref bool firstChange) //при первом изменении часов, изменяются часы всех дней недели
        {     
            int currentPickedDay = PickedDayOfWeek;

            for (int i = 0; i < 7; i++)
            {
                PickedDayOfWeek = i;
                FromTimePickToSchedule();
            }

            firstChange = false;
            PickedDayOfWeek = currentPickedDay;
        }

        private void TimeClick(Label label)
        { 
            if (label.Text != "Выходной") label.Text = "Выходной";
            else label.Text = "08:00 - 15:00";
        }

        private void TextBegin_TextChanged(object sender, EventArgs e)
        {
            beginChanged = true;
        }
        private void TextEnd_TextChanged(object sender, EventArgs e)
        {
            endChanged = true;
        }
        private void MouseEnterFontEvent(Label label) {
            label.Font = new Font(label.Font, FontStyle.Bold);
        }
        private void MouseLeaveFontEvent(Label label)
        {
            if (label != pickedLabelDayOfWeek) {
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
            PickedDayOfWeek = 0;
            DayOfWeekClick(lblMon);
        }
        private void lblTue_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 1;
            DayOfWeekClick(lblTue);
        }
        private void lblWed_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 2;
            DayOfWeekClick(lblWed);
        }
        private void lblThu_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 3;
            DayOfWeekClick(lblThu);
        }
        private void lblFri_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 4;
            DayOfWeekClick(lblFri);
        }
        private void lblSat_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 5;
            DayOfWeekClick(lblSat);
        }
        private void lblSun_Click(object sender, EventArgs e)
        {
            PickedDayOfWeek = 6;
            DayOfWeekClick(lblSun);
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
