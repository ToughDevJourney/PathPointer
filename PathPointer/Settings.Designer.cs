namespace PathPointer
{
    partial class Settings
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
            this.lblMotivationHints = new System.Windows.Forms.Label();
            this.lblSleepTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChBMotivHints = new System.Windows.Forms.CheckBox();
            this.lblDifficultyLvl = new System.Windows.Forms.Label();
            this.CBDifficulty = new System.Windows.Forms.ComboBox();
            this.ChBCloseGames = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ChBHardMotiv = new System.Windows.Forms.CheckBox();
            this.lblHardMotivation = new System.Windows.Forms.Label();
            this.lblSoftMotivation = new System.Windows.Forms.Label();
            this.ChBSoftMotiv = new System.Windows.Forms.CheckBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CBGamesList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddGame = new System.Windows.Forms.Button();
            this.BtnRemoveGame = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.MTBSleepBegin = new System.Windows.Forms.MaskedTextBox();
            this.MTBSleepEnd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblMotivationHints
            // 
            this.lblMotivationHints.AutoSize = true;
            this.lblMotivationHints.Location = new System.Drawing.Point(23, 103);
            this.lblMotivationHints.Name = "lblMotivationHints";
            this.lblMotivationHints.Size = new System.Drawing.Size(146, 13);
            this.lblMotivationHints.TabIndex = 0;
            this.lblMotivationHints.Text = "Мотивационные подсказки";
            // 
            // lblSleepTime
            // 
            this.lblSleepTime.AutoSize = true;
            this.lblSleepTime.Location = new System.Drawing.Point(23, 65);
            this.lblSleepTime.Name = "lblSleepTime";
            this.lblSleepTime.Size = new System.Drawing.Size(66, 13);
            this.lblSleepTime.TabIndex = 1;
            this.lblSleepTime.Text = "Режим сна:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "С";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "По";
            // 
            // ChBMotivHints
            // 
            this.ChBMotivHints.AutoSize = true;
            this.ChBMotivHints.Location = new System.Drawing.Point(263, 102);
            this.ChBMotivHints.Name = "ChBMotivHints";
            this.ChBMotivHints.Size = new System.Drawing.Size(15, 14);
            this.ChBMotivHints.TabIndex = 7;
            this.ChBMotivHints.UseVisualStyleBackColor = true;
            // 
            // lblDifficultyLvl
            // 
            this.lblDifficultyLvl.AutoSize = true;
            this.lblDifficultyLvl.Location = new System.Drawing.Point(23, 31);
            this.lblDifficultyLvl.Name = "lblDifficultyLvl";
            this.lblDifficultyLvl.Size = new System.Drawing.Size(66, 13);
            this.lblDifficultyLvl.TabIndex = 8;
            this.lblDifficultyLvl.Text = "Сложность:";
            // 
            // CBDifficulty
            // 
            this.CBDifficulty.FormattingEnabled = true;
            this.CBDifficulty.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Сложный",
            "Без жалости к себе",
            "Пользовательский"});
            this.CBDifficulty.Location = new System.Drawing.Point(112, 31);
            this.CBDifficulty.Name = "CBDifficulty";
            this.CBDifficulty.Size = new System.Drawing.Size(166, 21);
            this.CBDifficulty.TabIndex = 9;
            // 
            // ChBCloseGames
            // 
            this.ChBCloseGames.AutoSize = true;
            this.ChBCloseGames.Location = new System.Drawing.Point(908, 28);
            this.ChBCloseGames.Name = "ChBCloseGames";
            this.ChBCloseGames.Size = new System.Drawing.Size(15, 14);
            this.ChBCloseGames.TabIndex = 11;
            this.ChBCloseGames.UseVisualStyleBackColor = true;
            this.ChBCloseGames.CheckedChanged += new System.EventHandler(this.ChBCloseGames_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Принудительно завершать игры";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Часов игры до принудительного завершения:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(908, 142);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(15, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "2";
            // 
            // ChBHardMotiv
            // 
            this.ChBHardMotiv.AutoSize = true;
            this.ChBHardMotiv.Location = new System.Drawing.Point(240, 123);
            this.ChBHardMotiv.Name = "ChBHardMotiv";
            this.ChBHardMotiv.Size = new System.Drawing.Size(15, 14);
            this.ChBHardMotiv.TabIndex = 16;
            this.ChBHardMotiv.UseVisualStyleBackColor = true;
            // 
            // lblHardMotivation
            // 
            this.lblHardMotivation.AutoSize = true;
            this.lblHardMotivation.Location = new System.Drawing.Point(23, 123);
            this.lblHardMotivation.Name = "lblHardMotivation";
            this.lblHardMotivation.Size = new System.Drawing.Size(111, 13);
            this.lblHardMotivation.TabIndex = 15;
            this.lblHardMotivation.Text = "Жесткая мотивация";
            // 
            // lblSoftMotivation
            // 
            this.lblSoftMotivation.AutoSize = true;
            this.lblSoftMotivation.Location = new System.Drawing.Point(23, 141);
            this.lblSoftMotivation.Name = "lblSoftMotivation";
            this.lblSoftMotivation.Size = new System.Drawing.Size(103, 13);
            this.lblSoftMotivation.TabIndex = 17;
            this.lblSoftMotivation.Text = "Мягкая мотивация";
            // 
            // ChBSoftMotiv
            // 
            this.ChBSoftMotiv.AutoSize = true;
            this.ChBSoftMotiv.Location = new System.Drawing.Point(240, 144);
            this.ChBSoftMotiv.Name = "ChBSoftMotiv";
            this.ChBSoftMotiv.Size = new System.Drawing.Size(15, 14);
            this.ChBSoftMotiv.TabIndex = 18;
            this.ChBSoftMotiv.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(671, 185);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(252, 40);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "Вернуться";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnDefault
            // 
            this.BtnDefault.Location = new System.Drawing.Point(350, 185);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(252, 40);
            this.BtnDefault.TabIndex = 20;
            this.BtnDefault.Text = "Сброс программы";
            this.BtnDefault.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Напоминать о работе через часов отдыха";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(588, 28);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(14, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(588, 53);
            this.textBox5.MaxLength = 1;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(14, 20);
            this.textBox5.TabIndex = 25;
            this.textBox5.Text = "4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(347, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Напоминать об отдыхе через часов работы";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(588, 95);
            this.textBox6.MaxLength = 1;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(14, 20);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(347, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Количество часов сбора статистики";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(582, 138);
            this.textBox7.MaxLength = 2;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(20, 20);
            this.textBox7.TabIndex = 31;
            this.textBox7.Text = "14";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(347, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(205, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Нужно часов в неделю на развлечения";
            // 
            // CBGamesList
            // 
            this.CBGamesList.FormattingEnabled = true;
            this.CBGamesList.Location = new System.Drawing.Point(741, 81);
            this.CBGamesList.Name = "CBGamesList";
            this.CBGamesList.Size = new System.Drawing.Size(133, 21);
            this.CBGamesList.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Список игр:";
            // 
            // BtnAddGame
            // 
            this.BtnAddGame.Location = new System.Drawing.Point(879, 81);
            this.BtnAddGame.Name = "BtnAddGame";
            this.BtnAddGame.Size = new System.Drawing.Size(21, 20);
            this.BtnAddGame.TabIndex = 36;
            this.BtnAddGame.Text = "+";
            this.BtnAddGame.UseVisualStyleBackColor = true;
            this.BtnAddGame.Click += new System.EventHandler(this.BtnAddGame_Click);
            // 
            // BtnRemoveGame
            // 
            this.BtnRemoveGame.Location = new System.Drawing.Point(901, 82);
            this.BtnRemoveGame.Name = "BtnRemoveGame";
            this.BtnRemoveGame.Size = new System.Drawing.Size(21, 20);
            this.BtnRemoveGame.TabIndex = 37;
            this.BtnRemoveGame.Text = "-";
            this.BtnRemoveGame.UseVisualStyleBackColor = true;
            this.BtnRemoveGame.Click += new System.EventHandler(this.BtnRemoveGame_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(26, 185);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(252, 40);
            this.BtnAccept.TabIndex = 38;
            this.BtnAccept.Text = "Применить";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // MTBSleepBegin
            // 
            this.MTBSleepBegin.Location = new System.Drawing.Point(180, 62);
            this.MTBSleepBegin.Mask = "00:00";
            this.MTBSleepBegin.Name = "MTBSleepBegin";
            this.MTBSleepBegin.Size = new System.Drawing.Size(31, 20);
            this.MTBSleepBegin.TabIndex = 41;
            this.MTBSleepBegin.ValidatingType = typeof(System.DateTime);
            // 
            // MTBSleepEnd
            // 
            this.MTBSleepEnd.Location = new System.Drawing.Point(247, 58);
            this.MTBSleepEnd.Mask = "00:00";
            this.MTBSleepEnd.Name = "MTBSleepEnd";
            this.MTBSleepEnd.Size = new System.Drawing.Size(31, 20);
            this.MTBSleepEnd.TabIndex = 42;
            this.MTBSleepEnd.ValidatingType = typeof(System.DateTime);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 253);
            this.Controls.Add(this.MTBSleepEnd);
            this.Controls.Add(this.MTBSleepBegin);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnRemoveGame);
            this.Controls.Add(this.BtnAddGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBGamesList);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ChBSoftMotiv);
            this.Controls.Add(this.lblSoftMotivation);
            this.Controls.Add(this.ChBHardMotiv);
            this.Controls.Add(this.lblHardMotivation);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChBCloseGames);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBDifficulty);
            this.Controls.Add(this.lblDifficultyLvl);
            this.Controls.Add(this.ChBMotivHints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSleepTime);
            this.Controls.Add(this.lblMotivationHints);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMotivationHints;
        private System.Windows.Forms.Label lblSleepTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChBMotivHints;
        private System.Windows.Forms.Label lblDifficultyLvl;
        private System.Windows.Forms.ComboBox CBDifficulty;
        private System.Windows.Forms.CheckBox ChBCloseGames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox ChBHardMotiv;
        private System.Windows.Forms.Label lblHardMotivation;
        private System.Windows.Forms.Label lblSoftMotivation;
        private System.Windows.Forms.CheckBox ChBSoftMotiv;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnDefault;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox CBGamesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddGame;
        private System.Windows.Forms.Button BtnRemoveGame;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.MaskedTextBox MTBSleepBegin;
        private System.Windows.Forms.MaskedTextBox MTBSleepEnd;
    }
}