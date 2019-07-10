namespace PathPointer
{
    partial class AddFun
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Название";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(149, 82);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(129, 30);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(14, 82);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 30);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(68, 8);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(210, 20);
            this.textName.TabIndex = 18;
            // 
            // AddFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 123);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textName);
            this.Name = "AddFun";
            this.Text = "Добавить развлечение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFun_FormClosing);
            this.Load += new System.EventHandler(this.AddFun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textName;
    }
}