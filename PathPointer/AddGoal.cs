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
    public partial class AddGoal : Form
    {
        DataManagement addGoal = new DataManagement();

        public AddGoal()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Employments empForm = new Employments();
            empForm.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            DataManagement.WriteEmpFiles(nameText.Text, Convert.ToInt32(timeText.Text),datePicker.Text);
        }

        private void AddGoal_Load(object sender, EventArgs e)
        {

        }
    }
}
