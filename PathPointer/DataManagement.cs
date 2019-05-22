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
        public string Business { get; set; }
        private string empType;

        public DataGridView FillGrid(string empType)        //вывод в DataGridView данных из документ с названием empType
        {
            this.empType = empType;
            DataGridView dataGridBusiness = new DataGridView();
            
            string readPath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{empType}.txt");    //путь к папке "Документы"
            List<DataManagement> varCells = new List<DataManagement>();
            try    //вывод сообщения, если директива не найдена
            {


                using (StreamReader sr = new StreamReader(readPath))
                {


                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        varCells.Add(new DataManagement { Business = line });    //заполнение DataSource данными из документа
                    }

                }
            }
            catch
            {
                varCells.Add(new DataManagement { Business = "Отсутствует директория\nсоздайте новую деятельность" });
            }

            dataGridBusiness.DataSource = varCells;
            return dataGridBusiness;
        }


        public void WriteEmpFiles(string name, string wantedTime, int hours) {      //запись в файл
            string writePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\goals.txt");
        //    if (!File.Exists(writePath)) {
           //     File.Create(writePath);
          //  }

                using (StreamWriter sw = new StreamWriter(writePath, true))
                {
                    sw.WriteLine(name);
                }

        }




    }
}
