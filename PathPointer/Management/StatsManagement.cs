using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public class StatsManagement
    {
        public static DayEfficiency[] StatsFileArr { get; set; }
        public static readonly string EfficiencyFile = Management.GetPath("Efficiency");
        public string Business { get; set; }        //элемент DataSource

        public void FillWeekEfficiencyGrid(ref DataGridView dataGridView)      //вывод в DataGridView данных из документа с названием empType  
        {
            int dayOfWeek = MainMenu.pickedDayOfWeek;
            dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;     //американская неделя начинается с воскресенья, исправление
            bool pickedCurrentDay = CurrentDateInfo.DayOfWeek == dayOfWeek ? true : false;

            dataGridView.ColumnCount = 24;
            dataGridView.RowCount = 1;

            if (dayOfWeek > CurrentDateInfo.DayOfWeek) StatsFileArr = FillStatsArray(2, dayOfWeek, pickedCurrentDay);     //заполнить массив данными предыдущей недели
            else StatsFileArr = FillStatsArray(1, dayOfWeek, pickedCurrentDay);                                      //заполнить массив данными текущей недели

            for (int i = 0; i < 24; i++) {
                GetCellColor(i, dataGridView);
            }

        }

        public DayEfficiency[] FillStatsArray(int weekNumber, int dayOfWeek, bool pickedCurrentDay = false) { //вывод массива данных об определенной недели
            DayEfficiency[] statsArray = new DayEfficiency[24];
            string readLine;
            bool weekExists = false;
            int arrayIndex = 0;
            weekNumber--;

            using (StreamReader reader = new StreamReader(EfficiencyFile))
            {
                for (int i = 0; (readLine = reader.ReadLine()) != null; i++) {
                    if (24 * weekNumber <= i) {    //вывод конкретной недели

                        readLine = Management.GetValueByIndex(readLine, dayOfWeek, ";");


                        if (pickedCurrentDay == true && arrayIndex == DateTime.Now.Hour) statsArray[arrayIndex] = new EmploymentsSkip(new DayEfficiencyNow());
                        else if (pickedCurrentDay == true && arrayIndex > DateTime.Now.Hour) statsArray[arrayIndex] = new EmploymentsSkip(new DayEfficiencyFuture());
                        else if (readLine == " " || readLine == "") statsArray[arrayIndex] = new EmploymentsSkip(new DayEfficiencySkip());
                        else statsArray[arrayIndex] = Employments.GetEmploymentType(readLine);

                        arrayIndex++;
                        weekExists = true;
                        if (arrayIndex == 24) break;
                    }
                }
            }

            if (weekExists == false) return null;
            else return statsArray;
        }

        private static void GetCellColor(int cellIndex, DataGridView dataGridView) {

            switch (StatsFileArr[cellIndex].EmpType)
            {
                case "Business":
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.Blue;
                    break;
                case "Goals":
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case "Rest":
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.DarkOrange;
                    break;
                case "Fun":
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.Red;
                    break;
                case Texts.empTypeNow:
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.LightBlue; //сейчас
                    break;
                case Texts.empTypeFuture:
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.Black; //будущее
                    break;
                default:
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.Gray;  //пропуск
                    break;
            }
        }



        public static void DisplayMainStats(ref Label lblName, ref Label lblType, ref Label lblDoneHours, ref Label lblMustSpend, int currentEmployment) {
            lblName.Text = StatsFileArr[currentEmployment].Name;
            lblType.Text = StatsFileArr[currentEmployment].TypeDescription;
            lblDoneHours.Text = StatsFileArr[currentEmployment].HoursDescription;
            lblMustSpend.Text = StatsFileArr[currentEmployment].HoursToSpendDescription;
        }



        public static void WriteStats(string name, int range = 1)   //ИСПРАВИТЬ
        {
            int settableHour = DateTime.Now.Hour - range;
            int settableDayOfWeek = CurrentDateInfo.DayOfWeek;
            int empDayOfWeek;
            string[] efficiency = File.ReadAllLines(EfficiencyFile);
                       
            PreviousHourFix(ref settableHour, ref settableDayOfWeek);

            string chckNumOfEmps = efficiency[settableHour];
            empDayOfWeek = chckNumOfEmps.ToCharArray().Count(c => c == ';');

            for (int i = empDayOfWeek; i <= 7; i++) {      //заполнение дней недели пропусками, если пользователь в это время был неактивен
                if (settableDayOfWeek > i) efficiency[settableHour] += " ;";   
                else break;
            }
            efficiency[settableHour] += $"{name};";

            File.WriteAllLines(EfficiencyFile, efficiency);

        }

        public static bool CheckIsHourAvailable(int range = 1) {
            string scheduleForHour;
            bool fileInSchedule = false;
            bool fileIsFree = false;
            int checkingDayOfWeek = CurrentDateInfo.DayOfWeek;
            int checkingHour = DateTime.Now.Hour - range;

            PreviousHourFix(ref checkingHour, ref checkingDayOfWeek);

            scheduleForHour = IsHourInSchedule(checkingHour, checkingDayOfWeek);
            if (scheduleForHour != null) fileInSchedule = true;

            fileIsFree = IsHourInEfficiency(checkingHour, checkingDayOfWeek);
            if (fileIsFree == true && range == 1 && fileInSchedule == true) WriteSchedHrToEfficiency(scheduleForHour);
            
            if (fileIsFree == true && fileInSchedule == false) return true;
            else return false;
        }

        private static void WriteSchedHrToEfficiency(string scheduleLine){
            WriteStats($"Business!{Management.GetValueByIndex(scheduleLine, 1)}");
            string filePath = Management.GetPath(FileManagement.BusinessFile);
            string[] scheduleFileArray = File.ReadAllLines(filePath);

            string oldUpdateDate = Management.GetValueByIndex(scheduleLine, 3);

            for (int i = 0; i < scheduleFileArray.Length; i++) {
                if (scheduleFileArray[i] == scheduleLine) {
                    scheduleFileArray[i].Replace(oldUpdateDate, DateTime.Now.ToShortDateString());
                    break;
                }
            }

            File.WriteAllLines(filePath, scheduleFileArray);  
        }

        public static string IsHourInSchedule(int checkingHour, int checkingDayOfWeek) {
            int beginHour;
            int endHour;
            string schedule;
            string hourSchedule = null;
            string[] scheduleFileArray = File.ReadAllLines(FileManagement.BusinessFile);

            for (int i = 0; i < scheduleFileArray.Length; i++) //указан ли текущий час в расписании
            {
                if (Management.GetValueByIndex(scheduleFileArray[i], 2) == Codes.noSchedule) continue;  //если расписание отсутствует
                else
                {
                    schedule = Management.GetValueByIndex(scheduleFileArray[i], 2);    //возврат расписания
                    schedule = Management.GetValueByIndex(schedule, checkingDayOfWeek - 1, "/"); //возврат расписания для конкретного дня

                    if (schedule == Codes.noScheduleForThisDay) continue;
                    beginHour = Convert.ToInt32(schedule.Remove(schedule.IndexOf(" ")));
                    endHour = Convert.ToInt32(schedule.Substring(schedule.IndexOf(" ") + 1));

                    if (beginHour <= checkingHour && checkingHour - 1 < endHour)
                    {                                                
                        hourSchedule = scheduleFileArray[i];
                        break;
                    }
                }
            }

            return hourSchedule;
        }

        public static void WriteHoursFromSchedule (bool fillWholeWeek = false){   //расписание не позже текущего часа и время добавления
            DateTime lastSchUpdate;
            string intermediateFile = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Intermediate.txt";
            string[] effHrs = new string[24];
            string fileLine;
            string schedule;
            int dayOfWeek;
            int lineCount = 0;


            using (StreamReader reader = new StreamReader(EfficiencyFile)) {
                for (int eff = 0; eff < effHrs.Length; eff++) effHrs[eff] = reader.ReadLine();  //занесение в массив последней недели
            }

            for (int checkingHour = 0; checkingHour < effHrs.Length; checkingHour++)
            {

                dayOfWeek = effHrs[checkingHour].ToCharArray().Count(c => c == ';'); //определение последнего заполненного дня недели

                for (int dow = dayOfWeek; dow <= 7; dow++)
                {
                    if(((dow == CurrentDateInfo.DayOfWeek && checkingHour >= DateTime.Now.Hour - 1) || dow > CurrentDateInfo.DayOfWeek) && fillWholeWeek == false)   //если достигнут текущий час, происходит переход на следующую неделю
                    {
                        break;
                    }

                    if ((UserSettings.SleepTimeBegin <= checkingHour && checkingHour < UserSettings.SleepTimeEnd && UserSettings.SleepTimeBegin <= UserSettings.SleepTimeEnd) ||    //если начало сна позже 00:00
                        ((UserSettings.SleepTimeBegin <= checkingHour || checkingHour < UserSettings.SleepTimeEnd) && UserSettings.SleepTimeBegin > UserSettings.SleepTimeEnd))    //если начало сна раньше 00:00
                    {
                        effHrs[checkingHour] += $"Rest!@;";
                    }
                    else
                    {
                        schedule = IsHourInSchedule(checkingHour, dow);

                        if (schedule != null)
                        {
                            lastSchUpdate = Convert.ToDateTime(Management.GetValueByIndex(schedule, 3));

                            if ((DateTime.Now.Day - lastSchUpdate.Day >= (CurrentDateInfo.DayOfWeek) - dow) || fillWholeWeek == true) //если в последний раз расписание изменялось не раньше проверяемого дня
                            {
                                schedule = Management.GetValueByIndex(schedule, 1);        //вывод индекса для деятельности в расписании
                                effHrs[checkingHour] += $"Business!{schedule};";
                            }
                        }
                        else if ((checkingHour >= DateTime.Now.Hour - UserSettings.EmploymentCheckRange) && CurrentDateInfo.DayOfWeek == dow && fillWholeWeek == false) break; //если проверяемый час находится в радиусе сбора статистики у пользователя
                        else effHrs[checkingHour] += " ;";
                    }
                }

            }


            File.Copy(EfficiencyFile, intermediateFile);
            File.WriteAllLines(EfficiencyFile, effHrs);

            using (StreamReader interFile = new StreamReader(intermediateFile))
            {
                using (StreamWriter effFile = File.AppendText(EfficiencyFile))
                {
                    while ((fileLine = interFile.ReadLine()) != null) {
                        if (lineCount >= effHrs.Length) effFile.WriteLine(fileLine);
                        else lineCount++;
                    }
                }
            }

            if(fillWholeWeek == false) UpdateAllSchedulesDates();
            File.Delete(intermediateFile);
        }

        public static void UpdateAllSchedulesDates() {
            string[] scheduleArr = File.ReadAllLines(FileManagement.BusinessFile);
            string oldLastUpdate;
            for (int i = 0; i<scheduleArr.Length; i++) {
                oldLastUpdate = Management.GetValueByIndex(scheduleArr[i], 3);
                scheduleArr[i] = scheduleArr[i].Replace(oldLastUpdate, DateTime.Now.ToShortDateString());
            }
            File.WriteAllLines(FileManagement.BusinessFile, scheduleArr);
        }


        private static bool IsHourInEfficiency(int checkingHour, int checkingDayOfWeek) //если в этот час опрос уже был показан
        {
            string efficiencyString = "";
            string choosedHourOfEmployment;

            using (StreamReader reader = new StreamReader(EfficiencyFile)) {
                for (int i = 0; i <= checkingHour && (efficiencyString = reader.ReadLine()) != null; i++) { }                                   
            }
               
            choosedHourOfEmployment = Management.GetValueByIndex(efficiencyString, checkingDayOfWeek, ";");   

            if (choosedHourOfEmployment == "") return true;
            else return false;
        }

        private static void PreviousHourFix(ref int checkingHour, ref int checkingDayOfWeek)
        {
            if (checkingHour < 0)
            {
                checkingHour = 48 - UserSettings.EmploymentCheckRange;
                if (checkingDayOfWeek == 1)  checkingDayOfWeek = 7;
            }
        }



        public static void AddNewWeekIntoEfficiency(int weeksNumber = 1)
        {
            string fileContainer = "";
            string effFile = Management.GetPath("Efficiency");
            string intermediateFile = Management.GetPath("Eff Intermediate");


            const int hoursADay = 24;

            for (int i = 0; i < weeksNumber; i++)
            {

                if (new FileInfo(effFile).Length != 0)
                {
                    WriteHoursFromSchedule(true);   //расписание заполняется на всю неделю, в том числе и после текузего часа
                    File.Copy(effFile, intermediateFile);
                    File.Delete(effFile);
                }



                using (StreamWriter writer = new StreamWriter(effFile))
                {
                    for (int j = 0; j < hoursADay; j++)
                    {
                        writer.WriteLine($"{j}:00;");
                    }

                    if (File.Exists(intermediateFile))
                    {
                        using (StreamReader reader = new StreamReader(intermediateFile))
                        {
                            while ((fileContainer = reader.ReadLine()) != null)
                            {
                                writer.WriteLine(fileContainer);
                            }
                        }
                    }
                }
                               
                if (i == weeksNumber - 1) WriteHoursFromSchedule();  //расписание не будет устанавливаться для часов после текущего часа
                               
                File.Delete(intermediateFile);
            }
            UpdateAllSchedulesDates();
        }




    }
}
