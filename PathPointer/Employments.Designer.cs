namespace PathPointer
{
    partial class Employments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridBusiness = new System.Windows.Forms.DataGridView();
            this.GoalsButton = new System.Windows.Forms.Button();
            this.RestButton = new System.Windows.Forms.Button();
            this.FunButton = new System.Windows.Forms.Button();
            this.BusinessButton = new System.Windows.Forms.Button();
            this.BackMain = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BtnHight = new System.Windows.Forms.Button();
            this.LowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBusiness
            // 
            this.dataGridBusiness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBusiness.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusiness.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBusiness.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBusiness.EnableHeadersVisualStyles = false;
            this.dataGridBusiness.Location = new System.Drawing.Point(270, 12);
            this.dataGridBusiness.Name = "dataGridBusiness";
            this.dataGridBusiness.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBusiness.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBusiness.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBusiness.Size = new System.Drawing.Size(273, 389);
            this.dataGridBusiness.TabIndex = 0;
            this.dataGridBusiness.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridBusiness_KeyDown);
            // 
            // GoalsButton
            // 
            this.GoalsButton.Location = new System.Drawing.Point(12, 122);
            this.GoalsButton.Name = "GoalsButton";
            this.GoalsButton.Size = new System.Drawing.Size(234, 60);
            this.GoalsButton.TabIndex = 1;
            this.GoalsButton.Text = "Цели";
            this.GoalsButton.UseVisualStyleBackColor = true;
            this.GoalsButton.Click += new System.EventHandler(this.GoalsButton_Click);
            // 
            // RestButton
            // 
            this.RestButton.Location = new System.Drawing.Point(12, 229);
            this.RestButton.Name = "RestButton";
            this.RestButton.Size = new System.Drawing.Size(234, 60);
            this.RestButton.TabIndex = 2;
            this.RestButton.Text = "Отдых";
            this.RestButton.UseVisualStyleBackColor = true;
            this.RestButton.Click += new System.EventHandler(this.RestButton_Click);
            // 
            // FunButton
            // 
            this.FunButton.Location = new System.Drawing.Point(12, 341);
            this.FunButton.Name = "FunButton";
            this.FunButton.Size = new System.Drawing.Size(234, 60);
            this.FunButton.TabIndex = 3;
            this.FunButton.Text = "Развлечения";
            this.FunButton.UseVisualStyleBackColor = true;
            this.FunButton.Click += new System.EventHandler(this.FunButton_Click);
            // 
            // BusinessButton
            // 
            this.BusinessButton.Location = new System.Drawing.Point(12, 12);
            this.BusinessButton.Name = "BusinessButton";
            this.BusinessButton.Size = new System.Drawing.Size(234, 60);
            this.BusinessButton.TabIndex = 4;
            this.BusinessButton.Text = "Неотложные дела";
            this.BusinessButton.UseVisualStyleBackColor = true;
            this.BusinessButton.Click += new System.EventHandler(this.BusinessButton_Click);
            // 
            // BackMain
            // 
            this.BackMain.Location = new System.Drawing.Point(563, 343);
            this.BackMain.Name = "BackMain";
            this.BackMain.Size = new System.Drawing.Size(234, 60);
            this.BackMain.TabIndex = 5;
            this.BackMain.Text = "Вернуться";
            this.BackMain.UseVisualStyleBackColor = true;
            this.BackMain.Click += new System.EventHandler(this.BackMain_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(563, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(234, 60);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BtnHight
            // 
            this.BtnHight.Location = new System.Drawing.Point(563, 252);
            this.BtnHight.Name = "BtnHight";
            this.BtnHight.Size = new System.Drawing.Size(116, 60);
            this.BtnHight.TabIndex = 9;
            this.BtnHight.Text = "Понизить";
            this.BtnHight.UseVisualStyleBackColor = true;
            this.BtnHight.Click += new System.EventHandler(this.BtnHight_Click);
            // 
            // LowButton
            // 
            this.LowButton.Location = new System.Drawing.Point(681, 252);
            this.LowButton.Name = "LowButton";
            this.LowButton.Size = new System.Drawing.Size(116, 60);
            this.LowButton.TabIndex = 10;
            this.LowButton.Text = "Повысить";
            this.LowButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Приоритет";
            // 
            // Employments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LowButton);
            this.Controls.Add(this.BtnHight);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackMain);
            this.Controls.Add(this.BusinessButton);
            this.Controls.Add(this.FunButton);
            this.Controls.Add(this.RestButton);
            this.Controls.Add(this.GoalsButton);
            this.Controls.Add(this.dataGridBusiness);
            this.Name = "Employments";
            this.Text = "Занятия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employments_FormClosed);
            this.Load += new System.EventHandler(this.Employments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBusiness;
        private System.Windows.Forms.Button GoalsButton;
        private System.Windows.Forms.Button RestButton;
        private System.Windows.Forms.Button FunButton;
        private System.Windows.Forms.Button BusinessButton;
        private System.Windows.Forms.Button BackMain;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BtnHight;
        private System.Windows.Forms.Button LowButton;
        private System.Windows.Forms.Label label1;
    }
}