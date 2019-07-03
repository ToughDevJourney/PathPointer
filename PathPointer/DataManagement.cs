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



        public static DataGridView FillGrid(string empType, ref BindingList<DataManagement> varCells, bool timeSpentForm = false)      //вывод в DataGridView данных из документа с названием empType  
        {
            EmpType = empType;
            string readLine;

            DataGridView dataGridBusiness = new DataGridView();

            varCells = new BindingList<DataManagement>();
            try    
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while ((readLine = sr.ReadLine()) != null) varCells.Add(new DataManagement { Business = GetValueByIndex(readLine) });
                }
            }
            catch { }

            if(timeSpentForm == true) varCells.Add(new DataManagement { Business = "Другое" });
            else if (varCells.Count == 0) varCells.Add(new DataManagement { Business = Texts.emptyEmpFile });


            dataGridBusiness.DataSource = varCells;
            return dataGridBusiness;
        }



        public static void WriteToFile(string name, string fileName)    //запись в файл
        {
            EmpType = fileName;

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(name);
            }
        }

        public static void DeleteLineFromFile(string delLine, string filePath)
        {
            EmpType = $"{filePath}";
            string line;
            string interFile = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\Intermediate.txt"); //промежуточный для удаления файл
            string archive = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Employments\\Archive\\{Employments.empType}.txt"); //промежуточный для удаления файл

                     
            using (StreamReader reader = new StreamReader(FilePath))
            {
                using (StreamWriter writer = new StreamWriter(interFile))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(GetValueByIndex(line), delLine) == 0)
                        {
                            using (StreamWriter archiveWriter = File.AppendText(archive)) archiveWriter.WriteLine(line);
                            continue;
                        } 
                        writer.WriteLine(line);
                    }
                }
            }

            File.Copy(interFile, FilePath, true);
            File.Delete(interFile);
        }


        public static void EditEmpFiles(string editLine, int rowIndex) {
            string[] fileRows = File.ReadAllLines(FilePath);
            fileRows[rowIndex] = fileRows[rowIndex].Replace(GetValueByIndex(fileRows[rowIndex]), editLine); //замена старого названия на новое
            File.WriteAllLines(FilePath, fileRows);
        }

        public static string CheckEmploymentFormat(string formatChecking){
            string[] empArr = File.ReadAllLines(FilePath);

            if(formatChecking.Contains("!") | formatChecking.Contains(";")) MessageBox.Show("Системные знаки были удалены", "Упс");

            while (true)
            {
                if (formatChecking.Contains("!")) formatChecking = formatChecking.Remove(formatChecking.IndexOf("!"), 1);
                else if (formatChecking.Contains(";")) formatChecking = formatChecking.Remove(formatChecking.IndexOf(";"), 1);                
                else break;
            }



            for (int i = 0; i<empArr.Length; i++) {
                if (GetValueByIndex(empArr[i]) == formatChecking) {
                    formatChecking += " новый";
                    i = -1;
                }
            }

            return formatChecking;
        }

        public static void SetEmpAsConst(int empCode) {
            string[] goalsArray = File.ReadAllLines(FilePath);

            for (int i = 0; i<goalsArray.Length; i++) {
                if (Convert.ToInt32(GetValueByIndex(goalsArray[i]), 1) == empCode) {
                    goalsArray[i] = $"{GetValueByIndex(goalsArray[i])}!{GetValueByIndex(goalsArray[i], 1)}!0!{GetValueByIndex(goalsArray[i], 3)}!";
                    break;
                }
            }
        }


        public static bool IsLineInFile(string line, string fileName = null, bool onlyFirstNameCheck = false) {
            if (fileName != null) SetPath(fileName);
            string readLine;

            using (StreamReader reader = new StreamReader(FilePath)) {
                while ((readLine = reader.ReadLine()) != null) {
                    readLine = onlyFirstNameCheck == true ? GetValueByIndex(readLine) : readLine;
                    if (readLine == line) return true;
                }
            }
            return false;
        }

    }
}
