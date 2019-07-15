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
            this.lblPrevHour = new System.Windows.Forms.Label();
            this.dataGridBusiness = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBusiness
            // 
            this.BtnBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBusiness.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnBusiness.ForeColor = System.Drawing.Color.White;
            this.BtnBusiness.Location = new System.Drawing.Point(13, 51);
            this.BtnBusiness.Name = "BtnBusiness";
            this.BtnBusiness.Size = new System.Drawing.Size(261, 80);
            this.BtnBusiness.TabIndex = 8;
            this.BtnBusiness.Text = "Неотложные дела";
            this.BtnBusiness.UseVisualStyleBackColor = false;
            this.BtnBusiness.Click += new System.EventHandler(this.BtnBusiness_Click);
            // 
            // BtnFun
            // 
            this.BtnFun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFun.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnFun.ForeColor = System.Drawing.Color.White;
            this.BtnFun.Location = new System.Drawing.Point(13, 319);
            this.BtnFun.Name = "BtnFun";
            this.BtnFun.Size = new System.Drawing.Size(261, 80);
            this.BtnFun.TabIndex = 7;
            this.BtnFun.Text = "Развлечения";
            this.BtnFun.UseVisualStyleBackColor = false;
            this.BtnFun.Click += new System.EventHandler(this.BtnFun_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnRest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRest.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnRest.ForeColor = System.Drawing.Color.White;
            this.BtnRest.Location = new System.Drawing.Point(13, 230);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(261, 80);
            this.BtnRest.TabIndex = 6;
            this.BtnRest.Text = "Отдых";
            this.BtnRest.UseVisualStyleBackColor = false;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // BtnGoals
            // 
            this.BtnGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnGoals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoals.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnGoals.ForeColor = System.Drawing.Color.White;
            this.BtnGoals.Location = new System.Drawing.Point(13, 141);
            this.BtnGoals.Name = "BtnGoals";
            this.BtnGoals.Size = new System.Drawing.Size(261, 80);
            this.BtnGoals.TabIndex = 5;
            this.BtnGoals.Text = "Цели";
            this.BtnGoals.UseVisualStyleBackColor = false;
            this.BtnGoals.Click += new System.EventHandler(this.BtnGoals_Click);
            // 
            // BtnReady
            // 
            this.BtnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReady.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnReady.ForeColor = System.Drawing.Color.White;
            this.BtnReady.Location = new System.Drawing.Point(13, 418);
            this.BtnReady.Name = "BtnReady";
            this.BtnReady.Size = new System.Drawing.Size(528, 75);
            this.BtnReady.TabIndex = 9;
            this.BtnReady.Text = "Готово";
            this.BtnReady.UseVisualStyleBackColor = false;
            this.BtnReady.Click += new System.EventHandler(this.BtnReady_Click);
            // 
            // lblPrevHour
            // 
            this.lblPrevHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrevHour.ForeColor = System.Drawing.Color.White;
            this.lblPrevHour.Location = new System.Drawing.Point(20, 12);
            this.lblPrevHour.Name = "lblPrevHour";
            this.lblPrevHour.Size = new System.Drawing.Size(514, 24);
            this.lblPrevHour.TabIndex = 10;
            this.lblPrevHour.Text = "На что вы потратили большую часть прошедшего часа?";
            this.lblPrevHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridBusiness
            // 
            this.dataGridBusiness.AllowUserToAddRows = false;
            this.dataGridBusiness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBusiness.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridBusiness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusiness.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(88)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBusiness.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBusiness.EnableHeadersVisualStyles = false;
            this.dataGridBusiness.GridColor = System.Drawing.Color.White;
            this.dataGridBusiness.Location = new System.Drawing.Point(280, 52);
            this.dataGridBusiness.MultiSelect = false;
            this.dataGridBusiness.Name = "dataGridBusiness";
            this.dataGridBusiness.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBusiness.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBusiness.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBusiness.Size = new System.Drawing.Size(261, 347);
            this.dataGridBusiness.TabIndex = 12;
            // 
            // TimeSpent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(555, 504);
            this.Controls.Add(this.dataGridBusiness);
            this.Controls.Add(this.lblPrevHour);
            this.Controls.Add(this.BtnReady);
            this.Controls.Add(this.BtnBusiness);
            this.Controls.Add(this.BtnFun);
            this.Controls.Add(this.BtnRest);
            this.Controls.Add(this.BtnGoals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimeSpent";
            this.Text = "На что вы потратили большую часть прошедшего часа?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeSpent_FormClosing);
            this.Load += new System.EventHandler(this.TimeSpent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBusiness;
        private System.Windows.Forms.Button BtnFun;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Button BtnGoals;
        private System.Windows.Forms.Button BtnReady;
        private System.Windows.Forms.Label lblPrevHour;
        private System.Windows.Forms.DataGridView dataGridBusiness;
    }
}