namespace PathPointer
{
    partial class MoreStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblProductive = new System.Windows.Forms.Label();
            this.lblBusinessHrsSpent = new System.Windows.Forms.Label();
            this.lblFavRest = new System.Windows.Forms.Label();
            this.lblFunTimeSpent = new System.Windows.Forms.Label();
            this.lblFavFun = new System.Windows.Forms.Label();
            this.lblRestTimeSpent = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblCloseToDream = new System.Windows.Forms.Label();
            this.lblGoalPercent = new System.Windows.Forms.Label();
            this.lblReachedGoals = new System.Windows.Forms.Label();
            this.DGVMoreStats = new System.Windows.Forms.DataGridView();
            this.ChartEmpRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYearGoalsHrs = new System.Windows.Forms.Label();
            this.BtnShowBusiness = new System.Windows.Forms.Button();
            this.BtnShowGoals = new System.Windows.Forms.Button();
            this.BtnShowRest = new System.Windows.Forms.Button();
            this.BtnShowFun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMoreStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEmpRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductive
            // 
            this.lblProductive.AutoSize = true;
            this.lblProductive.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductive.ForeColor = System.Drawing.Color.White;
            this.lblProductive.Location = new System.Drawing.Point(10, 118);
            this.lblProductive.Name = "lblProductive";
            this.lblProductive.Size = new System.Drawing.Size(342, 19);
            this.lblProductive.TabIndex = 0;
            this.lblProductive.Text = "Сегодня вы производительнее чем вчера на 5%";
            // 
            // lblBusinessHrsSpent
            // 
            this.lblBusinessHrsSpent.AutoSize = true;
            this.lblBusinessHrsSpent.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBusinessHrsSpent.ForeColor = System.Drawing.Color.White;
            this.lblBusinessHrsSpent.Location = new System.Drawing.Point(10, 97);
            this.lblBusinessHrsSpent.Name = "lblBusinessHrsSpent";
            this.lblBusinessHrsSpent.Size = new System.Drawing.Size(237, 19);
            this.lblBusinessHrsSpent.TabIndex = 1;
            this.lblBusinessHrsSpent.Text = "Потрачено на неотложные дела:";
            // 
            // lblFavRest
            // 
            this.lblFavRest.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblFavRest.ForeColor = System.Drawing.Color.White;
            this.lblFavRest.Location = new System.Drawing.Point(6, 300);
            this.lblFavRest.Name = "lblFavRest";
            this.lblFavRest.Size = new System.Drawing.Size(445, 23);
            this.lblFavRest.TabIndex = 3;
            this.lblFavRest.Text = "Любимый вид отдыха:";
            // 
            // lblFunTimeSpent
            // 
            this.lblFunTimeSpent.AutoSize = true;
            this.lblFunTimeSpent.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblFunTimeSpent.ForeColor = System.Drawing.Color.White;
            this.lblFunTimeSpent.Location = new System.Drawing.Point(457, 322);
            this.lblFunTimeSpent.Name = "lblFunTimeSpent";
            this.lblFunTimeSpent.Size = new System.Drawing.Size(305, 23);
            this.lblFunTimeSpent.TabIndex = 4;
            this.lblFunTimeSpent.Text = "Потрачено времени на развлечения:";
            // 
            // lblFavFun
            // 
            this.lblFavFun.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblFavFun.ForeColor = System.Drawing.Color.White;
            this.lblFavFun.Location = new System.Drawing.Point(457, 300);
            this.lblFavFun.Name = "lblFavFun";
            this.lblFavFun.Size = new System.Drawing.Size(490, 23);
            this.lblFavFun.TabIndex = 8;
            this.lblFavFun.Text = "Любимое развлечение:";
            // 
            // lblRestTimeSpent
            // 
            this.lblRestTimeSpent.AutoSize = true;
            this.lblRestTimeSpent.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblRestTimeSpent.ForeColor = System.Drawing.Color.White;
            this.lblRestTimeSpent.Location = new System.Drawing.Point(6, 322);
            this.lblRestTimeSpent.Name = "lblRestTimeSpent";
            this.lblRestTimeSpent.Size = new System.Drawing.Size(252, 23);
            this.lblRestTimeSpent.TabIndex = 9;
            this.lblRestTimeSpent.Text = "Потрачено времени на отдых:";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnBack.Location = new System.Drawing.Point(952, 348);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(178, 84);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Вернуться";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblCloseToDream
            // 
            this.lblCloseToDream.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloseToDream.ForeColor = System.Drawing.Color.White;
            this.lblCloseToDream.Location = new System.Drawing.Point(5, 9);
            this.lblCloseToDream.Name = "lblCloseToDream";
            this.lblCloseToDream.Size = new System.Drawing.Size(757, 53);
            this.lblCloseToDream.TabIndex = 11;
            this.lblCloseToDream.Text = "Вы ближе к своей мечте [МЕЧТА] на 1 часов!";
            // 
            // lblGoalPercent
            // 
            this.lblGoalPercent.AutoSize = true;
            this.lblGoalPercent.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblGoalPercent.ForeColor = System.Drawing.Color.White;
            this.lblGoalPercent.Location = new System.Drawing.Point(6, 394);
            this.lblGoalPercent.Name = "lblGoalPercent";
            this.lblGoalPercent.Size = new System.Drawing.Size(434, 23);
            this.lblGoalPercent.TabIndex = 13;
            this.lblGoalPercent.Text = "Ваша мечта [мечта] стала реальностью уже на [40]%";
            // 
            // lblReachedGoals
            // 
            this.lblReachedGoals.AutoSize = true;
            this.lblReachedGoals.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblReachedGoals.ForeColor = System.Drawing.Color.White;
            this.lblReachedGoals.Location = new System.Drawing.Point(5, 370);
            this.lblReachedGoals.Name = "lblReachedGoals";
            this.lblReachedGoals.Size = new System.Drawing.Size(224, 23);
            this.lblReachedGoals.TabIndex = 15;
            this.lblReachedGoals.Text = "Вы достигли уже [5] целей";
            // 
            // DGVMoreStats
            // 
            this.DGVMoreStats.AllowUserToAddRows = false;
            this.DGVMoreStats.AllowUserToDeleteRows = false;
            this.DGVMoreStats.AllowUserToResizeColumns = false;
            this.DGVMoreStats.AllowUserToResizeRows = false;
            this.DGVMoreStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMoreStats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVMoreStats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.DGVMoreStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMoreStats.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMoreStats.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVMoreStats.Enabled = false;
            this.DGVMoreStats.EnableHeadersVisualStyles = false;
            this.DGVMoreStats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.DGVMoreStats.Location = new System.Drawing.Point(10, 143);
            this.DGVMoreStats.MultiSelect = false;
            this.DGVMoreStats.Name = "DGVMoreStats";
            this.DGVMoreStats.ReadOnly = true;
            this.DGVMoreStats.RowHeadersVisible = false;
            this.DGVMoreStats.RowHeadersWidth = 10;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMoreStats.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVMoreStats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVMoreStats.Size = new System.Drawing.Size(937, 142);
            this.DGVMoreStats.TabIndex = 18;
            this.DGVMoreStats.SelectionChanged += new System.EventHandler(this.DGVMoreStats_SelectionChanged);
            // 
            // ChartEmpRatio
            // 
            this.ChartEmpRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ChartEmpRatio.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ChartEmpRatio.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            chartArea2.Name = "ChartArea1";
            this.ChartEmpRatio.ChartAreas.Add(chartArea2);
            this.ChartEmpRatio.Location = new System.Drawing.Point(796, 9);
            this.ChartEmpRatio.Name = "ChartEmpRatio";
            this.ChartEmpRatio.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Name = "Series1";
            this.ChartEmpRatio.Series.Add(series2);
            this.ChartEmpRatio.Size = new System.Drawing.Size(138, 121);
            this.ChartEmpRatio.TabIndex = 19;
            this.ChartEmpRatio.Text = "chart1";
            // 
            // lblYearGoalsHrs
            // 
            this.lblYearGoalsHrs.AutoSize = true;
            this.lblYearGoalsHrs.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYearGoalsHrs.ForeColor = System.Drawing.Color.White;
            this.lblYearGoalsHrs.Location = new System.Drawing.Point(6, 61);
            this.lblYearGoalsHrs.Name = "lblYearGoalsHrs";
            this.lblYearGoalsHrs.Size = new System.Drawing.Size(227, 24);
            this.lblYearGoalsHrs.TabIndex = 20;
            this.lblYearGoalsHrs.Text = "Потрачено на цели за год:";
            // 
            // BtnShowBusiness
            // 
            this.BtnShowBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnShowBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowBusiness.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnShowBusiness.Location = new System.Drawing.Point(952, 1);
            this.BtnShowBusiness.Name = "BtnShowBusiness";
            this.BtnShowBusiness.Size = new System.Drawing.Size(178, 84);
            this.BtnShowBusiness.TabIndex = 21;
            this.BtnShowBusiness.Tag = "Business";
            this.BtnShowBusiness.Text = "Дела";
            this.BtnShowBusiness.UseVisualStyleBackColor = false;
            this.BtnShowBusiness.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // BtnShowGoals
            // 
            this.BtnShowGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnShowGoals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowGoals.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnShowGoals.Location = new System.Drawing.Point(952, 87);
            this.BtnShowGoals.Name = "BtnShowGoals";
            this.BtnShowGoals.Size = new System.Drawing.Size(178, 84);
            this.BtnShowGoals.TabIndex = 22;
            this.BtnShowGoals.Tag = "Goals";
            this.BtnShowGoals.Text = "Цели";
            this.BtnShowGoals.UseVisualStyleBackColor = false;
            this.BtnShowGoals.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // BtnShowRest
            // 
            this.BtnShowRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnShowRest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowRest.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnShowRest.Location = new System.Drawing.Point(952, 174);
            this.BtnShowRest.Name = "BtnShowRest";
            this.BtnShowRest.Size = new System.Drawing.Size(178, 84);
            this.BtnShowRest.TabIndex = 24;
            this.BtnShowRest.Tag = "Rest";
            this.BtnShowRest.Text = "Отдых";
            this.BtnShowRest.UseVisualStyleBackColor = false;
            this.BtnShowRest.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // BtnShowFun
            // 
            this.BtnShowFun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnShowFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowFun.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnShowFun.Location = new System.Drawing.Point(952, 261);
            this.BtnShowFun.Name = "BtnShowFun";
            this.BtnShowFun.Size = new System.Drawing.Size(178, 84);
            this.BtnShowFun.TabIndex = 23;
            this.BtnShowFun.Tag = "Fun";
            this.BtnShowFun.Text = "Развлечения";
            this.BtnShowFun.UseVisualStyleBackColor = false;
            this.BtnShowFun.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // MoreStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1130, 430);
            this.Controls.Add(this.BtnShowRest);
            this.Controls.Add(this.BtnShowFun);
            this.Controls.Add(this.BtnShowGoals);
            this.Controls.Add(this.BtnShowBusiness);
            this.Controls.Add(this.lblYearGoalsHrs);
            this.Controls.Add(this.ChartEmpRatio);
            this.Controls.Add(this.DGVMoreStats);
            this.Controls.Add(this.lblReachedGoals);
            this.Controls.Add(this.lblGoalPercent);
            this.Controls.Add(this.lblCloseToDream);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.lblRestTimeSpent);
            this.Controls.Add(this.lblFavFun);
            this.Controls.Add(this.lblFunTimeSpent);
            this.Controls.Add(this.lblFavRest);
            this.Controls.Add(this.lblBusinessHrsSpent);
            this.Controls.Add(this.lblProductive);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MoreStats";
            this.Text = "Расширенная статистика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoreStat_FormClosing);
            this.Load += new System.EventHandler(this.MoreStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMoreStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEmpRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductive;
        private System.Windows.Forms.Label lblBusinessHrsSpent;
        private System.Windows.Forms.Label lblFavRest;
        private System.Windows.Forms.Label lblFunTimeSpent;
        private System.Windows.Forms.Label lblFavFun;
        private System.Windows.Forms.Label lblRestTimeSpent;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lblCloseToDream;
        private System.Windows.Forms.Label lblGoalPercent;
        private System.Windows.Forms.Label lblReachedGoals;
        public System.Windows.Forms.DataGridView DGVMoreStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartEmpRatio;
        private System.Windows.Forms.Label lblYearGoalsHrs;
        private System.Windows.Forms.Button BtnShowBusiness;
        private System.Windows.Forms.Button BtnShowGoals;
        private System.Windows.Forms.Button BtnShowRest;
        private System.Windows.Forms.Button BtnShowFun;
    }
}