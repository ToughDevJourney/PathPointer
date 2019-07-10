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

        public string Business { get; set; }


        public static void WriteLineToFile(string line, string fileName)    //запись в файл
        {
            string filePath = Management.GetPath(fileName);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }
        }

        public static void DeleteLineFromFile(string lineToDel, string fileName)
        {
            string line;
            string filePath = Management.GetPath(fileName);
            using (StreamReader reader = new StreamReader(filePath))
            {
                using (StreamWriter writer = new StreamWriter(FileManagement.intermediateFile))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line != lineToDel) writer.WriteLine(line);
                    }
                }
            }

            File.Copy(FileManagement.intermediateFile, filePath, true);
            File.Delete(FileManagement.intermediateFile);
        }

    }
}
