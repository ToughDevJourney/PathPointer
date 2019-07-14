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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(298, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(510, 60);
            this.BtnBack.TabIndex = 13;
            this.BtnBack.Text = "Вернуться";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblPercentsDone
            // 
            this.lblPercentsDone.AutoSize = true;
            this.lblPercentsDone.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F);
            this.lblPercentsDone.ForeColor = System.Drawing.Color.White;
            this.lblPercentsDone.Location = new System.Drawing.Point(291, 8);
            this.lblPercentsDone.Name = "lblPercentsDone";
            this.lblPercentsDone.Size = new System.Drawing.Size(479, 37);
            this.lblPercentsDone.TabIndex = 14;
            this.lblPercentsDone.Text = "Цель выполнена на [5]% процентов!";
            // 
            // lblHoursPerDayToDone
            // 
            this.lblHoursPerDayToDone.AutoSize = true;
            this.lblHoursPerDayToDone.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblHoursPerDayToDone.ForeColor = System.Drawing.Color.White;
            this.lblHoursPerDayToDone.Location = new System.Drawing.Point(295, 51);
            this.lblHoursPerDayToDone.Name = "lblHoursPerDayToDone";
            this.lblHoursPerDayToDone.Size = new System.Drawing.Size(452, 46);
            this.lblHoursPerDayToDone.TabIndex = 15;
            this.lblHoursPerDayToDone.Text = "Если вы будете тратить на эту цель по [3] часа в день,\r\nто достигните ее через [1" +
    "] день";
            // 
            // lblHoursGoal
            // 
            this.lblHoursGoal.AutoSize = true;
            this.lblHoursGoal.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblHoursGoal.ForeColor = System.Drawing.Color.White;
            this.lblHoursGoal.Location = new System.Drawing.Point(295, 235);
            this.lblHoursGoal.Name = "lblHoursGoal";
            this.lblHoursGoal.Size = new System.Drawing.Size(358, 23);
            this.lblHoursGoal.TabIndex = 16;
            this.lblHoursGoal.Text = "Необходимо часов для выполнения цели:";
            // 
            // lblHoursDone
            // 
            this.lblHoursDone.AutoSize = true;
            this.lblHoursDone.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblHoursDone.ForeColor = System.Drawing.Color.White;
            this.lblHoursDone.Location = new System.Drawing.Point(295, 209);
            this.lblHoursDone.Name = "lblHoursDone";
            this.lblHoursDone.Size = new System.Drawing.Size(221, 23);
            this.lblHoursDone.TabIndex = 17;
            this.lblHoursDone.Text = "Пройдено часов до цели:";
            // 
            // lblAverageHoursADay
            // 
            this.lblAverageHoursADay.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblAverageHoursADay.ForeColor = System.Drawing.Color.White;
            this.lblAverageHoursADay.Location = new System.Drawing.Point(294, 286);
            this.lblAverageHoursADay.Name = "lblAverageHoursADay";
            this.lblAverageHoursADay.Size = new System.Drawing.Size(513, 89);
            this.lblAverageHoursADay.TabIndex = 19;
            this.lblAverageHoursADay.Text = "В среднем, на этой неделе, вы приближаетесь к цели на [2] часа в день,";
            // 
            // DGVGoals
            // 
            this.DGVGoals.AllowUserToAddRows = false;
            this.DGVGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGoals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVGoals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.DGVGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGoals.ColumnHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Candara", 12.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(88)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGoals.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGVGoals.EnableHeadersVisualStyles = false;
            this.DGVGoals.GridColor = System.Drawing.Color.White;
            this.DGVGoals.Location = new System.Drawing.Point(12, 8);
            this.DGVGoals.MultiSelect = false;
            this.DGVGoals.Name = "DGVGoals";
            this.DGVGoals.RowHeadersVisible = false;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGoals.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVGoals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVGoals.Size = new System.Drawing.Size(273, 430);
            this.DGVGoals.TabIndex = 21;
            this.DGVGoals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGoals_CellClick);
            // 
            // ShowGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.DGVGoals);
            this.Controls.Add(this.lblAverageHoursADay);
            this.Controls.Add(this.lblHoursDone);
            this.Controls.Add(this.lblHoursGoal);
            this.Controls.Add(this.lblHoursPerDayToDone);
            this.Controls.Add(this.lblPercentsDone);
            this.Controls.Add(this.BtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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