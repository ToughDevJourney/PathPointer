using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PathPointer
{
    public class DataLists
    {
        public string Business { get; set; }

        public DataGridView FillGrid(string empType)        //вывод в DataGridView данных из документ с названием empType
        {              
            DataGridView dataGridBusiness = new DataGridView();
            
            string path = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{empType}.txt");    //путь к папке "Документы"
            List<DataLists> varCells = new List<DataLists>();
            try
            {


                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        varCells.Add(new DataLists { Business = line });
                    }

                }
            }
            catch
            {
                varCells.Add(new DataLists { Business = "Отсутствует директория\nсоздайте новую деятельность" });
            }

            dataGridBusiness.DataSource = varCells;
            return dataGridBusiness;
        }
    }
}
