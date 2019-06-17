using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PathPointer
{
    class CurrentDateInfo : Management
    {
        private static int weekNumber;
        private static int dayOfWeek;

        public static int DayOfWeek
        {
            get {
                dayOfWeek = (int)DateTime.Now.DayOfWeek;
                dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;
                return dayOfWeek;
            }
        }

        public static int WeekNumber
        {
            get
            {
                var cal = new GregorianCalendar();
                weekNumber = cal.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, System.DayOfWeek.Monday);
                return weekNumber;
            }
        }

        public static void CheckWeekRelevance()
        {
            SetPath("Common");



            int fileWeekNumber;


            string[] commonFileArr = File.ReadAllLines(FilePath);

            for (int i = 0; i < commonFileArr.Length; i++)
            {
                if (GetValueByIndex(commonFileArr[i], 0) == "Week Number")
                {
                    fileWeekNumber = Convert.ToInt32(GetValueByIndex(commonFileArr[i], 1));
                    if (fileWeekNumber != CurrentDateInfo.WeekNumber)
                    {
                        commonFileArr[i] = $"Week Number!{CurrentDateInfo.WeekNumber}";

                        File.WriteAllLines(FilePath, commonFileArr);

                        AddNewWeekIntoEfficiency();
                        break;
                    }
                }
            }
        }


        public static void AddNewWeekIntoEfficiency()
        {
            SetPath("Efficiency");
            string fileContainer = "";
            string intermediateFile = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PathPointer\\Eff Intermediate.txt";
            const int hoursADay = 24;

            File.Copy(FilePath, intermediateFile);
            File.Delete(FilePath);

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                for (int j = 0; j < hoursADay; j++)
                {
                    writer.WriteLine($"{j}:00;");
                }

                using (StreamReader reader = new StreamReader(intermediateFile))
                {
                    while ((fileContainer = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(fileContainer);
                    }
                }
            }

            File.Delete(intermediateFile);
        }

    }
}
