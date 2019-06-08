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
    public class StatsManagement : Management
    {

        public string Business { get; set; }        //элемент DataSource
        private static string[] statsFileArr { get; set; }




        
        public static void FillGrid(ref DataGridView dataGridView, int dayOfWeek)      //вывод в DataGridView данных из документа с названием empType  
        {
            SetPath("Efficiency");

            int currentDayOfWeekCode = (int)DateTime.Now.DayOfWeek;
            bool pickedCurrentDay = currentDayOfWeekCode == dayOfWeek ? true : false;

            dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;     //американская неделя начинается с воскресенья, исправление
            currentDayOfWeekCode = currentDayOfWeekCode == 0 ? 7 : currentDayOfWeekCode;

            dataGridView.ColumnCount = 24;
            dataGridView.RowCount = 1;


            if (dayOfWeek > currentDayOfWeekCode)
            {
                statsFileArr = FillStatsArray(2, pickedCurrentDay);   //заполнить массив данными предыдущей недели
            }
            else {
                statsFileArr = FillStatsArray(1, pickedCurrentDay);       //заполнить массив данными текущей недели
            }


            for (int i = 0; i<24; i++) {
                for (int symbCount = 0; symbCount < dayOfWeek; symbCount++) {       //получение расписания для текущего дня недели 
                    statsFileArr[i] = statsFileArr[i].Substring(statsFileArr[i].IndexOf(";") + 1);
                }
                if (statsFileArr[i].Contains(";")) {
                    statsFileArr[i] = statsFileArr[i].Substring(0, (statsFileArr[i].IndexOf(";")));

                }

                GetCellColor(statsFileArr[i], i, dataGridView);
            }

        }

        private static string[] FillStatsArray(int index, bool pickedCurrentDay) { //вывод массива данных об определенной недели
            string[] statsArray = new string[24];
            string readLine;
            int arrayIndex = 0;
            int currentHour = DateTime.Now.Hour;

            using (StreamReader reader = new StreamReader(FilePath))
            {
                for (int i = 0; (readLine = reader.ReadLine()) != null; i++) {
                    if (24 * (index - 1) <= i) {
                        statsArray[arrayIndex] = readLine;


                        if (pickedCurrentDay == true) {
                            if (arrayIndex == currentHour) statsArray[arrayIndex] = "T";
                            else if (arrayIndex > currentHour) statsArray[arrayIndex] = "F";
                        }

                        arrayIndex++;
                        if (arrayIndex == 24) break;
                        
                    }


                }
            }

            return statsArray;
        }


        private static void GetCellColor(string cellValue, int cellIndex, DataGridView dataGridView) {

            switch (GetValueByIndex(statsFileArr[cellIndex]))
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
                case "T":
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.LightBlue ;
                    break;
                case "F":
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.Black;
                    break;
                default:
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.Gray;
                    break;

            }
        }



        public static void DisplayMainStats(ref Label lblName, ref Label lblType, int currentEmployment) {

            SetPath($"Employments\\{GetValueByIndex(statsFileArr[currentEmployment])}");

            string employmentName = "";
            string employmentType = "";

            if (statsFileArr[currentEmployment] == "" || statsFileArr[currentEmployment] == " ")
            {
                employmentName = "ПРОПУСК";
                employmentType = "Похоже, что в это время вы занимались чем-то ДЕЙСТВИТЕЛЬНО полезным" +
                                "\nВам должно быть стыдно";
            }
            else if (statsFileArr[currentEmployment] == "T")
            {
                employmentName = "СЕЙЧАС";
                employmentType = "Ваша судьба в ваших руках" +
                                "\nПочему бы не заняться чем-нибудь полезным прямо сейчас?";
            }
            else if (statsFileArr[currentEmployment] == "F")
            {

                employmentName = "БУДУЩЕЕ";
                employmentType = "Этот отрезок времени покрыт великой тайной..." +
                                "\nНикто не знает, будете ли вы через пару часов смотреть телевизор или встанете на путь к своей цели" +
                                "\nРазработчик этой программы верит в вас (Пожалуйста, встаньте на на путь к своей цели, не расстраивайте программиста)";
            }
            else {
                try
                {
                    using (StreamReader sr = new StreamReader(FilePath))
                    {
                        while ((employmentName = sr.ReadLine()) != null)
                        {
                            if (GetValueByIndex(employmentName, 1) == GetValueByIndex(statsFileArr[currentEmployment], 1))
                            {
                                employmentName = GetValueByIndex(employmentName);
                                employmentType = GetValueByIndex(statsFileArr[currentEmployment], 0);
                                break;
                            }
                        }
                    }
                }
                catch { }
                finally
                {
                    switch (employmentType)
                    {
                        case "":
                            employmentName = "УПС, КАЖЕТСЯ, МЫ ПОТЕРЯЛИ ВАШИ ДАННЫЕ";
                            employmentType = "Обратитесь к вашему системному администратору" +
                                            "\nНе факт, что он найдет, но разработчик этой программы очень любит людей";
                            break;
                        case "Business":
                            employmentType = "Похоже, в это время вы гуляли с собакой и вам было очень холодно" +
                                            "\nЗнайте, что разработчику этой программы очень вас жалко :)";
                            break;
                        case "Goals":
                            employmentType = "Ого, вы на верном пути к вашей цели!" +
                                            "\nВы ведь не потратили это время на чепуху, в роде, \"Смотреть весь день телевизор\", верно?";
                            break;
                        case "Rest":
                            employmentType = "Надеюсь, вы хорошо отдохнули!" +
                                            "\nНо помните, что если вы провели 4 часа за компьютером, \"Посидеть в вашем модном телефончике\" - не будет для вас отдыхом" +
                                            "\nОтдых - это смена деятельности, лучше сходите на прогулку или поиграйте с кошкой";
                            break;
                        case "Fun":
                            employmentType = "Развлечения могут повысить продуктивность, но чрезмерное злоупотребление ими, может вас погубить" +
                                            "\nБудьте осторожны";
                            break;


                    }
                }
            }



            lblName.Text = employmentName;
            lblType.Text = employmentType;
        }





        public static void WriteStats(string name)    
        {
            SetPath("Efficiency");

            int hour = DateTime.Now.Hour-1;
            int dayOfWeek = Convert.ToInt32(DateTime.Now.DayOfWeek);

            string[] efficiency = File.ReadAllLines(FilePath);
            string checkDay = efficiency[hour];

            for (int i = 0; i<=7; i++) {      //заполнение дней недели пропусками, если пользователь в это время был неактивен
                if (checkDay.Contains(";"))
                {
                    checkDay = checkDay.Remove(checkDay.IndexOf(";"), 1);                  
                }
                else if (dayOfWeek == 0 || dayOfWeek > i) efficiency[hour] += " ;";
                else break;
            }
            efficiency[hour] += $"{name};";

            File.WriteAllLines(FilePath, efficiency);

        }

        public static int FindCode(string name, string empType)
        {
            SetPath($"Employments\\{empType}");
            int code = 0;
            string line;
            using (StreamReader reader = new StreamReader(FilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (String.Compare(GetValueByIndex(line), name) == 0)
                    {
                        line = GetValueByIndex(line, 1);
                        code = Convert.ToInt32(line);
                        break;
                    }
                }
            }

            return code;
        }

        public static void CheckWeekRelevance() {
            SetPath("Common");

            string fileContainer = "";
            string readLine;
            var cal = new GregorianCalendar();
            int currentWeekNumber = cal.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
            int fileWeekNumber;
            const int hoursADay = 24;
            bool weekIsNowRelevant = false;


            using (StreamReader sr = new StreamReader(FilePath))    //если последняя запись в файл производилась не на этой неделе
            {
                while ((readLine = sr.ReadLine()) != null)
                {
                    if (GetValueByIndex(readLine, 0) == "Week Number")
                    {
                        fileWeekNumber = Convert.ToInt32(GetValueByIndex(readLine, 1));
                        if (fileWeekNumber != currentWeekNumber) {
                            weekIsNowRelevant = true;
                            fileContainer = File.ReadAllText(FilePath);
                        }
                        break;
                    }
                }
            }

            if (weekIsNowRelevant == true) {
                using (StreamWriter wr = new StreamWriter(FilePath))
                {
                    fileContainer = fileContainer.Replace(readLine, $"Week Number!{currentWeekNumber}");
                    wr.Write(fileContainer);
                }

                SetPath("Efficiency");

                using (StreamReader sr = new StreamReader(FilePath)) fileContainer = sr.ReadToEnd();
                File.Delete(FilePath);

                using (StreamWriter wr = new StreamWriter(FilePath))
                {
                    for (int i = 0; i < hoursADay; i++) {
                        wr.WriteLine($"{i}:00;");
                    }
                    wr.Write(fileContainer);
                }
            }
        }


        public static bool CheckSchedule() {        //занят ли текущий час расписанием
            SetPath("Employments\\Business");
            string[] businessArray = File.ReadAllLines(FilePath);
            bool hourInSchedule = false;
            int beginHour;
            int endHour;

            for (int i = 0; i < businessArray.Length; i++) {
                if (GetValueByIndex(businessArray[i], 2) == "N") continue;
                else
                {
                    businessArray[i] = GetValueByIndex(businessArray[i], CurrentDateInfo.DayOfWeek + 2);
                    if (businessArray[i] == "H") continue;
                    beginHour = Convert.ToInt32(businessArray[i].Remove(businessArray[i].IndexOf(" ")));
                    endHour = Convert.ToInt32(businessArray[i].Substring(businessArray[i].IndexOf(" ") + 1));
                    if (beginHour <= CurrentDateInfo.Hour-1 && CurrentDateInfo.Hour-1 < endHour) {
                        hourInSchedule = true;
                        break;
                    }
                }
            }

            return hourInSchedule;
        }


    }
}
