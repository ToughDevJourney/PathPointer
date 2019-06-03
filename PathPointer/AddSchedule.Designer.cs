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
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBusinessName.Location = new System.Drawing.Point(21, 18);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(175, 25);
            this.lblBusinessName.TabIndex = 0;
            this.lblBusinessName.Text = "[Название дела]";
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(222, 249);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(272, 51);
            this.BtnDone.TabIndex = 1;
            this.BtnDone.Text = "Готово";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(498, 249);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(272, 51);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(21, 76);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(75, 13);
            this.lblMon.TabIndex = 3;
            this.lblMon.Text = "Понедельник";
            this.lblMon.Click += new System.EventHandler(this.lblMon_Click);
            this.lblMon.MouseEnter += new System.EventHandler(this.lblMon_MouseEnter);
            this.lblMon.MouseLeave += new System.EventHandler(this.lblMon_MouseLeave);
            // 
            // lblTue
            // 
            this.lblTue.AutoSize = true;
            this.lblTue.Location = new System.Drawing.Point(21, 112);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(49, 13);
            this.lblTue.TabIndex = 4;
            this.lblTue.Text = "Вторник";
            this.lblTue.Click += new System.EventHandler(this.lblTue_Click);
            this.lblTue.MouseEnter += new System.EventHandler(this.lblTue_MouseEnter);
            this.lblTue.MouseLeave += new System.EventHandler(this.lblTue_MouseLeave);
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Location = new System.Drawing.Point(20, 147);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(38, 13);
            this.lblWed.TabIndex = 5;
            this.lblWed.Text = "Среда";
            this.lblWed.Click += new System.EventHandler(this.lblWed_Click);
            this.lblWed.MouseEnter += new System.EventHandler(this.lblWed_MouseEnter);
            this.lblWed.MouseLeave += new System.EventHandler(this.lblWed_MouseLeave);
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Location = new System.Drawing.Point(20, 180);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(49, 13);
            this.lblThu.TabIndex = 6;
            this.lblThu.Text = "Четверг";
            this.lblThu.Click += new System.EventHandler(this.lblThu_Click);
            this.lblThu.MouseEnter += new System.EventHandler(this.lblThu_MouseEnter);
            this.lblThu.MouseLeave += new System.EventHandler(this.lblThu_MouseLeave);
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Location = new System.Drawing.Point(21, 215);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(50, 13);
            this.lblFri.TabIndex = 7;
            this.lblFri.Text = "Пятница";
            this.lblFri.Click += new System.EventHandler(this.lblFri_Click);
            this.lblFri.MouseEnter += new System.EventHandler(this.lblFri_MouseEnter);
            this.lblFri.MouseLeave += new System.EventHandler(this.lblFri_MouseLeave);
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Location = new System.Drawing.Point(21, 250);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(48, 13);
            this.lblSat.TabIndex = 8;
            this.lblSat.Text = "Суббота";
            this.lblSat.Click += new System.EventHandler(this.lblSat_Click);
            this.lblSat.MouseEnter += new System.EventHandler(this.lblSat_MouseEnter);
            this.lblSat.MouseLeave += new System.EventHandler(this.lblSat_MouseLeave);
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.Location = new System.Drawing.Point(22, 287);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(74, 13);
            this.lblSun.TabIndex = 9;
            this.lblSun.Text = "Воскресенье";
            this.lblSun.Click += new System.EventHandler(this.lblSun_Click);
            this.lblSun.MouseEnter += new System.EventHandler(this.lblSun_MouseEnter);
            this.lblSun.MouseLeave += new System.EventHandler(this.lblSun_MouseLeave);
            // 
            // lblTimeMon
            // 
            this.lblTimeMon.AutoSize = true;
            this.lblTimeMon.Location = new System.Drawing.Point(109, 76);
            this.lblTimeMon.Name = "lblTimeMon";
            this.lblTimeMon.Size = new System.Drawing.Size(70, 13);
            this.lblTimeMon.TabIndex = 11;
            this.lblTimeMon.Text = "08:00 - 17:00";
            this.lblTimeMon.Click += new System.EventHandler(this.lblTimeMon_Click);
            this.lblTimeMon.MouseEnter += new System.EventHandler(this.lblTimeMon_MouseEnter);
            this.lblTimeMon.MouseLeave += new System.EventHandler(this.lblTimeMon_MouseLeave);
            // 
            // lblTimeTue
            // 
            this.lblTimeTue.AutoSize = true;
            this.lblTimeTue.Location = new System.Drawing.Point(109, 112);
            this.lblTimeTue.Name = "lblTimeTue";
            this.lblTimeTue.Size = new System.Drawing.Size(70, 13);
            this.lblTimeTue.TabIndex = 12;
            this.lblTimeTue.Text = "08:00 - 17:00";
            this.lblTimeTue.Click += new System.EventHandler(this.lblTimeTue_Click);
            this.lblTimeTue.MouseEnter += new System.EventHandler(this.lblTimeTue_MouseEnter);
            this.lblTimeTue.MouseLeave += new System.EventHandler(this.lblTimeTue_MouseLeave);
            // 
            // lblTimeWed
            // 
            this.lblTimeWed.AutoSize = true;
            this.lblTimeWed.Location = new System.Drawing.Point(108, 147);
            this.lblTimeWed.Name = "lblTimeWed";
            this.lblTimeWed.Size = new System.Drawing.Size(70, 13);
            this.lblTimeWed.TabIndex = 13;
            this.lblTimeWed.Text = "08:00 - 17:00";
            this.lblTimeWed.Click += new System.EventHandler(this.lblTimeWed_Click);
            this.lblTimeWed.MouseEnter += new System.EventHandler(this.lblTimeWed_MouseEnter);
            this.lblTimeWed.MouseLeave += new System.EventHandler(this.lblTimeWed_MouseLeave);
            // 
            // lblTimeThu
            // 
            this.lblTimeThu.AutoSize = true;
            this.lblTimeThu.Location = new System.Drawing.Point(108, 180);
            this.lblTimeThu.Name = "lblTimeThu";
            this.lblTimeThu.Size = new System.Drawing.Size(70, 13);
            this.lblTimeThu.TabIndex = 14;
            this.lblTimeThu.Text = "08:00 - 17:00";
            this.lblTimeThu.Click += new System.EventHandler(this.lblTimeThu_Click);
            this.lblTimeThu.MouseEnter += new System.EventHandler(this.lblTimeThu_MouseEnter);
            this.lblTimeThu.MouseLeave += new System.EventHandler(this.lblTimeThu_MouseLeave);
            // 
            // lblTimeFri
            // 
            this.lblTimeFri.AutoSize = true;
            this.lblTimeFri.Location = new System.Drawing.Point(109, 215);
            this.lblTimeFri.Name = "lblTimeFri";
            this.lblTimeFri.Size = new System.Drawing.Size(70, 13);
            this.lblTimeFri.TabIndex = 15;
            this.lblTimeFri.Text = "08:00 - 17:00";
            this.lblTimeFri.Click += new System.EventHandler(this.lblTimeFri_Click);
            this.lblTimeFri.MouseEnter += new System.EventHandler(this.lblTimeFri_MouseEnter);
            this.lblTimeFri.MouseLeave += new System.EventHandler(this.lblTimeFri_MouseLeave);
            // 
            // lblTimeSat
            // 
            this.lblTimeSat.AutoSize = true;
            this.lblTimeSat.Location = new System.Drawing.Point(109, 250);
            this.lblTimeSat.Name = "lblTimeSat";
            this.lblTimeSat.Size = new System.Drawing.Size(70, 13);
            this.lblTimeSat.TabIndex = 16;
            this.lblTimeSat.Text = "08:00 - 17:00";
            this.lblTimeSat.Click += new System.EventHandler(this.lblTimeSat_Click);
            this.lblTimeSat.MouseEnter += new System.EventHandler(this.lblTimeSat_MouseEnter);
            this.lblTimeSat.MouseLeave += new System.EventHandler(this.lblTimeSat_MouseLeave);
            // 
            // lblTimeSun
            // 
            this.lblTimeSun.AutoSize = true;
            this.lblTimeSun.Location = new System.Drawing.Point(107, 287);
            this.lblTimeSun.Name = "lblTimeSun";
            this.lblTimeSun.Size = new System.Drawing.Size(70, 13);
            this.lblTimeSun.TabIndex = 17;
            this.lblTimeSun.Text = "08:00 - 17:00";
            this.lblTimeSun.Click += new System.EventHandler(this.lblTimeSun_Click);
            this.lblTimeSun.MouseEnter += new System.EventHandler(this.lblTimeSun_MouseEnter);
            this.lblTimeSun.MouseLeave += new System.EventHandler(this.lblTimeSun_MouseLeave);
            // 
            // beginLbl
            // 
            this.beginLbl.AutoSize = true;
            this.beginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginLbl.Location = new System.Drawing.Point(211, 74);
            this.beginLbl.Name = "beginLbl";
            this.beginLbl.Size = new System.Drawing.Size(249, 61);
            this.beginLbl.TabIndex = 20;
            this.beginLbl.Text = "НАЧАЛО";
            // 
            // endBtn
            // 
            this.endBtn.AutoSize = true;
            this.endBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endBtn.Location = new System.Drawing.Point(211, 166);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(216, 61);
            this.endBtn.TabIndex = 21;
            this.endBtn.Text = "КОНЕЦ";
            // 
            // TextBegin
            // 
            this.TextBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F);
            this.TextBegin.Location = new System.Drawing.Point(466, 76);
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
            this.TextEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F);
            this.TextEnd.Location = new System.Drawing.Point(466, 149);
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
            this.ClientSize = new System.Drawing.Size(794, 320);
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
            this.Name = "AddSchedule";
            this.Text = "AddSchedule";
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