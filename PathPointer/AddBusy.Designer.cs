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
            this.nameText = new System.Windows.Forms.TextBox();
            this.AddScheduleBtn = new System.Windows.Forms.Button();
            this.labelSched = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
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
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(80, 18);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(202, 20);
            this.nameText.TabIndex = 4;
            // 
            // AddScheduleBtn
            // 
            this.AddScheduleBtn.Location = new System.Drawing.Point(155, 51);
            this.AddScheduleBtn.Name = "AddScheduleBtn";
            this.AddScheduleBtn.Size = new System.Drawing.Size(127, 25);
            this.AddScheduleBtn.TabIndex = 6;
            this.AddScheduleBtn.Text = "Добавить";
            this.AddScheduleBtn.UseVisualStyleBackColor = true;
            this.AddScheduleBtn.Click += new System.EventHandler(this.AddScheduleBtn_Click);
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
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(157, 97);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(125, 43);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Вернуться";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(26, 97);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 43);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddBusy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 161);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.labelSched);
            this.Controls.Add(this.AddScheduleBtn);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.nameText);
            this.Name = "AddBusy";
            this.Text = "Добавить дело";
            this.Load += new System.EventHandler(this.AddBusy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button AddScheduleBtn;
        private System.Windows.Forms.Label labelSched;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}