namespace PathPointer
{
    partial class MoreStat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblProductive = new System.Windows.Forms.Label();
            this.lblBusinessHrsSpent = new System.Windows.Forms.Label();
            this.lblFavRest = new System.Windows.Forms.Label();
            this.lblFunTimeSpent = new System.Windows.Forms.Label();
            this.lblFavFun = new System.Windows.Forms.Label();
            this.lblRestTimeSpent = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblCloseToDream = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGoalPercent = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.lblProductive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductive.Location = new System.Drawing.Point(13, 113);
            this.lblProductive.Name = "lblProductive";
            this.lblProductive.Size = new System.Drawing.Size(345, 18);
            this.lblProductive.TabIndex = 0;
            this.lblProductive.Text = "Сегодня вы производительнее чем вчера на 5%";
            // 
            // lblBusinessHrsSpent
            // 
            this.lblBusinessHrsSpent.AutoSize = true;
            this.lblBusinessHrsSpent.Location = new System.Drawing.Point(13, 100);
            this.lblBusinessHrsSpent.Name = "lblBusinessHrsSpent";
            this.lblBusinessHrsSpent.Size = new System.Drawing.Size(172, 13);
            this.lblBusinessHrsSpent.TabIndex = 1;
            this.lblBusinessHrsSpent.Text = "Потрачено на неотложные дела:";
            // 
            // lblFavRest
            // 
            this.lblFavRest.AutoSize = true;
            this.lblFavRest.Location = new System.Drawing.Point(9, 310);
            this.lblFavRest.Name = "lblFavRest";
            this.lblFavRest.Size = new System.Drawing.Size(120, 13);
            this.lblFavRest.TabIndex = 3;
            this.lblFavRest.Text = "Любимый вид отдыха:";
            // 
            // lblFunTimeSpent
            // 
            this.lblFunTimeSpent.AutoSize = true;
            this.lblFunTimeSpent.Location = new System.Drawing.Point(328, 332);
            this.lblFunTimeSpent.Name = "lblFunTimeSpent";
            this.lblFunTimeSpent.Size = new System.Drawing.Size(194, 13);
            this.lblFunTimeSpent.TabIndex = 4;
            this.lblFunTimeSpent.Text = "Потрачено времени на развлечения:";
            // 
            // lblFavFun
            // 
            this.lblFavFun.AutoSize = true;
            this.lblFavFun.Location = new System.Drawing.Point(328, 310);
            this.lblFavFun.Name = "lblFavFun";
            this.lblFavFun.Size = new System.Drawing.Size(126, 13);
            this.lblFavFun.TabIndex = 8;
            this.lblFavFun.Text = "Любимое развлечение:";
            // 
            // lblRestTimeSpent
            // 
            this.lblRestTimeSpent.AutoSize = true;
            this.lblRestTimeSpent.Location = new System.Drawing.Point(9, 332);
            this.lblRestTimeSpent.Name = "lblRestTimeSpent";
            this.lblRestTimeSpent.Size = new System.Drawing.Size(159, 13);
            this.lblRestTimeSpent.TabIndex = 9;
            this.lblRestTimeSpent.Text = "Потрачено времени на отдых:";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(711, 374);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(240, 40);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Вернуться";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblCloseToDream
            // 
            this.lblCloseToDream.AutoSize = true;
            this.lblCloseToDream.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloseToDream.Location = new System.Drawing.Point(10, 12);
            this.lblCloseToDream.Name = "lblCloseToDream";
            this.lblCloseToDream.Size = new System.Drawing.Size(465, 25);
            this.lblCloseToDream.TabIndex = 11;
            this.lblCloseToDream.Text = "Вы ближе к своей мечте [МЕЧТА] на 1 часов!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Круглая диаграмма";
            // 
            // lblGoalPercent
            // 
            this.lblGoalPercent.AutoSize = true;
            this.lblGoalPercent.Location = new System.Drawing.Point(9, 384);
            this.lblGoalPercent.Name = "lblGoalPercent";
            this.lblGoalPercent.Size = new System.Drawing.Size(274, 13);
            this.lblGoalPercent.TabIndex = 13;
            this.lblGoalPercent.Text = "Ваша мечта [мечта] стала реальностью уже на [40]%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(670, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Развлечения не дают вам полноценного отдыха, вместо этого постарайтесь вздремнуть" +
    ", выйти на прогулку или помедитировать";
            // 
            // lblReachedGoals
            // 
            this.lblReachedGoals.AutoSize = true;
            this.lblReachedGoals.Location = new System.Drawing.Point(9, 368);
            this.lblReachedGoals.Name = "lblReachedGoals";
            this.lblReachedGoals.Size = new System.Drawing.Size(141, 13);
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
            this.DGVMoreStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMoreStats.ColumnHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMoreStats.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGVMoreStats.EnableHeadersVisualStyles = false;
            this.DGVMoreStats.GridColor = System.Drawing.Color.Black;
            this.DGVMoreStats.Location = new System.Drawing.Point(13, 143);
            this.DGVMoreStats.MultiSelect = false;
            this.DGVMoreStats.Name = "DGVMoreStats";
            this.DGVMoreStats.ReadOnly = true;
            this.DGVMoreStats.RowHeadersVisible = false;
            this.DGVMoreStats.RowHeadersWidth = 10;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMoreStats.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVMoreStats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVMoreStats.Size = new System.Drawing.Size(937, 142);
            this.DGVMoreStats.TabIndex = 18;
            // 
            // ChartEmpRatio
            // 
            this.ChartEmpRatio.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.ChartEmpRatio.ChartAreas.Add(chartArea4);
            this.ChartEmpRatio.Location = new System.Drawing.Point(722, 10);
            this.ChartEmpRatio.Name = "ChartEmpRatio";
            this.ChartEmpRatio.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Name = "Series1";
            this.ChartEmpRatio.Series.Add(series4);
            this.ChartEmpRatio.Size = new System.Drawing.Size(203, 121);
            this.ChartEmpRatio.TabIndex = 19;
            this.ChartEmpRatio.Text = "chart1";
            // 
            // lblYearGoalsHrs
            // 
            this.lblYearGoalsHrs.AutoSize = true;
            this.lblYearGoalsHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYearGoalsHrs.Location = new System.Drawing.Point(12, 41);
            this.lblYearGoalsHrs.Name = "lblYearGoalsHrs";
            this.lblYearGoalsHrs.Size = new System.Drawing.Size(249, 24);
            this.lblYearGoalsHrs.TabIndex = 20;
            this.lblYearGoalsHrs.Text = "Потрачено на цели за год:";
            // 
            // BtnShowBusiness
            // 
            this.BtnShowBusiness.Location = new System.Drawing.Point(711, 331);
            this.BtnShowBusiness.Name = "BtnShowBusiness";
            this.BtnShowBusiness.Size = new System.Drawing.Size(107, 40);
            this.BtnShowBusiness.TabIndex = 21;
            this.BtnShowBusiness.Tag = "Business";
            this.BtnShowBusiness.Text = "Дела";
            this.BtnShowBusiness.UseVisualStyleBackColor = true;
            this.BtnShowBusiness.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // BtnShowGoals
            // 
            this.BtnShowGoals.Location = new System.Drawing.Point(711, 291);
            this.BtnShowGoals.Name = "BtnShowGoals";
            this.BtnShowGoals.Size = new System.Drawing.Size(107, 40);
            this.BtnShowGoals.TabIndex = 22;
            this.BtnShowGoals.Tag = "Goals";
            this.BtnShowGoals.Text = "Цели";
            this.BtnShowGoals.UseVisualStyleBackColor = true;
            this.BtnShowGoals.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // BtnShowRest
            // 
            this.BtnShowRest.Location = new System.Drawing.Point(844, 291);
            this.BtnShowRest.Name = "BtnShowRest";
            this.BtnShowRest.Size = new System.Drawing.Size(107, 40);
            this.BtnShowRest.TabIndex = 24;
            this.BtnShowRest.Tag = "Rest";
            this.BtnShowRest.Text = "Отдых";
            this.BtnShowRest.UseVisualStyleBackColor = true;
            this.BtnShowRest.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // BtnShowFun
            // 
            this.BtnShowFun.Location = new System.Drawing.Point(844, 331);
            this.BtnShowFun.Name = "BtnShowFun";
            this.BtnShowFun.Size = new System.Drawing.Size(107, 40);
            this.BtnShowFun.TabIndex = 23;
            this.BtnShowFun.Tag = "Fun";
            this.BtnShowFun.Text = "Развлечения";
            this.BtnShowFun.UseVisualStyleBackColor = true;
            this.BtnShowFun.Click += new System.EventHandler(this.ShowYearStats);
            // 
            // MoreStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 423);
            this.Controls.Add(this.BtnShowRest);
            this.Controls.Add(this.BtnShowFun);
            this.Controls.Add(this.BtnShowGoals);
            this.Controls.Add(this.BtnShowBusiness);
            this.Controls.Add(this.lblYearGoalsHrs);
            this.Controls.Add(this.ChartEmpRatio);
            this.Controls.Add(this.DGVMoreStats);
            this.Controls.Add(this.lblReachedGoals);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblGoalPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCloseToDream);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.lblRestTimeSpent);
            this.Controls.Add(this.lblFavFun);
            this.Controls.Add(this.lblFunTimeSpent);
            this.Controls.Add(this.lblFavRest);
            this.Controls.Add(this.lblBusinessHrsSpent);
            this.Controls.Add(this.lblProductive);
            this.Name = "MoreStat";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGoalPercent;
        private System.Windows.Forms.Label label11;
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