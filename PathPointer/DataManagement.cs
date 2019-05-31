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
    public class DataManagement : FilesManagement
    {
        public string Business { get; set; }        //DataSource

        private static int code;


        public static int Code {        //считывание последнего кода приложения
            get {
                string codePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\Codes.txt");     //путь к кодам занятий
                try
                {
                    string[] fileRows = File.ReadAllLines(codePath);        //занесение данных из файла в массив
                    for (int i = 0; i < fileRows.Length; i++)
                    {

                        if (GetName(fileRows[i]) == Employments.empType)
                        {
                            code = Convert.ToInt32(fileRows[i].Remove(0, (GetName(fileRows[i]).Length) + 1));     //вывод кода из файла
                            fileRows[i] = fileRows[i].Replace((code).ToString(), (++code).ToString());     //замена старого кода на новый
                            break;
                        }
                    }
                    File.WriteAllLines(codePath, fileRows);     //сохранение данных в файл из массива
                }
                catch
                {
                    code = 0;
                }
                return code;
            }
        }




        public static DataGridView FillGrid(string empType, ref BindingList<DataManagement> varCells)      //вывод в DataGridView данных из документа с названием empType  
        {
            EmpType = empType;
            SetPath();

            DataGridView dataGridBusiness = new DataGridView();

            varCells = new BindingList<DataManagement>();
            try    //вывод сообщения, если директива не найдена
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        varCells.Add(new DataManagement { Business = GetName(line) });    //заполнение DataSource данными из документа
                    }
                }
            }
            catch
            {
                EmptyGridMessage(ref varCells);
            }

            if (varCells.Count == 0) {
                EmptyGridMessage(ref varCells);
            }

            dataGridBusiness.DataSource = varCells;
            return dataGridBusiness;
        }


        private static void EmptyGridMessage (ref BindingList<DataManagement> varCells)
        {        //Если, данные или документ отстутствуют
            varCells.Add(new DataManagement { Business = "Ого! Похоже, что вы новенький!\nДобавьте новую деятельность!" });
        }

        private static string GetName(string line) {            //вывод только названия занятия
            if (line.Contains("!")) {
                line = line.Remove(line.IndexOf("!"), line.Length - line.IndexOf("!"));
            }
            return line;
        }

        public static int FindCode(string name) {

            string line;
            using (StreamReader reader = new StreamReader(FilePath))
            {
                while ((line =  reader.ReadLine()) != null)
                {
                    if (String.Compare(GetName(line), name) == 0)
                        break;
                }
            }

            line = line.Remove(0, (line.IndexOf("!")+1));

            line = line.Remove(line.IndexOf("!"), (line.Length - line.IndexOf("!")));
            code = Convert.ToInt32(line);

            return code;
        }
        

        public static void WriteEmpFiles(string name, string empType)    //запись в файл
        {
            EmpType = empType;
            SetPath();

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(name);
            }
        }


        public static void DeleteEmpFiles(string delLine)
        {
            string line;
            string interFile = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\intermediate.txt"); //промежуточный для удаления файл


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
        }


        public static void EditEmpFiles(string editLine, int rowIndex) {
            string[] fileRows = File.ReadAllLines(FilePath);        //занесение данных из файла в массив
            fileRows[rowIndex] = fileRows[rowIndex].Remove(0, GetName(fileRows[rowIndex]).Length);  //удаление старого наименования
            fileRows[rowIndex] = fileRows[rowIndex].Insert(0, editLine);        //добавление нового наименования
            File.WriteAllLines(FilePath, fileRows);     //Сохранение данных в файл из массива
        }

    }
}
