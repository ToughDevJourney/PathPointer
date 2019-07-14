namespace PathPointer
{
    partial class AddBusy
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
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.BtnAddSchedule = new System.Windows.Forms.Button();
            this.labelSched = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Candara", 14.25F);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(19, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 23);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Название";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.textName.Font = new System.Drawing.Font("Candara", 14.25F);
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(112, 17);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(260, 31);
            this.textName.TabIndex = 4;
            // 
            // BtnAddSchedule
            // 
            this.BtnAddSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddSchedule.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnAddSchedule.Location = new System.Drawing.Point(234, 58);
            this.BtnAddSchedule.Name = "BtnAddSchedule";
            this.BtnAddSchedule.Size = new System.Drawing.Size(138, 41);
            this.BtnAddSchedule.TabIndex = 6;
            this.BtnAddSchedule.Text = "Добавить";
            this.BtnAddSchedule.UseVisualStyleBackColor = false;
            this.BtnAddSchedule.Click += new System.EventHandler(this.BtnAddSchedule_Click);
            // 
            // labelSched
            // 
            this.labelSched.AutoSize = true;
            this.labelSched.Font = new System.Drawing.Font("Candara", 14.25F);
            this.labelSched.ForeColor = System.Drawing.Color.White;
            this.labelSched.Location = new System.Drawing.Point(19, 65);
            this.labelSched.Name = "labelSched";
            this.labelSched.Size = new System.Drawing.Size(209, 23);
            this.labelSched.TabIndex = 8;
            this.labelSched.Text = "Расписание отсутствует";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(234, 107);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(138, 63);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Вернуться";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(22, 107);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(206, 63);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddBusy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(396, 193);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.labelSched);
            this.Controls.Add(this.BtnAddSchedule);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Name = "AddBusy";
            this.Text = "Добавить дело";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBusy_FormClosing);
            this.Load += new System.EventHandler(this.AddBusy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button BtnAddSchedule;
        private System.Windows.Forms.Label labelSched;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
    }
}