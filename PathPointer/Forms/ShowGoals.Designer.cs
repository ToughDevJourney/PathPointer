namespace PathPointer
{
    partial class ShowGoals
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblPercentsDone = new System.Windows.Forms.Label();
            this.lblHoursPerDayToDone = new System.Windows.Forms.Label();
            this.lblHoursGoal = new System.Windows.Forms.Label();
            this.lblHoursDone = new System.Windows.Forms.Label();
            this.lblAverageHoursADay = new System.Windows.Forms.Label();
            this.DGVGoals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGoals)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(298, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(510, 60);
            this.BtnBack.TabIndex = 13;
            this.BtnBack.Text = "Вернуться";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblPercentsDone
            // 
            this.lblPercentsDone.AutoSize = true;
            this.lblPercentsDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentsDone.Location = new System.Drawing.Point(293, 12);
            this.lblPercentsDone.Name = "lblPercentsDone";
            this.lblPercentsDone.Size = new System.Drawing.Size(436, 29);
            this.lblPercentsDone.TabIndex = 14;
            this.lblPercentsDone.Text = "Цель выполнена на [5]% процентов!";
            // 
            // lblHoursPerDayToDone
            // 
            this.lblHoursPerDayToDone.AutoSize = true;
            this.lblHoursPerDayToDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHoursPerDayToDone.Location = new System.Drawing.Point(295, 51);
            this.lblHoursPerDayToDone.Name = "lblHoursPerDayToDone";
            this.lblHoursPerDayToDone.Size = new System.Drawing.Size(388, 36);
            this.lblHoursPerDayToDone.TabIndex = 15;
            this.lblHoursPerDayToDone.Text = "Если вы будете тратить на эту цель по [3] часа в день,\r\nто достигните ее через [1" +
    "] день";
            // 
            // lblHoursGoal
            // 
            this.lblHoursGoal.AutoSize = true;
            this.lblHoursGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHoursGoal.Location = new System.Drawing.Point(295, 264);
            this.lblHoursGoal.Name = "lblHoursGoal";
            this.lblHoursGoal.Size = new System.Drawing.Size(278, 16);
            this.lblHoursGoal.TabIndex = 16;
            this.lblHoursGoal.Text = "Необходимо часов для выполнения цели:";
            // 
            // lblHoursDone
            // 
            this.lblHoursDone.AutoSize = true;
            this.lblHoursDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHoursDone.Location = new System.Drawing.Point(295, 238);
            this.lblHoursDone.Name = "lblHoursDone";
            this.lblHoursDone.Size = new System.Drawing.Size(173, 16);
            this.lblHoursDone.TabIndex = 17;
            this.lblHoursDone.Text = "Пройдено часов до цели:";
            // 
            // lblAverageHoursADay
            // 
            this.lblAverageHoursADay.AutoSize = true;
            this.lblAverageHoursADay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverageHoursADay.Location = new System.Drawing.Point(295, 320);
            this.lblAverageHoursADay.Name = "lblAverageHoursADay";
            this.lblAverageHoursADay.Size = new System.Drawing.Size(513, 18);
            this.lblAverageHoursADay.TabIndex = 19;
            this.lblAverageHoursADay.Text = "В среднем, на этой неделе, вы приближаетесь к цели на [2] часа в день,";
            // 
            // DGVGoals
            // 
            this.DGVGoals.AllowUserToAddRows = false;
            this.DGVGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGoals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGoals.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGoals.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVGoals.EnableHeadersVisualStyles = false;
            this.DGVGoals.Location = new System.Drawing.Point(12, 8);
            this.DGVGoals.MultiSelect = false;
            this.DGVGoals.Name = "DGVGoals";
            this.DGVGoals.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGoals.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVGoals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVGoals.Size = new System.Drawing.Size(273, 430);
            this.DGVGoals.TabIndex = 20;
            this.DGVGoals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGoals_CellClick);
            // 
            // ShowGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.DGVGoals);
            this.Controls.Add(this.lblAverageHoursADay);
            this.Controls.Add(this.lblHoursDone);
            this.Controls.Add(this.lblHoursGoal);
            this.Controls.Add(this.lblHoursPerDayToDone);
            this.Controls.Add(this.lblPercentsDone);
            this.Controls.Add(this.BtnBack);
            this.Name = "ShowGoals";
            this.Text = "Цели";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Goals_FormClosing);
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGoals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lblPercentsDone;
        private System.Windows.Forms.Label lblHoursPerDayToDone;
        private System.Windows.Forms.Label lblHoursGoal;
        private System.Windows.Forms.Label lblHoursDone;
        private System.Windows.Forms.Label lblAverageHoursADay;
        private System.Windows.Forms.DataGridView DGVGoals;
    }
}