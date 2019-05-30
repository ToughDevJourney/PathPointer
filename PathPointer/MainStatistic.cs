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
    class MainStatistic
    {

        public string Business { get; set; }        //элемент DataSource
        public string Business2 { get; set; }        //элемент DataSource
        private static string FilePath { get; set; }        //путь к документу


        private static void setPath(string empType) {
            FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\{empType}.txt");  //путь к папке в "Документах"
        }





        public static void WriteStats(string name, string statPath)    //запись в файл
        {
            setPath(statPath);
            int hour = DateTime.Now.Hour;
            int dayOfWeek = Convert.ToInt32(DateTime.Now.DayOfWeek);

            string[] efficiency = File.ReadAllLines(FilePath);
            string checkDay = efficiency[hour];


            for (int i = 0; i<8;i++) {
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
