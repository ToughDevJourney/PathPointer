using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public partial class Achivements : Form
    {
        public Achivements()
        {
            InitializeComponent();


        }

        private void Achivements_Load(object sender, EventArgs e)
        {
            ColorButton();
          
        }



        private void PlaceAchivementInfo(object sender, EventArgs e)
        {
            Achivement achivement = new AchiveAddRest();
            Button button = (Button)sender;

            switch(button.Name){
                case "BtnAddRest":
                    achivement = new AchiveAddRest();
                    break;
                case "BtnNoRestAllDay":
                    achivement = new AchiveNoRestWholeDay();
                    break;
                case "BtnAddGoal":
                    achivement = new AchiveAddGoal();
                    break;
                case "BtnSpendHourOnGoal":
                    achivement = new AchiveOneHourToGoal();
                    break;
                case "BtnDoneGoal":
                    achivement = new AchiveCompleteGoal();
                    break;
                case "BtnAddFun":
                    achivement = new AchiveAddFun();
                    break;
                case "BtnNoFunAllDay":
                    achivement = new AchiveNoFunAllDay();
                    break;
            }

            PBachivementImage.BackgroundImage = button.BackgroundImage;

            lblAchivementName.Text = achivement.AchivementName;
            lblAchivementDescription.Text = achivement.Description;
            lblAchivementStatus.Text = achivement.IsAchived == true ? "Достижение получено" : "Достижение не получено";
        }


        private void ColorButton() {
            List<Achivement> achivements = new List<Achivement>();
            achivements.Add(new AchiveAddFun() { AchivementButton = BtnAddFun, ArrowToNextAchivement = BtnAddFunToNoFunAllDay});
            achivements.Add(new AchiveNoFunAllDay() { AchivementButton = BtnNoFunAllDay });

            achivements.Add(new AchiveAddGoal() { AchivementButton = BtnAddGoal, ArrowToNextAchivement = BtnAddGoalToGoalHour });
            achivements.Add(new AchiveOneHourToGoal() { AchivementButton = BtnSpendHourOnGoal, ArrowToNextAchivement = BtnHourGoalToCompleteGoal });
            achivements.Add(new AchiveCompleteGoal() { AchivementButton = BtnDoneGoal });

            achivements.Add(new AchiveAddRest() { AchivementButton = BtnAddRest, ArrowToNextAchivement = BtnAddRestToNoRestAllDay });
            achivements.Add(new AchiveNoRestWholeDay() { AchivementButton = BtnNoRestAllDay });


            Color doneAchivementColor = Color.FromArgb(255, 120, 120, 140);
            Color arrowToNexAchivementsColor = Color.FromArgb(255, 170, 170, 210);

            foreach (Achivement achivement in achivements) {
                if (achivement.IsAchived)
                {
                    achivement.AchivementButton.BackColor = doneAchivementColor;
                    if (achivement.ArrowToNextAchivement != null) achivement.ArrowToNextAchivement.BackColor = arrowToNexAchivementsColor;
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = MainMenu.CreateInstance(this);
        }

        private void Achivements_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }
    }
}
