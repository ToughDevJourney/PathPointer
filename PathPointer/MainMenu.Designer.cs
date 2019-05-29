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
            this.EmployButton = new System.Windows.Forms.Button();
            this.BtnMoreStats = new System.Windows.Forms.Button();
            this.BtnGoals = new System.Windows.Forms.Button();
            this.BtnAchivements = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pathPointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerHour = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TrayContextMenu.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 155);
            this.dataGridView1.TabIndex = 5;
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
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // TimerHour
            // 
            this.TimerHour.Enabled = true;
            this.TimerHour.Tick += new System.EventHandler(this.TimerHour_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 494);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAchivements);
            this.Controls.Add(this.BtnGoals);
            this.Controls.Add(this.BtnMoreStats);
            this.Controls.Add(this.EmployButton);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EmployButton;
        private System.Windows.Forms.Button BtnMoreStats;
        private System.Windows.Forms.Button BtnGoals;
        private System.Windows.Forms.Button BtnAchivements;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pathPointerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Timer TimerHour;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

