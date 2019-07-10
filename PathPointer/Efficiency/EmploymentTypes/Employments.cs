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
    public abstract class Employments : DayEfficiency
    {
        public string FilePath { get { return Management.GetPath($"Employments\\{EmpType}"); } }
        public abstract int HoursGoal { get; set; }
        public abstract int HoursDone { get; set; }
        public DateTime DateGoal { get; set; }
        protected IEmploymentsOtherTypes _otherEmployment = null;

        protected abstract void SetEmploymentValues(string fullEmpLine);

        protected void GetEmploymentValuesFromType()
        {
            Name = _otherEmployment.EmploymentName;
            Code = _otherEmployment.EmploymentCode;
            TypeDescription = _otherEmployment.TypeDescription;
        }

        public void SetEmploymentValuesByName(string name)
        {
            string employment = FindEmploymentByName(name);
            SetEmploymentValues(employment);
        }

        public void SetEmploymentValuesByCode(string code)
        {
            if (_otherEmployment == null)
            {
                string employment = FindEmploymentByCode(code);
                if (employment == null) employment = FindEmploymentByCode(code, true);
                SetEmploymentValues(employment);
            }
            else GetEmploymentValuesFromType();
        }

        public static Employments GetEmploymentType(string employmentLine)
        {
            string empType = Management.GetValueByIndex(employmentLine);
            string code = Management.GetValueByIndex(employmentLine, 1);
            Employments employment = null;
            IEmploymentsOtherTypes employmentType = null;

            switch (code) {
                case Codes.anotherEmpCode:
                    employmentType = new EmploymentsTypeOther();
                    break;
                case Codes.sleep:
                    employmentType = new EmploymentsTypeSleep();
                    break;
            }
           
            switch (empType) {
                case "Business":
                    employment = new EmploymentsBusiness(employmentType);
                    break;
                case "Goals":
                    employment = new EmploymentsGoals(employmentType);
                    break;
                case "Rest":
                    employment = new EmploymentsRest(employmentType);
                    break;
                case "Fun":
                    employment = new EmploymentsFun(employmentType);
                    break;
            }

            employment.SetEmploymentValuesByCode(code);
            return employment;
        }

        public int GetLastCode //считывание последнего кода приложения
        {        
            get
            {
                string codePath = Management.GetPath("Employments\\Codes");
                int code = 0;

                string[] empCodes = File.ReadAllLines(codePath);   
                for (int i = 0; i < empCodes.Length; i++)
                {
                    if (Management.GetValueByIndex(empCodes[i]) == EmpType)
                    {
                        code = Convert.ToInt32(Management.GetValueByIndex(empCodes[i], 1));     //вывод кода из файла
                        empCodes[i] = empCodes[i].Replace((code).ToString(), (++code).ToString());     //замена старого кода на новый
                        break;
                    }
                }

                File.WriteAllLines(codePath, empCodes);  
                return code;
            }
        }



        public DataGridView FillGrid(ref BindingList<DataManagement> varCells, bool addAnotherOpt = false)      //вывод в DataGridView данных из документа с названием empType  
        {
            string readLine;

            DataGridView dataGridBusiness = new DataGridView();
            varCells = new BindingList<DataManagement>();

            using (StreamReader sr = new StreamReader(FilePath))
            {
                while ((readLine = sr.ReadLine()) != null) varCells.Add(new DataManagement { Business = Management.GetValueByIndex(readLine) });
            }

            if (addAnotherOpt == true) varCells.Add(new DataManagement { Business = "Другое" });
            else if (varCells.Count == 0) varCells.Add(new DataManagement { Business = Texts.emptyEmpFile });

            dataGridBusiness.DataSource = varCells;
            return dataGridBusiness;
        }

        public void WriteEmploymentToFile(string employmentLine, bool writeToArchive = false)    //запись в файл
        {
            string filePath = $"Employments\\{EmpType}";
            if (writeToArchive) filePath = $"Employments\\Archive\\{EmpType}";

            DataManagement.WriteLineToFile(employmentLine, filePath);
        }

        public void DeleteEmpFromFile(string nameOfEmploymentToDel)
        {
            string employmentToDel = FindEmploymentByName(nameOfEmploymentToDel);
            DataManagement.DeleteLineFromFile(employmentToDel, $"Employments\\{EmpType}");
            WriteEmploymentToFile(employmentToDel, true);
        }

        public void EditEmpFiles(string employmentToEdit, int rowIndex)
        {
            string[] empsFile = File.ReadAllLines(FilePath);
            empsFile[rowIndex] = empsFile[rowIndex].Replace(Management.GetValueByIndex(empsFile[rowIndex]), employmentToEdit); //замена старого названия на новое
            File.WriteAllLines(FilePath, empsFile);
        }

        public string CheckEmploymentNameFormat(string nameToCheck)
        {
            string[] empArr = File.ReadAllLines(FilePath);

            if (nameToCheck.Contains("!") || nameToCheck.Contains(";")) MessageBox.Show("Системные знаки были удалены", "Упс");

            while (true)
            {
                if (nameToCheck.Contains("!")) nameToCheck = nameToCheck.Remove(nameToCheck.IndexOf("!"), 1);
                else if (nameToCheck.Contains(";")) nameToCheck = nameToCheck.Remove(nameToCheck.IndexOf(";"), 1);
                else break;
            }

            for (int i = 0; i < empArr.Length; i++)
            {
                if (Management.GetValueByIndex(empArr[i]) == nameToCheck)
                {
                    nameToCheck += " новый";
                    i = -1; //в случае, если уже существует деятельность с окончанием " новый", окончание добавляется еще раз 
                }
            }

            return nameToCheck;
        }

        protected string FindEmploymentByName(string name)
        {
            string[] empTypeFileArr = File.ReadAllLines(FilePath);

            for (int i = 0; i < empTypeFileArr.Length; i++)
            {
                if (Management.GetValueByIndex(empTypeFileArr[i]) == name)
                {
                    name = empTypeFileArr[i];
                    break;
                }
            }

            return name;
        }

        public string FindEmploymentByCode(string code, bool searchArchive = false)
        {
            string employment = null;
            string filePath;
            
            if (searchArchive) filePath = Management.GetPath($"Employments\\Archive\\{EmpType}");
            else filePath = Management.GetPath($"Employments\\{EmpType}");    //ищем в документе с указанным видом деятельности информацию о занятии

            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((employment = sr.ReadLine()) != null)
                {
                    if (Management.GetValueByIndex(employment, 1) == code) return employment;  //проверка сходства кода из файла и кода из списка деятельности
                }
            }
            return employment;
        }

        public string CheckEmploymentFormat(string formatChecking)
        {
            string[] empArr = File.ReadAllLines(FilePath);

            if (formatChecking.Contains("!") | formatChecking.Contains(";")) MessageBox.Show("Системные знаки были удалены", "Упс");

            while (true)
            {
                if (formatChecking.Contains("!")) formatChecking = formatChecking.Remove(formatChecking.IndexOf("!"), 1);
                else if (formatChecking.Contains(";")) formatChecking = formatChecking.Remove(formatChecking.IndexOf(";"), 1);
                else break;
            }
                       
            for (int i = 0; i < empArr.Length; i++)
            {
                if (Management.GetValueByIndex(empArr[i]) == formatChecking)
                {
                    formatChecking += " новый";
                    i = -1; //в случае, если уже существует деятельность с окончанием " новый", такое окончание добавляется еще раз 
                }
            }

            return formatChecking;
        }

        public int CountDoneHours(string employmentCode, int hoursGoal = 0)
        {
            int hoursDone = 0;
            int weekHours = 0;
            string readLine;
            string employment;

            using (StreamReader reader = new StreamReader(FileManagement.EfficiencyFile))
            {
                while ((readLine = reader.ReadLine()) != null)
                {
                    for (int i = 1; i <= 7; i++)
                    {
                        employment = Management.GetValueByIndex(readLine, i, ";");
                        if (employment == "") break;
                        else if ($"{EmpType}!{employmentCode}" == employment)
                        {
                            hoursDone++;
                            if (hoursDone >= hoursGoal && hoursGoal != 0) break;
                        }
                    }

                    if (EmpType == "Rest" || EmpType == "Fun")
                    {
                        weekHours++;
                        if (weekHours == 24) break;
                    }

                }
            }
            return hoursDone;
        }

    }
}
