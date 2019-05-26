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
    public class DataManagement
    {
        public string Business { get; set; }        //DataSource
        private static string FilePath { get; set; }        //путь к документу
        private static string Schedule { get; set; }        //расписание

        public static DataGridView FillGrid()      //вывод в DataGridView данных из документа с названием empType  
        {

            FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\{Employments.empType}.txt");  //путь к папке "Документы"
            
            DataGridView dataGridBusiness = new DataGridView();
            Employments.varCells = new BindingList<DataManagement>();
            try    //вывод сообщения, если директива не найдена
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Employments.varCells.Add(new DataManagement { Business = getName(line) });    //заполнение DataSource данными из документа
                    }
                }
            }
            catch
            {
                Employments.varCells.Add(new DataManagement { Business = "Ого! Похоже, что вы новенький!\nДобавьте новую деятельность!" });
            }

            dataGridBusiness.DataSource = Employments.varCells;
            return dataGridBusiness;
        }


        private static string getName(string line) {            //вывод только названия занятости
            if (line.Contains("!")) {
                line = line.Remove(line.IndexOf("!"), line.Length - line.IndexOf("!"));
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


        public static void DeleteEmpFiles(string delLine)
        {
            string line;
            string interFile = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\intermediate.txt"); //промежуточный для удаления файл
            Employments emp = new Employments();

            using (StreamReader reader = new StreamReader(FilePath))
             {
                using (StreamWriter writer = new StreamWriter(interFile))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(getName(line), delLine) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
             }

            File.Copy(interFile, FilePath, true);
            File.Delete(interFile);


            emp.FillGrid();
        }





    }
}
