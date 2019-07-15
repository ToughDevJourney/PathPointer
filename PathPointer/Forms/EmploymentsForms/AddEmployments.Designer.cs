namespace PathPointer
{
    partial class AddEmployments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployments));
            this.dataGridBusiness = new System.Windows.Forms.DataGridView();
            this.BtnGoals = new System.Windows.Forms.Button();
            this.BtnFun = new System.Windows.Forms.Button();
            this.BtnBusiness = new System.Windows.Forms.Button();
            this.BackMain = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridBusiness.Location = new System.Drawing.Point(405, 11);
            this.dataGridBusiness.MultiSelect = false;
            this.dataGridBusiness.Name = "dataGridBusiness";
            this.dataGridBusiness.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBusiness.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBusiness.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBusiness.Size = new System.Drawing.Size(273, 470);
            this.dataGridBusiness.TabIndex = 0;
            this.dataGridBusiness.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBusiness_CellValueChanged);
            this.dataGridBusiness.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridBusiness_KeyDown);
            // 
            // BtnGoals
            // 
            this.BtnGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnGoals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGoals.BackgroundImage")));
            this.BtnGoals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGoals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoals.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnGoals.ForeColor = System.Drawing.Color.White;
            this.BtnGoals.Location = new System.Drawing.Point(11, 231);
            this.BtnGoals.Name = "BtnGoals";
            this.BtnGoals.Size = new System.Drawing.Size(187, 250);
            this.BtnGoals.TabIndex = 1;
            this.BtnGoals.Text = "Цели";
            this.BtnGoals.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGoals.UseVisualStyleBackColor = false;
            this.BtnGoals.Click += new System.EventHandler(this.BtnGoals_Click);
            // 
            // BtnFun
            // 
            this.BtnFun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFun.BackgroundImage")));
            this.BtnFun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFun.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnFun.ForeColor = System.Drawing.Color.White;
            this.BtnFun.Location = new System.Drawing.Point(204, 256);
            this.BtnFun.Name = "BtnFun";
            this.BtnFun.Size = new System.Drawing.Size(187, 225);
            this.BtnFun.TabIndex = 3;
            this.BtnFun.Text = "Развлечения";
            this.BtnFun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFun.UseVisualStyleBackColor = false;
            this.BtnFun.Click += new System.EventHandler(this.BtnFun_Click);
            // 
            // BtnBusiness
            // 
            this.BtnBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnBusiness.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBusiness.BackgroundImage")));
            this.BtnBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBusiness.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnBusiness.ForeColor = System.Drawing.Color.White;
            this.BtnBusiness.Location = new System.Drawing.Point(11, 12);
            this.BtnBusiness.Name = "BtnBusiness";
            this.BtnBusiness.Size = new System.Drawing.Size(187, 213);
            this.BtnBusiness.TabIndex = 4;
            this.BtnBusiness.Text = "Неотложные дела";
            this.BtnBusiness.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBusiness.UseVisualStyleBackColor = false;
            this.BtnBusiness.Click += new System.EventHandler(this.BtnBusiness_Click);
            // 
            // BackMain
            // 
            this.BackMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BackMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackMain.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BackMain.ForeColor = System.Drawing.Color.White;
            this.BackMain.Location = new System.Drawing.Point(693, 424);
            this.BackMain.Name = "BackMain";
            this.BackMain.Size = new System.Drawing.Size(247, 57);
            this.BackMain.TabIndex = 5;
            this.BackMain.Text = "Вернуться";
            this.BackMain.UseVisualStyleBackColor = false;
            this.BackMain.Click += new System.EventHandler(this.BackMain_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(693, 11);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(247, 397);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnRest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRest.BackgroundImage")));
            this.BtnRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRest.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnRest.ForeColor = System.Drawing.Color.White;
            this.BtnRest.Location = new System.Drawing.Point(204, 12);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(187, 238);
            this.BtnRest.TabIndex = 2;
            this.BtnRest.Text = "Отдых";
            this.BtnRest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRest.UseVisualStyleBackColor = false;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // AddEmployments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(955, 495);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackMain);
            this.Controls.Add(this.BtnBusiness);
            this.Controls.Add(this.BtnFun);
            this.Controls.Add(this.BtnRest);
            this.Controls.Add(this.BtnGoals);
            this.Controls.Add(this.dataGridBusiness);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddEmployments";
            this.Text = "Занятия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employments_FormClosing);
            this.Load += new System.EventHandler(this.Employments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusiness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBusiness;
        private System.Windows.Forms.Button BtnGoals;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Button BtnFun;
        private System.Windows.Forms.Button BtnBusiness;
        private System.Windows.Forms.Button BackMain;
        private System.Windows.Forms.Button AddButton;
    }
}