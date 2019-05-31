using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        private static void SetPath(string empType) {
            FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\{empType}.txt");  //путь к папке в "Документах"
        }

        
        public static void FillGrid(string empType, ref DataGridView dataGridView, int dayOfWeek)      //вывод в DataGridView данных из документа с названием empType  
        {
            Console.WriteLine("check");
            EmpType = empType;
            Console.WriteLine(dayOfWeek);
            dayOfWeek++;
            dataGridView.ColumnCount = 24;
            dataGridView.RowCount = 1;

            SetPath();
            string[] statsFileArr = File.ReadAllLines(FilePath);




            for (int i = 0; i<24; i++) {
                for (int symbCount = 0; symbCount < dayOfWeek; symbCount++) {
                   
                    statsFileArr[i] = statsFileArr[i].Remove(0, (statsFileArr[i].IndexOf(";") + 1));

                }
                if (statsFileArr[i].Contains(";")) {
                    statsFileArr[i] = statsFileArr[i].Remove((statsFileArr[i].IndexOf(";")), statsFileArr[i].Length - statsFileArr[i].IndexOf(";"));

                }

                if (statsFileArr[i] != "")
                {
                    dataGridView.Rows[0].Cells[i].Value = statsFileArr[i];
                }
                else {
                    dataGridView.Rows[0].Cells[i].Value = "-";
                }
            }

        }
        




        private static void EmptyGridMessage(ref BindingList<MainStatistic> varCells) {


        }


        public static void WriteStats(string name, string statPath)    //запись в файл
        {
            SetPath(statPath);
            int hour = DateTime.Now.Hour;
            int dayOfWeek = Convert.ToInt32(DateTime.Now.DayOfWeek);

            string[] efficiency = File.ReadAllLines(FilePath);
            string checkDay = efficiency[hour];

            for (int i = 0; i<8;i++) {      //заполнение дней недели пропусками, если пользователь в это время был неактивен
                if (checkDay.Contains(";"))
                {
                    checkDay = checkDay.Remove(checkDay.IndexOf(";"), 1);
                }
                else {
                    Console.WriteLine(checkDay);
                    Console.WriteLine(dayOfWeek);

                    if (dayOfWeek == 0)
                    {
                        efficiency[hour] += " ;";
                    }
                    else if (dayOfWeek > i)
                    {
                        efficiency[hour] += " ;";
                    }
                    else {
                        break;
                    }
                    

                }
            }

            efficiency[hour] += $"{name};";

            File.WriteAllLines(FilePath, efficiency);

        }




    }
}
