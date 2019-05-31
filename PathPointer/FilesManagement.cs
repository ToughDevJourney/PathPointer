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
        public static string EmpType { get; set; }


        protected static void SetPath()
        {
            FilePath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\{EmpType}.txt");  //путь к папке "Документы"
        }


    }
}
