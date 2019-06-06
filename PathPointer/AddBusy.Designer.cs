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
            this.labelName.Location = new System.Drawing.Point(23, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Название";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(80, 18);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(202, 20);
            this.textName.TabIndex = 4;
            // 
            // BtnAddSchedule
            // 
            this.BtnAddSchedule.Location = new System.Drawing.Point(155, 51);
            this.BtnAddSchedule.Name = "BtnAddSchedule";
            this.BtnAddSchedule.Size = new System.Drawing.Size(127, 25);
            this.BtnAddSchedule.TabIndex = 6;
            this.BtnAddSchedule.Text = "Добавить";
            this.BtnAddSchedule.UseVisualStyleBackColor = true;
            this.BtnAddSchedule.Click += new System.EventHandler(this.BtnAddSchedule_Click);
            // 
            // labelSched
            // 
            this.labelSched.AutoSize = true;
            this.labelSched.Location = new System.Drawing.Point(23, 56);
            this.labelSched.Name = "labelSched";
            this.labelSched.Size = new System.Drawing.Size(131, 13);
            this.labelSched.TabIndex = 8;
            this.labelSched.Text = "Расписание отсутствует";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(157, 97);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(125, 43);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Вернуться";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(26, 97);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(125, 43);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddBusy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 161);
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