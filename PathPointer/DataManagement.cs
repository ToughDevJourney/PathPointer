using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PathPointer
{
    public class DataManagement
    {
        public string Business { get; set; }        //DataSource
        private static string FilePath { get; set; }        //путь к документу
        private static string Schedule { get; set; }        //расписание

        public DataGridView FillGrid(string empType)      //вывод в DataGridView данных из документ с названием empType  
        {
            FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{empType}.txt");  //путь к папке "Документы"
            DataGridView dataGridBusiness = new DataGridView();     
            List<DataManagement> varCells = new List<DataManagement>();

            try    //вывод сообщения, если директива не найдена
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        varCells.Add(new DataManagement { Business = getName(line) });    //заполнение DataSource данными из документа
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                varCells.Add(new DataManagement { Business = "Отсутствует директория\nсоздайте новую деятельность" });
            }


            dataGridBusiness.DataSource = varCells;
            return dataGridBusiness;
        }


        private string getName(string line) {            //вывод только названия занятости
            if (line.Contains(" ")) {
                line = line.Remove(line.IndexOf(" "), line.Length - line.IndexOf(" "));
            }
            return line;
        }
        

        public static void WriteEmpFiles(string name)    //запись в файл неотложных занятий
        {

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(name);
            }
        }

        public static void WriteEmpFiles(string name, int hours)    //запись в файл видов отдыха
        {      

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(name);
            }
        }

        public static void WriteEmpFiles(string name, int hours, string wantedTime) //запись в файл целей
        {      

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                 sw.WriteLine(name);
            }
        }

    }
}
