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
    public class MainStatistic : FilesManagement
    {

        public string Business { get; set; }        //элемент DataSource
        private static string[] statsFileArr { get; set; }


        private static void SetPath(string empType) {
            FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\{empType}.txt");  //путь к папке в "Документах"
        }

        
        public static void FillGrid(ref DataGridView dataGridView, int dayOfWeek)      //вывод в DataGridView данных из документа с названием empType  
        {
            SetPath("Efficiency");

            int currentDayOfWeekCode = (int)DateTime.Now.DayOfWeek;

            dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;     //американская неделя начинается с воскресенья
            currentDayOfWeekCode = currentDayOfWeekCode == 0 ? 7 : currentDayOfWeekCode;

            dataGridView.ColumnCount = 24;
            dataGridView.RowCount = 1;


            if (dayOfWeek > currentDayOfWeekCode)
            {
                statsFileArr = FillStatsArray(2);   //заполнить массив данными предыдущей недели
            }
            else {
                statsFileArr = FillStatsArray(1);       //заполнить массив данными текущей недели
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

        private static string[] FillStatsArray(int index) { //вывод массива данных об определенной недели
            string[] statsArray = new string[24];
            string readLine;
            int arrayIndex = 0;


            using (StreamReader reader = new StreamReader(FilePath))
            {
                for (int i = 0; (readLine = reader.ReadLine()) != null; i++) {
                    if (24 * (index - 1) <= i) {
                        statsArray[arrayIndex] = readLine;
                        arrayIndex++;

                        if (arrayIndex == 24)
                        {
                            break;
                        }
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
                default:
                    dataGridView.Rows[0].Cells[cellIndex].Style.BackColor = System.Drawing.Color.Gray;
                    break;

            }
        }



        public static void DisplayMainStats(ref Label lblName, ref Label lblType, int currentEmployment) {

            SetPath($"Employments\\{GetValueByIndex(statsFileArr[currentEmployment])}");

            if (statsFileArr[currentEmployment] == "" || statsFileArr[currentEmployment] == " ")
            {
                lblName.Text = "ПРОПУСК";
                lblType.Text = "Похоже, что в это время вы занимались чем-то ДЕЙСТВИТЕЛЬНО полезным";
            }
            else{
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (GetValueByIndex(line, 1) == GetValueByIndex(statsFileArr[currentEmployment], 1))
                        {
                            lblName.Text = GetValueByIndex(line);
                            break;
                        }
                    }
                }

                lblType.Text = GetValueByIndex(statsFileArr[currentEmployment], 0);
            }
        }





        public static void WriteStats(string name, string statPath)    
        {
            SetPath(statPath);
            int hour = DateTime.Now.Hour;
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

        public static void CheckWeekRelevance() {
            SetPath("Common");

            Console.WriteLine(FilePath);

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




    }
}
