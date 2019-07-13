using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public abstract class Achivement
    {
        public abstract string AchivementName { get; }
        public abstract string AchivementFileName { get; }
        public bool IsAchived { get; set; }
        public abstract string Description { get; }

        public Button AchivementButton { get; set; }
        public Button ArrowToNextAchivement { get; set; }
        public abstract Achivement PreviousAchivement { get; }

        protected StatsManagement stats = new StatsManagement();
        protected DayEfficiency[] dayEfficiency;

        public abstract void CheckCondition();

        protected Achivement() {
            CheckIsAchivementDone();
            if (IsAchived && ArrowToNextAchivement != null) ArrowToNextAchivement.BackColor = Color.LightBlue;
        }

        public void CheckIsAchivementDone(){
            string readLine;
            using (StreamReader reader = new StreamReader(FileManagement.AchivementsFile))
            {
                while ((readLine = reader.ReadLine()) != null) {
                    if (Management.GetValueByIndex(readLine) == AchivementFileName) {
                        IsAchived = Management.GetValueByIndex(readLine, 1) == Codes.fileTrue ? true : false;
                        break;
                    }
                }
            }

            if (readLine == null) AddAchivementToFile();
        }

        private void AddAchivementToFile() {
            using (StreamWriter writer = File.AppendText(FileManagement.AchivementsFile))
            {
                writer.WriteLine($"{AchivementName}!0");
            }
        }

        protected void DoneAchivement() {
            if (!IsAchived) {
                string readAchivementFileName;
                string[] achivementsArray = File.ReadAllLines(FileManagement.AchivementsFile);

                for (int i = 0; i<achivementsArray.Length; i++) {
                    readAchivementFileName = Management.GetValueByIndex(achivementsArray[i]);
                    if (readAchivementFileName == AchivementFileName) {
                        achivementsArray[i] = $"{AchivementFileName}!1";
                        IsAchived = true;
                        break;
                    }
                }

                File.WriteAllLines(FileManagement.AchivementsFile, achivementsArray);
            }
        }






    }
}
