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
    public partial class MoreStat : Form
    {
        public MoreStat()
        {
            InitializeComponent();
        }

        private void MoreStat_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManagement.HideForm(this, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = MainMenu.CreateInstance(this);
        }

        private void MoreStat_Load(object sender, EventArgs e)
        {
            DGVMoreStats.RowCount = 7;
            DGVMoreStats.ColumnCount = 52;
            ColorDataGridView("Goals");
        }


        private void ColorDataGridView(string empType) {
            int[,] yearEmpNum = new int[7, 52];
            int[] dayEmpNum = new int[7];
            int getWeek = 0;

            string currentEmp;

            for (int yw = 51; yw >= 0; yw--)
            {
                getWeek++;
                for (int dow = 0; dow < 7; dow++)
                {
                    string[] weekEmp = StatsManagement.FillStatsArray(getWeek);
                    if(weekEmp != null)
                    for (int hr = 0; hr < 24; hr++)
                    {
                        currentEmp = Management.GetValueByIndex(weekEmp[hr], dow + 1, ";");
                        if (Management.GetValueByIndex(currentEmp) == empType)
                        {
                            yearEmpNum[dow, yw]++;
                        }
                    }


                    if (yearEmpNum[dow, yw] > 0) DGVMoreStats.Rows[dow].Cells[yw].Style.BackColor = SetCellColor(empType, yearEmpNum[dow, yw]);

                }                
            }


            
            //заполнять справа налвео
            //из файла читать сверху вниз
        }

        private Color SetCellColor(string empType, int contrast) {
            Color cellColor = Color.FromArgb(0xFF, 0x83, 0x83, 0x83);

            int colorCode = 200 - 30 * contrast;
            colorCode = colorCode < 0 ? 0 : colorCode;


            switch (empType) {
                case "Business":
                    cellColor = Color.FromArgb(255, colorCode, colorCode, 255);
                    break;
                case "Goals":
                    cellColor = Color.FromArgb(255, colorCode, 255, colorCode);
                    break;
                case "Fun":
                    cellColor = Color.FromArgb(255, 255, colorCode, colorCode);
                    break;
                case "Rest":
                    cellColor = Color.FromArgb(255, 255, 165, colorCode);
                    break;
            }



            return cellColor;
        }

    }
}
