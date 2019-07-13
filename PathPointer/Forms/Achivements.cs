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

            PBachivementImage.Image = button.Image;

            lblAchivementName.Text = achivement.AchivementName;
            lblAchivementDescription.Text = achivement.Description;
            lblAchivementStatus.Text = achivement.IsAchived == true ? "Достижение получено" : "Достижение не получено";
        }
    }
}
