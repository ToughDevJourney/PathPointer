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
                        Employments.varCells.Add(new DataManagement { Business = GetName(line) });    //заполнение DataSource данными из документа
                    }
                }
            }
            catch
            {
                emptyGridMessage();
                Console.WriteLine("Эксепшн тут1");
            }

            if (Employments.varCells.Count == 0) {
                emptyGridMessage();
            }

            dataGridBusiness.DataSource = Employments.varCells;
            return dataGridBusiness;
        }

        public static int GetCode(){       //поиск кода деятельности
            int code = 0;
            string codePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\Codes.txt");
            try
            {
                string[] fileRows = File.ReadAllLines(FilePath);        //занесение данных из файла в массив
                for (int i = 0;i < fileRows.Length;i++) {
                    if (GetName(fileRows[i]) == Employments.empType) {
                        code = Convert.ToInt32(fileRows[i].Remove(0, GetName(fileRows[i]).Length)) + 1;     //вывод кода из файла
                        fileRows[i] = fileRows[i].Remove(GetName(fileRows[i]).IndexOf("!"), fileRows[i].Length) + code;     //
                        break;
                    }
                }
                File.WriteAllLines(FilePath, fileRows);     //Сохранение данных в файл из массива
            }
            catch {

                code = 0;
            }
            return code;
        }

        private static void emptyGridMessage (){        //Если, данные или документ отстутствуют
            Employments.varCells.Add(new DataManagement { Business = "Ого! Похоже, что вы новенький!\nДобавьте новую деятельность!" });
        }

        private static string GetName(string line) {            //вывод только названия занятия
            if (line.Contains("!")) {
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
                        if (String.Compare(GetName(line), delLine) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
             }

            File.Copy(interFile, FilePath, true);
            File.Delete(interFile);
            
            
            emp.FillGrid();
        }


        public static void EditEmpFiles(string editLine, int rowIndex) {
            string[] fileRows = File.ReadAllLines(FilePath);        //занесение данных из файла в массив
            fileRows[rowIndex] = fileRows[rowIndex].Remove(0, GetName(fileRows[rowIndex]).Length); // удаление старого наименование
            fileRows[rowIndex] = fileRows[rowIndex].Insert(0, editLine);        //добавление нового наименования
            File.WriteAllLines(FilePath, fileRows);     //Сохранение данных в файл из массива
        }




    }
}
