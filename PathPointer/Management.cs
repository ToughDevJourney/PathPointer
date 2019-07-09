using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    public static class Management
    {
        public static string GetPath(string empType = "", bool folderPath = false)
        {
            string filePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer";
            if (empType != "" && folderPath == false) filePath += $"\\{empType}.txt";
            else if (empType != "" && folderPath == true) filePath += $"\\{empType}";
            return filePath;
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
