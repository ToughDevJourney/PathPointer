namespace PathPointer
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployButton = new System.Windows.Forms.Button();
            this.BtnMoreStats = new System.Windows.Forms.Button();
            this.BtnGoals = new System.Windows.Forms.Button();
            this.BtnAchivements = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pathPointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerHour = new System.Windows.Forms.Timer(this.components);
            this.DataGridBusiness = new System.Windows.Forms.DataGridView();
            this.DataGridDayOfWeek = new System.Windows.Forms.DataGridView();
            this.lblEmployName = new System.Windows.Forms.Label();
            this.lblEmployType = new System.Windows.Forms.Label();
            this.lblDoneHours = new System.Windows.Forms.Label();
            this.lblMustSpend = new System.Windows.Forms.Label();
            this.lblEmploymentHour = new System.Windows.Forms.Label();
            this.dayOfWeekPointer = new System.Windows.Forms.DataGridView();
            this.businessPointer = new System.Windows.Forms.DataGridView();
            this.TrayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDayOfWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessPointer)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployButton
            // 
            this.EmployButton.Location = new System.Drawing.Point(0, 0);
            this.EmployButton.Name = "EmployButton";
            this.EmployButton.Size = new System.Drawing.Size(170, 97);
            this.EmployButton.TabIndex = 1;
            this.EmployButton.Text = "Ваши занятия";
            this.EmployButton.UseVisualStyleBackColor = true;
            this.EmployButton.Click += new System.EventHandler(this.EmployButton_Click);
            // 
            // BtnMoreStats
            // 
            this.BtnMoreStats.Location = new System.Drawing.Point(0, 97);
            this.BtnMoreStats.Name = "BtnMoreStats";
            this.BtnMoreStats.Size = new System.Drawing.Size(170, 97);
            this.BtnMoreStats.TabIndex = 2;
            this.BtnMoreStats.Text = "Расширенная статистика";
            this.BtnMoreStats.UseVisualStyleBackColor = true;
            this.BtnMoreStats.Click += new System.EventHandler(this.BtnMoreStats_Click);
            // 
            // BtnGoals
            // 
            this.BtnGoals.Location = new System.Drawing.Point(0, 194);
            this.BtnGoals.Name = "BtnGoals";
            this.BtnGoals.Size = new System.Drawing.Size(170, 97);
            this.BtnGoals.TabIndex = 3;
            this.BtnGoals.Text = "Ваши цели";
            this.BtnGoals.UseVisualStyleBackColor = true;
            // 
            // BtnAchivements
            // 
            this.BtnAchivements.Location = new System.Drawing.Point(0, 293);
            this.BtnAchivements.Name = "BtnAchivements";
            this.BtnAchivements.Size = new System.Drawing.Size(170, 97);
            this.BtnAchivements.TabIndex = 4;
            this.BtnAchivements.Text = "Достижения";
            this.BtnAchivements.UseVisualStyleBackColor = true;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(0, 393);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(170, 97);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Настройки";
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Path Pointer";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayContextMenu
            // 
            this.TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathPointerToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.TrayContextMenu.Name = "TrayContextMenu";
            this.TrayContextMenu.Size = new System.Drawing.Size(140, 48);
            // 
            // pathPointerToolStripMenuItem
            // 
            this.pathPointerToolStripMenuItem.Name = "pathPointerToolStripMenuItem";
            this.pathPointerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pathPointerToolStripMenuItem.Text = "Path Pointer";
            this.pathPointerToolStripMenuItem.Click += new System.EventHandler(this.pathPointerToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.закрытьToolStripMenuItem.Text = "Выход";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // TimerHour
            // 
            this.TimerHour.Enabled = true;
            this.TimerHour.Tick += new System.EventHandler(this.TimerHour_Tick);
            // 
            // DataGridBusiness
            // 
            this.DataGridBusiness.AllowUserToAddRows = false;
            this.DataGridBusiness.AllowUserToDeleteRows = false;
            this.DataGridBusiness.AllowUserToResizeColumns = false;
            this.DataGridBusiness.AllowUserToResizeRows = false;
            this.DataGridBusiness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBusiness.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridBusiness.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridBusiness.EnableHeadersVisualStyles = false;
            this.DataGridBusiness.GridColor = System.Drawing.Color.Black;
            this.DataGridBusiness.Location = new System.Drawing.Point(176, 448);
            this.DataGridBusiness.MultiSelect = false;
            this.DataGridBusiness.Name = "DataGridBusiness";
            this.DataGridBusiness.ReadOnly = true;
            this.DataGridBusiness.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBusiness.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridBusiness.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridBusiness.Size = new System.Drawing.Size(930, 20);
            this.DataGridBusiness.TabIndex = 12;
            this.DataGridBusiness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBusiness_CellClick);
            // 
            // DataGridDayOfWeek
            // 
            this.DataGridDayOfWeek.AllowUserToAddRows = false;
            this.DataGridDayOfWeek.AllowUserToDeleteRows = false;
            this.DataGridDayOfWeek.AllowUserToResizeColumns = false;
            this.DataGridDayOfWeek.AllowUserToResizeRows = false;
            this.DataGridDayOfWeek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridDayOfWeek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridDayOfWeek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDayOfWeek.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridDayOfWeek.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridDayOfWeek.EnableHeadersVisualStyles = false;
            this.DataGridDayOfWeek.GridColor = System.Drawing.Color.Black;
            this.DataGridDayOfWeek.Location = new System.Drawing.Point(176, 422);
            this.DataGridDayOfWeek.MultiSelect = false;
            this.DataGridDayOfWeek.Name = "DataGridDayOfWeek";
            this.DataGridDayOfWeek.ReadOnly = true;
            this.DataGridDayOfWeek.RowHeadersVisible = false;
            this.DataGridDayOfWeek.RowHeadersWidth = 10;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDayOfWeek.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridDayOfWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridDayOfWeek.Size = new System.Drawing.Size(930, 20);
            this.DataGridDayOfWeek.TabIndex = 13;
            this.DataGridDayOfWeek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDayOfWeek_CellClick);
            // 
            // lblEmployName
            // 
            this.lblEmployName.AutoSize = true;
            this.lblEmployName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployName.Location = new System.Drawing.Point(218, 30);
            this.lblEmployName.Name = "lblEmployName";
            this.lblEmployName.Size = new System.Drawing.Size(290, 33);
            this.lblEmployName.TabIndex = 14;
            this.lblEmployName.Text = "Название занятости";
            // 
            // lblEmployType
            // 
            this.lblEmployType.AutoSize = true;
            this.lblEmployType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployType.Location = new System.Drawing.Point(221, 150);
            this.lblEmployType.Name = "lblEmployType";
            this.lblEmployType.Size = new System.Drawing.Size(119, 20);
            this.lblEmployType.TabIndex = 15;
            this.lblEmployType.Text = "Тип занятости";
            // 
            // lblDoneHours
            // 
            this.lblDoneHours.AutoSize = true;
            this.lblDoneHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoneHours.Location = new System.Drawing.Point(221, 295);
            this.lblDoneHours.Name = "lblDoneHours";
            this.lblDoneHours.Size = new System.Drawing.Size(224, 24);
            this.lblDoneHours.TabIndex = 16;
            this.lblDoneHours.Text = "Выполнено 0 часов из 0";
            // 
            // lblMustSpend
            // 
            this.lblMustSpend.AutoSize = true;
            this.lblMustSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMustSpend.Location = new System.Drawing.Point(220, 361);
            this.lblMustSpend.Name = "lblMustSpend";
            this.lblMustSpend.Size = new System.Drawing.Size(135, 20);
            this.lblMustSpend.TabIndex = 17;
            this.lblMustSpend.Text = "Такими темпами";
            // 
            // lblEmploymentHour
            // 
            this.lblEmploymentHour.AutoSize = true;
            this.lblEmploymentHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmploymentHour.Location = new System.Drawing.Point(969, 30);
            this.lblEmploymentHour.Name = "lblEmploymentHour";
            this.lblEmploymentHour.Size = new System.Drawing.Size(112, 42);
            this.lblEmploymentHour.TabIndex = 18;
            this.lblEmploymentHour.Text = "00:00";
            // 
            // dayOfWeekPointer
            // 
            this.dayOfWeekPointer.AllowUserToAddRows = false;
            this.dayOfWeekPointer.AllowUserToDeleteRows = false;
            this.dayOfWeekPointer.AllowUserToResizeColumns = false;
            this.dayOfWeekPointer.AllowUserToResizeRows = false;
            this.dayOfWeekPointer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dayOfWeekPointer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dayOfWeekPointer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dayOfWeekPointer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayOfWeekPointer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayOfWeekPointer.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dayOfWeekPointer.DefaultCellStyle = dataGridViewCellStyle5;
            this.dayOfWeekPointer.EnableHeadersVisualStyles = false;
            this.dayOfWeekPointer.GridColor = System.Drawing.SystemColors.Control;
            this.dayOfWeekPointer.Location = new System.Drawing.Point(176, 400);
            this.dayOfWeekPointer.MultiSelect = false;
            this.dayOfWeekPointer.Name = "dayOfWeekPointer";
            this.dayOfWeekPointer.ReadOnly = true;
            this.dayOfWeekPointer.RowHeadersVisible = false;
            this.dayOfWeekPointer.RowHeadersWidth = 10;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dayOfWeekPointer.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dayOfWeekPointer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dayOfWeekPointer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dayOfWeekPointer.Size = new System.Drawing.Size(930, 20);
            this.dayOfWeekPointer.TabIndex = 19;
            // 
            // businessPointer
            // 
            this.businessPointer.AllowUserToAddRows = false;
            this.businessPointer.AllowUserToDeleteRows = false;
            this.businessPointer.AllowUserToResizeColumns = false;
            this.businessPointer.AllowUserToResizeRows = false;
            this.businessPointer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.businessPointer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.businessPointer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.businessPointer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.businessPointer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessPointer.ColumnHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.businessPointer.DefaultCellStyle = dataGridViewCellStyle7;
            this.businessPointer.EnableHeadersVisualStyles = false;
            this.businessPointer.GridColor = System.Drawing.SystemColors.Control;
            this.businessPointer.Location = new System.Drawing.Point(176, 470);
            this.businessPointer.MultiSelect = false;
            this.businessPointer.Name = "businessPointer";
            this.businessPointer.ReadOnly = true;
            this.businessPointer.RowHeadersVisible = false;
            this.businessPointer.RowHeadersWidth = 10;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.businessPointer.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.businessPointer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.businessPointer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessPointer.Size = new System.Drawing.Size(930, 20);
            this.businessPointer.TabIndex = 20;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 494);
            this.Controls.Add(this.businessPointer);
            this.Controls.Add(this.dayOfWeekPointer);
            this.Controls.Add(this.lblEmploymentHour);
            this.Controls.Add(this.lblMustSpend);
            this.Controls.Add(this.lblDoneHours);
            this.Controls.Add(this.lblEmployType);
            this.Controls.Add(this.lblEmployName);
            this.Controls.Add(this.DataGridDayOfWeek);
            this.Controls.Add(this.DataGridBusiness);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnAchivements);
            this.Controls.Add(this.BtnGoals);
            this.Controls.Add(this.BtnMoreStats);
            this.Controls.Add(this.EmployButton);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.TrayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDayOfWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessPointer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EmployButton;
        private System.Windows.Forms.Button BtnMoreStats;
        private System.Windows.Forms.Button BtnGoals;
        private System.Windows.Forms.Button BtnAchivements;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pathPointerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Timer TimerHour;
        public System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.DataGridView DataGridBusiness;
        private System.Windows.Forms.DataGridView DataGridDayOfWeek;
        private System.Windows.Forms.Label lblEmployName;
        private System.Windows.Forms.Label lblEmployType;
        private System.Windows.Forms.Label lblDoneHours;
        private System.Windows.Forms.Label lblMustSpend;
        private System.Windows.Forms.Label lblEmploymentHour;
        private System.Windows.Forms.DataGridView dayOfWeekPointer;
        private System.Windows.Forms.DataGridView businessPointer;
    }
}

