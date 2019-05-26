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
            FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\efficiency.txt");  //путь к папке в "Документах"
        }

        public static DataGridView FillGrid(string empType)      //вывод в DataGridView данных из документа с названием empType  
        {
            setPath(empType);
            int rowsCount = 0;

            DataGridView dataGridView = new DataGridView();

            BindingList<MainStatistic> varCells = new BindingList<MainStatistic>();
            try    
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null || rowsCount >= 7)
                    {
                        varCells.Add(new MainStatistic { Business = GetName(line), Business2 = GetName(line) });    //заполнение DataSource данными из документа
                        rowsCount++;
                    }
                }
            }
            catch
            {
                if (!File.Exists(FilePath)) {
                    File.Create(FilePath);
                }     //вывод сообщения, если директива не найдена
            }


            dataGridView.DataSource = Employments.varCells;
            return dataGridView;
        }



        private static string GetName(string line)
        {            //вывод только названия занятия
            if (line.Contains("!"))
            {
                line = line.Remove(line.IndexOf("!"), line.Length - line.IndexOf("!"));
            }
            return line;
        }


        public static void WriteEmpFiles(string name)    //запись в файл
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(name);
            }
        }
    }
}
