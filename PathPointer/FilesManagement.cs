using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public class FilesManagement
    {
        protected static string FilePath { get; set; }        //путь к документу





        public static string GetName(string line)
        {            //вывод только названия занятия
            if (line.Contains("!"))
            {
                line = line.Remove(line.IndexOf("!"), line.Length - line.IndexOf("!"));
            }
            return line;
        }

        public static string GetValueByIndex(string line, int index) {

            for (int i = 0; i < index; i++) {
                if (line.Contains("!"))
                {
                    line = line.Remove(0, (line.IndexOf("!")+1));
                }
            }

            if (line.Contains("!"))
            {
                line = line.Remove(line.IndexOf("!"), line.Length - line.IndexOf("!"));
            }

            return line;
        }


    }
}
