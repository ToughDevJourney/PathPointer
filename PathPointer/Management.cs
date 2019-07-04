using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public abstract class Management
    {
        public static string FilePath { get; set; }        //путь к документу

        public static void SetPath(string empType = "")
        {
            if (empType != "") FilePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\{empType}.txt";  //путь к папке в "Документах"
            else FilePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer";
        }


        public static string GetValueByIndex(string line, int index = 0, string symbol = "!") {

            for (int i = 0; i < index; i++) {
                if (line.Contains(symbol))
                {
                    line = line.Remove(0, (line.IndexOf(symbol) +1));
                }
            }

            if (line.Contains(symbol))
            {
                line = line.Substring(0, line.IndexOf(symbol));
            }

            return line;
        }


    }
}
