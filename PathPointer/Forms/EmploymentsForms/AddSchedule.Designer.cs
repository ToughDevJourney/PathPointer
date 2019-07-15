namespace PathPointer
{
    partial class AddSchedule
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
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblTue = new System.Windows.Forms.Label();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblThu = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblSun = new System.Windows.Forms.Label();
            this.lblTimeMon = new System.Windows.Forms.Label();
            this.lblTimeTue = new System.Windows.Forms.Label();
            this.lblTimeWed = new System.Windows.Forms.Label();
            this.lblTimeThu = new System.Windows.Forms.Label();
            this.lblTimeFri = new System.Windows.Forms.Label();
            this.lblTimeSat = new System.Windows.Forms.Label();
            this.lblTimeSun = new System.Windows.Forms.Label();
            this.beginLbl = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Label();
            this.TextBegin = new System.Windows.Forms.MaskedTextBox();
            this.TextEnd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBusinessName.ForeColor = System.Drawing.Color.White;
            this.lblBusinessName.Location = new System.Drawing.Point(20, 19);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(829, 46);
            this.lblBusinessName.TabIndex = 0;
            this.lblBusinessName.Text = "[Название дела]";
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDone.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnDone.Location = new System.Drawing.Point(302, 258);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(376, 51);
            this.BtnDone.TabIndex = 1;
            this.BtnDone.Text = "Готово";
            this.BtnDone.UseVisualStyleBackColor = false;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnCancel.Location = new System.Drawing.Point(684, 258);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(166, 51);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblMon.ForeColor = System.Drawing.Color.White;
            this.lblMon.Location = new System.Drawing.Point(21, 76);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(121, 23);
            this.lblMon.TabIndex = 3;
            this.lblMon.Tag = "0";
            this.lblMon.Text = "Понедельник";
            this.lblMon.Click += new System.EventHandler(this.DayOfWeekClick);
            this.lblMon.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblMon.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTue
            // 
            this.lblTue.AutoSize = true;
            this.lblTue.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTue.ForeColor = System.Drawing.Color.White;
            this.lblTue.Location = new System.Drawing.Point(21, 112);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(80, 23);
            this.lblTue.TabIndex = 4;
            this.lblTue.Tag = "1";
            this.lblTue.Text = "Вторник";
            this.lblTue.Click += new System.EventHandler(this.DayOfWeekClick);
            this.lblTue.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTue.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblWed.ForeColor = System.Drawing.Color.White;
            this.lblWed.Location = new System.Drawing.Point(20, 147);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(61, 23);
            this.lblWed.TabIndex = 5;
            this.lblWed.Tag = "2";
            this.lblWed.Text = "Среда";
            this.lblWed.Click += new System.EventHandler(this.DayOfWeekClick);
            this.lblWed.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblWed.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblThu.ForeColor = System.Drawing.Color.White;
            this.lblThu.Location = new System.Drawing.Point(20, 180);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(77, 23);
            this.lblThu.TabIndex = 6;
            this.lblThu.Tag = "3";
            this.lblThu.Text = "Четверг";
            this.lblThu.Click += new System.EventHandler(this.DayOfWeekClick);
            this.lblThu.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblThu.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblFri.ForeColor = System.Drawing.Color.White;
            this.lblFri.Location = new System.Drawing.Point(21, 215);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(79, 23);
            this.lblFri.TabIndex = 7;
            this.lblFri.Tag = "4";
            this.lblFri.Text = "Пятница";
            this.lblFri.Click += new System.EventHandler(this.DayOfWeekClick);
            this.lblFri.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblFri.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblSat.ForeColor = System.Drawing.Color.White;
            this.lblSat.Location = new System.Drawing.Point(21, 250);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(79, 23);
            this.lblSat.TabIndex = 8;
            this.lblSat.Tag = "5";
            this.lblSat.Text = "Суббота";
            this.lblSat.Click += new System.EventHandler(this.DayOfWeekClick);
            this.lblSat.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblSat.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblSun.ForeColor = System.Drawing.Color.White;
            this.lblSun.Location = new System.Drawing.Point(22, 287);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(119, 23);
            this.lblSun.TabIndex = 9;
            this.lblSun.Tag = "6";
            this.lblSun.Text = "Воскресенье";
            this.lblSun.Click += new System.EventHandler(this.DayOfWeekClick);
            this.lblSun.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblSun.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTimeMon
            // 
            this.lblTimeMon.AutoSize = true;
            this.lblTimeMon.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTimeMon.ForeColor = System.Drawing.Color.White;
            this.lblTimeMon.Location = new System.Drawing.Point(161, 76);
            this.lblTimeMon.Name = "lblTimeMon";
            this.lblTimeMon.Size = new System.Drawing.Size(109, 23);
            this.lblTimeMon.TabIndex = 11;
            this.lblTimeMon.Text = "08:00 - 17:00";
            this.lblTimeMon.Click += new System.EventHandler(this.TimeClick);
            this.lblTimeMon.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTimeMon.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTimeTue
            // 
            this.lblTimeTue.AutoSize = true;
            this.lblTimeTue.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTimeTue.ForeColor = System.Drawing.Color.White;
            this.lblTimeTue.Location = new System.Drawing.Point(161, 112);
            this.lblTimeTue.Name = "lblTimeTue";
            this.lblTimeTue.Size = new System.Drawing.Size(109, 23);
            this.lblTimeTue.TabIndex = 12;
            this.lblTimeTue.Text = "08:00 - 17:00";
            this.lblTimeTue.Click += new System.EventHandler(this.TimeClick);
            this.lblTimeTue.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTimeTue.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTimeWed
            // 
            this.lblTimeWed.AutoSize = true;
            this.lblTimeWed.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTimeWed.ForeColor = System.Drawing.Color.White;
            this.lblTimeWed.Location = new System.Drawing.Point(160, 147);
            this.lblTimeWed.Name = "lblTimeWed";
            this.lblTimeWed.Size = new System.Drawing.Size(109, 23);
            this.lblTimeWed.TabIndex = 13;
            this.lblTimeWed.Text = "08:00 - 17:00";
            this.lblTimeWed.Click += new System.EventHandler(this.TimeClick);
            this.lblTimeWed.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTimeWed.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTimeThu
            // 
            this.lblTimeThu.AutoSize = true;
            this.lblTimeThu.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTimeThu.ForeColor = System.Drawing.Color.White;
            this.lblTimeThu.Location = new System.Drawing.Point(160, 180);
            this.lblTimeThu.Name = "lblTimeThu";
            this.lblTimeThu.Size = new System.Drawing.Size(109, 23);
            this.lblTimeThu.TabIndex = 14;
            this.lblTimeThu.Text = "08:00 - 17:00";
            this.lblTimeThu.Click += new System.EventHandler(this.TimeClick);
            this.lblTimeThu.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTimeThu.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTimeFri
            // 
            this.lblTimeFri.AutoSize = true;
            this.lblTimeFri.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTimeFri.ForeColor = System.Drawing.Color.White;
            this.lblTimeFri.Location = new System.Drawing.Point(161, 215);
            this.lblTimeFri.Name = "lblTimeFri";
            this.lblTimeFri.Size = new System.Drawing.Size(109, 23);
            this.lblTimeFri.TabIndex = 15;
            this.lblTimeFri.Text = "08:00 - 17:00";
            this.lblTimeFri.Click += new System.EventHandler(this.TimeClick);
            this.lblTimeFri.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTimeFri.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTimeSat
            // 
            this.lblTimeSat.AutoSize = true;
            this.lblTimeSat.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTimeSat.ForeColor = System.Drawing.Color.White;
            this.lblTimeSat.Location = new System.Drawing.Point(161, 250);
            this.lblTimeSat.Name = "lblTimeSat";
            this.lblTimeSat.Size = new System.Drawing.Size(109, 23);
            this.lblTimeSat.TabIndex = 16;
            this.lblTimeSat.Text = "08:00 - 17:00";
            this.lblTimeSat.Click += new System.EventHandler(this.TimeClick);
            this.lblTimeSat.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTimeSat.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // lblTimeSun
            // 
            this.lblTimeSun.AutoSize = true;
            this.lblTimeSun.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblTimeSun.ForeColor = System.Drawing.Color.White;
            this.lblTimeSun.Location = new System.Drawing.Point(159, 287);
            this.lblTimeSun.Name = "lblTimeSun";
            this.lblTimeSun.Size = new System.Drawing.Size(109, 23);
            this.lblTimeSun.TabIndex = 17;
            this.lblTimeSun.Text = "08:00 - 17:00";
            this.lblTimeSun.Click += new System.EventHandler(this.TimeClick);
            this.lblTimeSun.MouseEnter += new System.EventHandler(this.MouseEnterLabelEvent);
            this.lblTimeSun.MouseLeave += new System.EventHandler(this.MouseLeaveFontEvent);
            // 
            // beginLbl
            // 
            this.beginLbl.AutoSize = true;
            this.beginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginLbl.ForeColor = System.Drawing.Color.White;
            this.beginLbl.Location = new System.Drawing.Point(291, 81);
            this.beginLbl.Name = "beginLbl";
            this.beginLbl.Size = new System.Drawing.Size(249, 61);
            this.beginLbl.TabIndex = 20;
            this.beginLbl.Text = "НАЧАЛО";
            // 
            // endBtn
            // 
            this.endBtn.AutoSize = true;
            this.endBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endBtn.ForeColor = System.Drawing.Color.White;
            this.endBtn.Location = new System.Drawing.Point(291, 173);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(216, 61);
            this.endBtn.TabIndex = 21;
            this.endBtn.Text = "КОНЕЦ";
            // 
            // TextBegin
            // 
            this.TextBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.TextBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F);
            this.TextBegin.ForeColor = System.Drawing.Color.White;
            this.TextBegin.Location = new System.Drawing.Point(546, 83);
            this.TextBegin.Mask = "00:00";
            this.TextBegin.Name = "TextBegin";
            this.TextBegin.Size = new System.Drawing.Size(304, 67);
            this.TextBegin.TabIndex = 22;
            this.TextBegin.Text = "0800";
            this.TextBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBegin.ValidatingType = typeof(System.DateTime);
            this.TextBegin.TextChanged += new System.EventHandler(this.TextBegin_TextChanged);
            this.TextBegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBegin_KeyPress);
            this.TextBegin.Leave += new System.EventHandler(this.TextBegin_Leave);
            // 
            // TextEnd
            // 
            this.TextEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.TextEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F);
            this.TextEnd.ForeColor = System.Drawing.Color.White;
            this.TextEnd.Location = new System.Drawing.Point(546, 156);
            this.TextEnd.Mask = "00:00";
            this.TextEnd.Name = "TextEnd";
            this.TextEnd.Size = new System.Drawing.Size(304, 67);
            this.TextEnd.TabIndex = 23;
            this.TextEnd.Text = "1500";
            this.TextEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextEnd.ValidatingType = typeof(System.DateTime);
            this.TextEnd.TextChanged += new System.EventHandler(this.TextEnd_TextChanged);
            this.TextEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextEnd_KeyPress);
            this.TextEnd.Leave += new System.EventHandler(this.TextEnd_Leave);
            // 
            // AddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(870, 330);
            this.Controls.Add(this.TextEnd);
            this.Controls.Add(this.TextBegin);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.beginLbl);
            this.Controls.Add(this.lblTimeSun);
            this.Controls.Add(this.lblTimeSat);
            this.Controls.Add(this.lblTimeFri);
            this.Controls.Add(this.lblTimeThu);
            this.Controls.Add(this.lblTimeWed);
            this.Controls.Add(this.lblTimeTue);
            this.Controls.Add(this.lblTimeMon);
            this.Controls.Add(this.lblSun);
            this.Controls.Add(this.lblSat);
            this.Controls.Add(this.lblFri);
            this.Controls.Add(this.lblThu);
            this.Controls.Add(this.lblWed);
            this.Controls.Add(this.lblTue);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.lblBusinessName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddSchedule";
            this.Text = "Раписание";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSchedule_FormClosing);
            this.Load += new System.EventHandler(this.AddSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblTue;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.Label lblTimeMon;
        private System.Windows.Forms.Label lblTimeTue;
        private System.Windows.Forms.Label lblTimeWed;
        private System.Windows.Forms.Label lblTimeThu;
        private System.Windows.Forms.Label lblTimeFri;
        private System.Windows.Forms.Label lblTimeSat;
        private System.Windows.Forms.Label lblTimeSun;
        private System.Windows.Forms.Label beginLbl;
        private System.Windows.Forms.Label endBtn;
        private System.Windows.Forms.MaskedTextBox TextBegin;
        private System.Windows.Forms.MaskedTextBox TextEnd;
    }
}