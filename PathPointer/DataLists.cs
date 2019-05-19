using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public DataGridView FillGrid(string empType)
        {              //вывод в DataGridView данных из документ с названием empType
            DataGridView dataGridBusiness = new DataGridView();
            string path = (@"D:\" + empType + ".txt");
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {

                string line;
                List<DataLists> varCells = new List<DataLists>();

                while ((line = sr.ReadLine()) != null)
                {
                    varCells.Add(new DataLists { Business = line });
                }
                dataGridBusiness.DataSource = varCells;
            }
            return dataGridBusiness;
        }
    }
}
