using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        StatsManagement stats = new StatsManagement();

        public AddSchedule()
        {
            InitializeComponent();

        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            InitializeDaysOfWeekArray();
            pickedLabelDayOfWeek = lblMon;
            DayOfWeekClick(lblMon, null);
            MouseEnterLabelEvent(lblMon, null);
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
            string message = "";

            schedArr = ExportToFileFormatTime(schedArr);

            message = IsScheduleAlreadyAdded(schedArr);
            if (message != "")
            {
                MessageBox.Show(message, "Ошибка");
            }
            else
            {
                Schedule = $"{schedArr[0]}/{schedArr[1]}/{schedArr[2]}/{schedArr[3]}/{schedArr[4]}/{schedArr[5]}/{schedArr[6]}";    //подготовка строки к сохранению в файл
                BtnCancel_Click(null, null);
            }
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
            TextBegin.Text = FormatLines.TimeFormat(TextBegin.Text);
            BeginTimeIsLessThenEndTimeCheck();
            if (firstBeginChange == true && beginChanged == true) ChangeAllDays(ref firstBeginChange);  //при первом изменении, изменяется расписание всех дней
            else FromTimePickToSchedule();
        }
        private void TextEnd_Leave(object sender, EventArgs e)
        {
            TextEnd.Text = FormatLines.TimeFormat(TextEnd.Text);
            BeginTimeIsLessThenEndTimeCheck();
            if (firstEndChange == true && endChanged == true) ChangeAllDays(ref firstEndChange);
            else FromTimePickToSchedule();
        }

        private string IsScheduleAlreadyAdded(string[] scheduleArr) {
            int beginTime;
            int endTime;
            int dayOfWeek;
            string schedule;
            string message;
            string employment = "";

            for (int i = 0; i < 7; i++) {
                if (scheduleArr[i] == "H") continue;
                beginTime = Convert.ToInt32(scheduleArr[i].Remove(scheduleArr[i].IndexOf(" ")));
                endTime = Convert.ToInt32(scheduleArr[i].Substring(scheduleArr[i].IndexOf(" ") + 1));

                schedule = StatsManagement.IsHourInSchedule(beginTime, i);
                if (schedule == null) schedule = StatsManagement.IsHourInSchedule(endTime, i);
                if (schedule != null)
                {
                    employment = Management.GetValueByIndex(schedule);

                    schedule = Management.GetValueByIndex(schedule, 2); //выывод расписания
                    schedule = Management.GetValueByIndex(schedule, i, "/"); //вывод расписания для конкрентого дня недели

                    beginTime = Convert.ToInt32(schedule.Remove(schedule.IndexOf(" ")));
                    endTime = Convert.ToInt32(schedule.Substring(schedule.IndexOf(" ") + 1));

                    dayOfWeek = i + 1;
                    dayOfWeek = dayOfWeek == 7 ? 0 : dayOfWeek;

                    message = $"Ваш {CultureInfo.CurrentCulture.DateTimeFormat.DayNames[dayOfWeek]} уже занят." +
                        $"\nВ это время вы занимаетесь \"{employment}, с {beginTime} по {endTime}.";
                    return message;
                }
            }

            return "";
        }

        private string[] ExportToFileFormatTime(string[] scheduleArray) //форматирование строки в вид "9 17!"
        {
            string beginHour;
            string endHour;
            for (int i = 0; scheduleArray.Length > i; i++)
            {
                if (scheduleArray[i] == "Выходной") //если по расписанию выхожной
                {
                    scheduleArray[i] = "H";
                    continue;
                }
                scheduleArray[i] = scheduleArray[i].Replace(" - ", " ");

                beginHour = scheduleArray[i].Remove(scheduleArray[i].IndexOf(" "));
                endHour = scheduleArray[i].Substring(scheduleArray[i].IndexOf(" ") + 1);

                beginHour = FormatLines.ShortFormatTime(beginHour);
                endHour = FormatLines.ShortFormatTime(endHour);

                scheduleArray[i] = $"{beginHour} {endHour}";


            }

            return scheduleArray;
        }




        private void DayOfWeekClick(object sender, EventArgs e)
        {
            Label pickedLabel = (Label)sender;
            PickedDayOfWeek = Convert.ToInt32(pickedLabel.Tag);

            Label intermediateLbl = pickedLabelDayOfWeek;
            Label currentLbl = lblsTimeOfDaysOfWeek[PickedDayOfWeek];

            pickedLabelDayOfWeek = pickedLabel;      //отмена выделения предыдущего выбранного дня недели
            MouseEnterLabelEvent(pickedLabelDayOfWeek, null);
            MouseLeaveFontEvent(intermediateLbl, null);

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

        private void TimeClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
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
        private void MouseEnterLabelEvent(object sender, EventArgs e) {
            Label enterLabel = (Label)sender;
            enterLabel.Font = new Font(enterLabel.Font, FontStyle.Bold);
        }
        private void MouseLeaveFontEvent(object sender, EventArgs e)
        {
            Label leaveLabel = (Label)sender;
            if (leaveLabel != pickedLabelDayOfWeek) leaveLabel.Font = new Font(leaveLabel.Font, FontStyle.Regular);
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
