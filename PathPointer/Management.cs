using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public abstract class Management
    {
        protected static string FilePath { get; set; }        //путь к документу

        protected static void SetPath(string empType = "")
        {
            if (empType != "") FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\{empType}.txt");  //путь к папке в "Документах"
            else FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer");
        }


        protected static string GetValueByIndex(string line)
        {            //вывод только названия занятия
            if (line.Contains("!"))
            {
                line = line.Substring(0, line.IndexOf("!")); //.Remove(line.IndexOf("!"), line.Length - line.IndexOf("!"));
            }
            return line;
        }

        protected static string GetValueByIndex(string line, int index) {

            for (int i = 0; i < index; i++) {
                if (line.Contains("!"))
                {
                    line = line.Remove(0, (line.IndexOf("!")+1));
                }
            }

            if (line.Contains("!"))
            {
                line = line.Substring(0, line.IndexOf("!"));
            }

            return line;
        }


    }
}
