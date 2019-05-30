namespace PathPointer
{
    partial class TimeSpent
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
            this.BtnBusiness = new System.Windows.Forms.Button();
            this.BtnFun = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            this.BtnGoals = new System.Windows.Forms.Button();
            this.BtnReady = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridBusiness = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBusiness
            // 
            this.BtnBusiness.Location = new System.Drawing.Point(12, 52);
            this.BtnBusiness.Name = "BtnBusiness";
            this.BtnBusiness.Size = new System.Drawing.Size(234, 60);
            this.BtnBusiness.TabIndex = 8;
            this.BtnBusiness.Text = "Неотложные дела";
            this.BtnBusiness.UseVisualStyleBackColor = true;
            this.BtnBusiness.Click += new System.EventHandler(this.BtnBusiness_Click);
            // 
            // BtnFun
            // 
            this.BtnFun.Location = new System.Drawing.Point(12, 314);
            this.BtnFun.Name = "BtnFun";
            this.BtnFun.Size = new System.Drawing.Size(234, 60);
            this.BtnFun.TabIndex = 7;
            this.BtnFun.Text = "Развлечения";
            this.BtnFun.UseVisualStyleBackColor = true;
            this.BtnFun.Click += new System.EventHandler(this.BtnFun_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.Location = new System.Drawing.Point(12, 228);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(234, 60);
            this.BtnRest.TabIndex = 6;
            this.BtnRest.Text = "Отдых";
            this.BtnRest.UseVisualStyleBackColor = true;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // BtnGoals
            // 
            this.BtnGoals.Location = new System.Drawing.Point(12, 141);
            this.BtnGoals.Name = "BtnGoals";
            this.BtnGoals.Size = new System.Drawing.Size(234, 60);
            this.BtnGoals.TabIndex = 5;
            this.BtnGoals.Text = "Цели";
            this.BtnGoals.UseVisualStyleBackColor = true;
            this.BtnGoals.Click += new System.EventHandler(this.BtnGoals_Click);
            // 
            // BtnReady
            // 
            this.BtnReady.Location = new System.Drawing.Point(12, 405);
            this.BtnReady.Name = "BtnReady";
            this.BtnReady.Size = new System.Drawing.Size(528, 50);
            this.BtnReady.TabIndex = 9;
            this.BtnReady.Text = "Готово";
            this.BtnReady.UseVisualStyleBackColor = true;
            this.BtnReady.Click += new System.EventHandler(this.BtnReady_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "На что вы потратили большую часть прошедшего часа?";
            // 
            // dataGridBusiness
            // 
            this.dataGridBusiness.AllowUserToAddRows = false;
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
            this.dataGridBusiness.Location = new System.Drawing.Point(294, 52);
            this.dataGridBusiness.MultiSelect = false;
            this.dataGridBusiness.Name = "dataGridBusiness";
            this.dataGridBusiness.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBusiness.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBusiness.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBusiness.Size = new System.Drawing.Size(241, 322);
            this.dataGridBusiness.TabIndex = 11;
            // 
            // TimeSpent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 464);
            this.Controls.Add(this.dataGridBusiness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReady);
            this.Controls.Add(this.BtnBusiness);
            this.Controls.Add(this.BtnFun);
            this.Controls.Add(this.BtnRest);
            this.Controls.Add(this.BtnGoals);
            this.Name = "TimeSpent";
            this.Text = "На что вы потратили большую часть прошедшего часа?";
            this.Load += new System.EventHandler(this.TimeSpent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBusiness;
        private System.Windows.Forms.Button BtnFun;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Button BtnGoals;
        private System.Windows.Forms.Button BtnReady;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBusiness;
    }
}