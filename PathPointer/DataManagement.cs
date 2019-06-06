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
    public class DataManagement : Management
    {
        public string Business { get; set; }        //DataSource
        private static int code;
        private static string empType;

        public static string EmpType {
            get {
                return empType;
            }
            set {
                SetPath(value);
                empType = value;
            }
        }

        public static int Code {        //считывание последнего кода приложения
            get {
                string codePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\Codes.txt");     //путь к кодам занятий
                try
                {
                    string[] fileRows = File.ReadAllLines(codePath);        //занесение данных из файла в массив
                    for (int i = 0; i < fileRows.Length; i++)
                    {

                        if (GetValueByIndex(fileRows[i]) == Employments.empType)
                        {
                            code = Convert.ToInt32(fileRows[i].Substring((GetValueByIndex(fileRows[i]).Length) + 1));     //вывод кода из файла
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


            DataGridView dataGridBusiness = new DataGridView();

            varCells = new BindingList<DataManagement>();
            try    //вывод сообщения, если директива не найдена
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        varCells.Add(new DataManagement { Business = GetValueByIndex(line) });    //заполнение DataSource данными из документа
                    }
                }
            }
            catch
            {
                EmptyGridMessage(ref varCells);
            }

            if (varCells.Count == 0) EmptyGridMessage(ref varCells);


            dataGridBusiness.DataSource = varCells;
            return dataGridBusiness;
        }


        private static void EmptyGridMessage(ref BindingList<DataManagement> varCells)
        {        //Если, данные или документ отстутствуют
            varCells.Add(new DataManagement { Business = "Ого! Похоже, что вы новенький!\nДобавьте новую деятельность!" });
        }

        public static void WriteEmpFiles(string name, string empType)    //запись в файл
        {
            EmpType = empType;

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(name);
            }
        }

        public static void DeleteEmpFiles(string delLine)
        {
            string line;
            string interFile = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\Intermediate.txt"); //промежуточный для удаления файл


            using (StreamReader reader = new StreamReader(FilePath))
            {
                using (StreamWriter writer = new StreamWriter(interFile))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(GetValueByIndex(line), delLine) == 0)
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
            fileRows[rowIndex] = fileRows[rowIndex].Remove(0, GetValueByIndex(fileRows[rowIndex]).Length);  //удаление старого наименования
            fileRows[rowIndex] = fileRows[rowIndex].Insert(0, editLine);        //добавление нового наименования
            File.WriteAllLines(FilePath, fileRows);     //Сохранение данных в файл из массива
        }

        public static string checkEmploymentFormat(string formatChecking){
            while (true) {
                if (formatChecking.Contains("!")) formatChecking = formatChecking.Remove(formatChecking.IndexOf("!"), 1);
                else if (formatChecking.Contains(";")) formatChecking = formatChecking.Remove(formatChecking.IndexOf(";"), 1);
                else break;
            }

            return formatChecking;
        }

    }
}
