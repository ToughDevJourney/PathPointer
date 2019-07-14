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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pathPointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerHour = new System.Windows.Forms.Timer(this.components);
            this.DataGridBusiness = new System.Windows.Forms.DataGridView();
            this.DataGridDayOfWeek = new System.Windows.Forms.DataGridView();
            this.dayOfWeekPointer = new System.Windows.Forms.DataGridView();
            this.businessPointer = new System.Windows.Forms.DataGridView();
            this.lblMustSpend = new System.Windows.Forms.Label();
            this.lblEmploymentHour = new System.Windows.Forms.Label();
            this.lblDoneHours = new System.Windows.Forms.Label();
            this.lblEmployType = new System.Windows.Forms.Label();
            this.lblEmployName = new System.Windows.Forms.Label();
            this.BtnAchivements = new System.Windows.Forms.Button();
            this.BtnGoals = new System.Windows.Forms.Button();
            this.BtnMoreStats = new System.Windows.Forms.Button();
            this.EmployButton = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.TrayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDayOfWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessPointer)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridBusiness.DefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridBusiness.EnableHeadersVisualStyles = false;
            this.DataGridBusiness.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.DataGridBusiness.Location = new System.Drawing.Point(176, 436);
            this.DataGridBusiness.MultiSelect = false;
            this.DataGridBusiness.Name = "DataGridBusiness";
            this.DataGridBusiness.ReadOnly = true;
            this.DataGridBusiness.RowHeadersVisible = false;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBusiness.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridBusiness.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridBusiness.Size = new System.Drawing.Size(930, 25);
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Candara", 12.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(88)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridDayOfWeek.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridDayOfWeek.EnableHeadersVisualStyles = false;
            this.DataGridDayOfWeek.GridColor = System.Drawing.Color.White;
            this.DataGridDayOfWeek.Location = new System.Drawing.Point(176, 405);
            this.DataGridDayOfWeek.MultiSelect = false;
            this.DataGridDayOfWeek.Name = "DataGridDayOfWeek";
            this.DataGridDayOfWeek.ReadOnly = true;
            this.DataGridDayOfWeek.RowHeadersVisible = false;
            this.DataGridDayOfWeek.RowHeadersWidth = 10;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDayOfWeek.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridDayOfWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridDayOfWeek.Size = new System.Drawing.Size(930, 28);
            this.DataGridDayOfWeek.TabIndex = 13;
            this.DataGridDayOfWeek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDayOfWeek_CellClick);
            // 
            // dayOfWeekPointer
            // 
            this.dayOfWeekPointer.AllowUserToAddRows = false;
            this.dayOfWeekPointer.AllowUserToDeleteRows = false;
            this.dayOfWeekPointer.AllowUserToResizeColumns = false;
            this.dayOfWeekPointer.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dayOfWeekPointer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dayOfWeekPointer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dayOfWeekPointer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dayOfWeekPointer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.dayOfWeekPointer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayOfWeekPointer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayOfWeekPointer.ColumnHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dayOfWeekPointer.DefaultCellStyle = dataGridViewCellStyle15;
            this.dayOfWeekPointer.EnableHeadersVisualStyles = false;
            this.dayOfWeekPointer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.dayOfWeekPointer.Location = new System.Drawing.Point(176, 381);
            this.dayOfWeekPointer.MultiSelect = false;
            this.dayOfWeekPointer.Name = "dayOfWeekPointer";
            this.dayOfWeekPointer.ReadOnly = true;
            this.dayOfWeekPointer.RowHeadersVisible = false;
            this.dayOfWeekPointer.RowHeadersWidth = 10;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dayOfWeekPointer.RowsDefaultCellStyle = dataGridViewCellStyle16;
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
            this.businessPointer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.businessPointer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.businessPointer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessPointer.ColumnHeadersVisible = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.businessPointer.DefaultCellStyle = dataGridViewCellStyle17;
            this.businessPointer.EnableHeadersVisualStyles = false;
            this.businessPointer.GridColor = System.Drawing.SystemColors.Control;
            this.businessPointer.Location = new System.Drawing.Point(176, 464);
            this.businessPointer.MultiSelect = false;
            this.businessPointer.Name = "businessPointer";
            this.businessPointer.ReadOnly = true;
            this.businessPointer.RowHeadersVisible = false;
            this.businessPointer.RowHeadersWidth = 10;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.businessPointer.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.businessPointer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.businessPointer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessPointer.Size = new System.Drawing.Size(930, 20);
            this.businessPointer.TabIndex = 20;
            // 
            // lblMustSpend
            // 
            this.lblMustSpend.AutoSize = true;
            this.lblMustSpend.BackColor = System.Drawing.Color.Transparent;
            this.lblMustSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMustSpend.ForeColor = System.Drawing.Color.White;
            this.lblMustSpend.Location = new System.Drawing.Point(355, 974);
            this.lblMustSpend.Name = "lblMustSpend";
            this.lblMustSpend.Size = new System.Drawing.Size(135, 20);
            this.lblMustSpend.TabIndex = 17;
            this.lblMustSpend.Text = "Такими темпами";
            // 
            // lblEmploymentHour
            // 
            this.lblEmploymentHour.AutoSize = true;
            this.lblEmploymentHour.BackColor = System.Drawing.Color.Transparent;
            this.lblEmploymentHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmploymentHour.ForeColor = System.Drawing.Color.White;
            this.lblEmploymentHour.Location = new System.Drawing.Point(980, 27);
            this.lblEmploymentHour.Name = "lblEmploymentHour";
            this.lblEmploymentHour.Size = new System.Drawing.Size(112, 42);
            this.lblEmploymentHour.TabIndex = 18;
            this.lblEmploymentHour.Text = "00:00";
            // 
            // lblDoneHours
            // 
            this.lblDoneHours.AutoSize = true;
            this.lblDoneHours.BackColor = System.Drawing.Color.Transparent;
            this.lblDoneHours.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblDoneHours.ForeColor = System.Drawing.Color.White;
            this.lblDoneHours.Location = new System.Drawing.Point(196, 305);
            this.lblDoneHours.Name = "lblDoneHours";
            this.lblDoneHours.Size = new System.Drawing.Size(201, 23);
            this.lblDoneHours.TabIndex = 16;
            this.lblDoneHours.Text = "Выполнено 0 часов из 0";
            // 
            // lblEmployType
            // 
            this.lblEmployType.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployType.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployType.ForeColor = System.Drawing.Color.White;
            this.lblEmployType.Location = new System.Drawing.Point(196, 165);
            this.lblEmployType.Name = "lblEmployType";
            this.lblEmployType.Size = new System.Drawing.Size(896, 142);
            this.lblEmployType.TabIndex = 15;
            this.lblEmployType.Text = "Тип занятости";
            // 
            // lblEmployName
            // 
            this.lblEmployName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployName.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployName.ForeColor = System.Drawing.Color.White;
            this.lblEmployName.Location = new System.Drawing.Point(193, 27);
            this.lblEmployName.Name = "lblEmployName";
            this.lblEmployName.Size = new System.Drawing.Size(781, 124);
            this.lblEmployName.TabIndex = 14;
            this.lblEmployName.Text = "Название занятости";
            // 
            // BtnAchivements
            // 
            this.BtnAchivements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnAchivements.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAchivements.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAchivements.ForeColor = System.Drawing.Color.White;
            this.BtnAchivements.Location = new System.Drawing.Point(-1, 294);
            this.BtnAchivements.Name = "BtnAchivements";
            this.BtnAchivements.Size = new System.Drawing.Size(170, 100);
            this.BtnAchivements.TabIndex = 4;
            this.BtnAchivements.Text = "Достижения";
            this.BtnAchivements.UseVisualStyleBackColor = false;
            this.BtnAchivements.Click += new System.EventHandler(this.BtnAchivements_Click);
            // 
            // BtnGoals
            // 
            this.BtnGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnGoals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoals.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGoals.ForeColor = System.Drawing.Color.White;
            this.BtnGoals.Location = new System.Drawing.Point(-1, 195);
            this.BtnGoals.Name = "BtnGoals";
            this.BtnGoals.Size = new System.Drawing.Size(170, 100);
            this.BtnGoals.TabIndex = 3;
            this.BtnGoals.Text = "Ваши цели";
            this.BtnGoals.UseVisualStyleBackColor = false;
            this.BtnGoals.Click += new System.EventHandler(this.BtnGoals_Click);
            // 
            // BtnMoreStats
            // 
            this.BtnMoreStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnMoreStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMoreStats.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMoreStats.ForeColor = System.Drawing.Color.White;
            this.BtnMoreStats.Location = new System.Drawing.Point(-1, 97);
            this.BtnMoreStats.Name = "BtnMoreStats";
            this.BtnMoreStats.Size = new System.Drawing.Size(170, 100);
            this.BtnMoreStats.TabIndex = 2;
            this.BtnMoreStats.Text = "Расширенная статистика";
            this.BtnMoreStats.UseVisualStyleBackColor = false;
            this.BtnMoreStats.Click += new System.EventHandler(this.BtnMoreStats_Click);
            // 
            // EmployButton
            // 
            this.EmployButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.EmployButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployButton.ForeColor = System.Drawing.Color.White;
            this.EmployButton.Location = new System.Drawing.Point(-1, -1);
            this.EmployButton.Name = "EmployButton";
            this.EmployButton.Size = new System.Drawing.Size(170, 100);
            this.EmployButton.TabIndex = 1;
            this.EmployButton.Text = "Ваши занятия";
            this.EmployButton.UseVisualStyleBackColor = false;
            this.EmployButton.Click += new System.EventHandler(this.EmployButton_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSettings.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Location = new System.Drawing.Point(-1, 392);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(170, 100);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Настройки";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1121, 492);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.EmployButton);
            this.Controls.Add(this.BtnMoreStats);
            this.Controls.Add(this.BtnGoals);
            this.Controls.Add(this.lblEmployName);
            this.Controls.Add(this.BtnAchivements);
            this.Controls.Add(this.lblEmployType);
            this.Controls.Add(this.lblDoneHours);
            this.Controls.Add(this.lblEmploymentHour);
            this.Controls.Add(this.businessPointer);
            this.Controls.Add(this.lblMustSpend);
            this.Controls.Add(this.dayOfWeekPointer);
            this.Controls.Add(this.DataGridDayOfWeek);
            this.Controls.Add(this.DataGridBusiness);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.TrayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDayOfWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessPointer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pathPointerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Timer TimerHour;
        public System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.DataGridView dayOfWeekPointer;
        private System.Windows.Forms.DataGridView businessPointer;
        public System.Windows.Forms.DataGridView DataGridBusiness;
        public System.Windows.Forms.DataGridView DataGridDayOfWeek;
        private System.Windows.Forms.Label lblMustSpend;
        private System.Windows.Forms.Label lblEmploymentHour;
        private System.Windows.Forms.Label lblDoneHours;
        private System.Windows.Forms.Label lblEmployType;
        private System.Windows.Forms.Label lblEmployName;
        private System.Windows.Forms.Button BtnAchivements;
        private System.Windows.Forms.Button BtnGoals;
        private System.Windows.Forms.Button BtnMoreStats;
        private System.Windows.Forms.Button EmployButton;
        private System.Windows.Forms.Button BtnSettings;
        //    private TransparentDataGridView transparentDataGridView1;
    }
}

