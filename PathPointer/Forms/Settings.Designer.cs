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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBHrsToStopGms = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TBHrsToRest = new System.Windows.Forms.TextBox();
            this.TBHrsToWork = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBGetStatsHrs = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TBFunHrsPerWeek = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CBGamesList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddGame = new System.Windows.Forms.Button();
            this.BtnRemoveGame = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.MTBSleepBegin = new System.Windows.Forms.MaskedTextBox();
            this.MTBSleepEnd = new System.Windows.Forms.MaskedTextBox();
            this.ChBMotivHints = new PathPointer.BiggerCheckBox();
            this.ChBCloseGames = new PathPointer.BiggerCheckBox();
            this.SuspendLayout();
            // 
            // lblMotivationHints
            // 
            this.lblMotivationHints.AutoSize = true;
            this.lblMotivationHints.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblMotivationHints.ForeColor = System.Drawing.Color.White;
            this.lblMotivationHints.Location = new System.Drawing.Point(309, 224);
            this.lblMotivationHints.Name = "lblMotivationHints";
            this.lblMotivationHints.Size = new System.Drawing.Size(236, 23);
            this.lblMotivationHints.TabIndex = 0;
            this.lblMotivationHints.Text = "Мотивационные подсказки";
            // 
            // lblSleepTime
            // 
            this.lblSleepTime.AutoSize = true;
            this.lblSleepTime.Font = new System.Drawing.Font("Candara", 14.25F);
            this.lblSleepTime.ForeColor = System.Drawing.Color.White;
            this.lblSleepTime.Location = new System.Drawing.Point(12, 27);
            this.lblSleepTime.Name = "lblSleepTime";
            this.lblSleepTime.Size = new System.Drawing.Size(105, 23);
            this.lblSleepTime.TabIndex = 1;
            this.lblSleepTime.Text = "Режим сна:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "С";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(194, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "По";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(309, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Принудительно завершать игры";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(309, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Часов до принудительного завершения игры";
            // 
            // TBHrsToStopGms
            // 
            this.TBHrsToStopGms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.TBHrsToStopGms.Font = new System.Drawing.Font("Candara", 14.25F);
            this.TBHrsToStopGms.ForeColor = System.Drawing.Color.White;
            this.TBHrsToStopGms.Location = new System.Drawing.Point(697, 365);
            this.TBHrsToStopGms.MaxLength = 1;
            this.TBHrsToStopGms.Name = "TBHrsToStopGms";
            this.TBHrsToStopGms.Size = new System.Drawing.Size(18, 31);
            this.TBHrsToStopGms.TabIndex = 13;
            this.TBHrsToStopGms.Text = "2";
            this.TBHrsToStopGms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBHrsToStopGms.Leave += new System.EventHandler(this.CheckTextBoxForEmptiness);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(12, 295);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(270, 103);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "Вернуться";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDefault
            // 
            this.BtnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDefault.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnDefault.ForeColor = System.Drawing.Color.White;
            this.BtnDefault.Location = new System.Drawing.Point(12, 182);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(270, 101);
            this.BtnDefault.TabIndex = 20;
            this.BtnDefault.Text = "Сброс программы";
            this.BtnDefault.UseVisualStyleBackColor = false;
            this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(309, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Напоминать о работе через часов отдыха";
            // 
            // TBHrsToRest
            // 
            this.TBHrsToRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.TBHrsToRest.Font = new System.Drawing.Font("Candara", 14.25F);
            this.TBHrsToRest.ForeColor = System.Drawing.Color.White;
            this.TBHrsToRest.Location = new System.Drawing.Point(697, 23);
            this.TBHrsToRest.MaxLength = 1;
            this.TBHrsToRest.Name = "TBHrsToRest";
            this.TBHrsToRest.Size = new System.Drawing.Size(18, 31);
            this.TBHrsToRest.TabIndex = 22;
            this.TBHrsToRest.Text = "1";
            this.TBHrsToRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBHrsToRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberLine);
            this.TBHrsToRest.Leave += new System.EventHandler(this.CheckTextBoxForEmptiness);
            // 
            // TBHrsToWork
            // 
            this.TBHrsToWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.TBHrsToWork.Font = new System.Drawing.Font("Candara", 14.25F);
            this.TBHrsToWork.ForeColor = System.Drawing.Color.White;
            this.TBHrsToWork.Location = new System.Drawing.Point(697, 67);
            this.TBHrsToWork.MaxLength = 1;
            this.TBHrsToWork.Name = "TBHrsToWork";
            this.TBHrsToWork.Size = new System.Drawing.Size(18, 31);
            this.TBHrsToWork.TabIndex = 25;
            this.TBHrsToWork.Text = "4";
            this.TBHrsToWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBHrsToWork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberLine);
            this.TBHrsToWork.Leave += new System.EventHandler(this.CheckTextBoxForEmptiness);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(309, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(372, 23);
            this.label15.TabIndex = 24;
            this.label15.Text = "Напоминать об отдыхе через часов работы";
            // 
            // TBGetStatsHrs
            // 
            this.TBGetStatsHrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.TBGetStatsHrs.Font = new System.Drawing.Font("Candara", 14.25F);
            this.TBGetStatsHrs.ForeColor = System.Drawing.Color.White;
            this.TBGetStatsHrs.Location = new System.Drawing.Point(697, 111);
            this.TBGetStatsHrs.MaxLength = 1;
            this.TBGetStatsHrs.Name = "TBGetStatsHrs";
            this.TBGetStatsHrs.Size = new System.Drawing.Size(18, 31);
            this.TBGetStatsHrs.TabIndex = 28;
            this.TBGetStatsHrs.Text = "2";
            this.TBGetStatsHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBGetStatsHrs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberLine);
            this.TBGetStatsHrs.Leave += new System.EventHandler(this.CheckTextBoxForEmptiness);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(309, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(307, 23);
            this.label17.TabIndex = 27;
            this.label17.Text = "Количество часов сбора статистики";
            // 
            // TBFunHrsPerWeek
            // 
            this.TBFunHrsPerWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.TBFunHrsPerWeek.Font = new System.Drawing.Font("Candara", 14.25F);
            this.TBFunHrsPerWeek.ForeColor = System.Drawing.Color.White;
            this.TBFunHrsPerWeek.Location = new System.Drawing.Point(691, 159);
            this.TBFunHrsPerWeek.MaxLength = 2;
            this.TBFunHrsPerWeek.Name = "TBFunHrsPerWeek";
            this.TBFunHrsPerWeek.Size = new System.Drawing.Size(24, 31);
            this.TBFunHrsPerWeek.TabIndex = 31;
            this.TBFunHrsPerWeek.Text = "14";
            this.TBFunHrsPerWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBFunHrsPerWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberLine);
            this.TBFunHrsPerWeek.Leave += new System.EventHandler(this.CheckTextBoxForEmptiness);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(309, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(330, 23);
            this.label19.TabIndex = 30;
            this.label19.Text = "Нужно часов в неделю на развлечения";
            // 
            // CBGamesList
            // 
            this.CBGamesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.CBGamesList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBGamesList.Font = new System.Drawing.Font("Candara", 14.25F);
            this.CBGamesList.ForeColor = System.Drawing.Color.White;
            this.CBGamesList.FormattingEnabled = true;
            this.CBGamesList.Location = new System.Drawing.Point(421, 322);
            this.CBGamesList.Name = "CBGamesList";
            this.CBGamesList.Size = new System.Drawing.Size(226, 31);
            this.CBGamesList.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Список игр:";
            // 
            // BtnAddGame
            // 
            this.BtnAddGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddGame.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.BtnAddGame.ForeColor = System.Drawing.Color.White;
            this.BtnAddGame.Location = new System.Drawing.Point(653, 323);
            this.BtnAddGame.Name = "BtnAddGame";
            this.BtnAddGame.Size = new System.Drawing.Size(31, 31);
            this.BtnAddGame.TabIndex = 36;
            this.BtnAddGame.Text = "+";
            this.BtnAddGame.UseVisualStyleBackColor = false;
            this.BtnAddGame.Click += new System.EventHandler(this.BtnAddGame_Click);
            // 
            // BtnRemoveGame
            // 
            this.BtnRemoveGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnRemoveGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRemoveGame.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveGame.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveGame.Location = new System.Drawing.Point(684, 323);
            this.BtnRemoveGame.Name = "BtnRemoveGame";
            this.BtnRemoveGame.Size = new System.Drawing.Size(31, 31);
            this.BtnRemoveGame.TabIndex = 37;
            this.BtnRemoveGame.Text = "-";
            this.BtnRemoveGame.UseVisualStyleBackColor = false;
            this.BtnRemoveGame.Click += new System.EventHandler(this.BtnRemoveGame_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAccept.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.Location = new System.Drawing.Point(12, 69);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(270, 103);
            this.BtnAccept.TabIndex = 38;
            this.BtnAccept.Text = "Применить";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // MTBSleepBegin
            // 
            this.MTBSleepBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.MTBSleepBegin.Font = new System.Drawing.Font("Candara", 14.25F);
            this.MTBSleepBegin.ForeColor = System.Drawing.Color.White;
            this.MTBSleepBegin.Location = new System.Drawing.Point(142, 24);
            this.MTBSleepBegin.Mask = "00:00";
            this.MTBSleepBegin.Name = "MTBSleepBegin";
            this.MTBSleepBegin.Size = new System.Drawing.Size(51, 31);
            this.MTBSleepBegin.TabIndex = 41;
            this.MTBSleepBegin.Text = "0000";
            this.MTBSleepBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTBSleepBegin.ValidatingType = typeof(System.DateTime);
            this.MTBSleepBegin.Leave += new System.EventHandler(this.CheckFormat);
            // 
            // MTBSleepEnd
            // 
            this.MTBSleepEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.MTBSleepEnd.Font = new System.Drawing.Font("Candara", 14.25F);
            this.MTBSleepEnd.ForeColor = System.Drawing.Color.White;
            this.MTBSleepEnd.Location = new System.Drawing.Point(226, 24);
            this.MTBSleepEnd.Mask = "00:00";
            this.MTBSleepEnd.Name = "MTBSleepEnd";
            this.MTBSleepEnd.Size = new System.Drawing.Size(56, 31);
            this.MTBSleepEnd.TabIndex = 42;
            this.MTBSleepEnd.Text = "0700";
            this.MTBSleepEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTBSleepEnd.ValidatingType = typeof(System.DateTime);
            this.MTBSleepEnd.Leave += new System.EventHandler(this.CheckFormat);
            // 
            // ChBMotivHints
            // 
            this.ChBMotivHints.Location = new System.Drawing.Point(685, 219);
            this.ChBMotivHints.Name = "ChBMotivHints";
            this.ChBMotivHints.Size = new System.Drawing.Size(30, 30);
            this.ChBMotivHints.TabIndex = 43;
            this.ChBMotivHints.Text = "biggerCheckBox1";
            this.ChBMotivHints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBMotivHints.UseVisualStyleBackColor = true;
            // 
            // ChBCloseGames
            // 
            this.ChBCloseGames.Location = new System.Drawing.Point(685, 281);
            this.ChBCloseGames.Name = "ChBCloseGames";
            this.ChBCloseGames.Size = new System.Drawing.Size(30, 30);
            this.ChBCloseGames.TabIndex = 44;
            this.ChBCloseGames.Text = "biggerCheckBox1";
            this.ChBCloseGames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBCloseGames.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(745, 414);
            this.Controls.Add(this.ChBCloseGames);
            this.Controls.Add(this.ChBMotivHints);
            this.Controls.Add(this.MTBSleepEnd);
            this.Controls.Add(this.MTBSleepBegin);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnRemoveGame);
            this.Controls.Add(this.BtnAddGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBGamesList);
            this.Controls.Add(this.TBFunHrsPerWeek);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TBGetStatsHrs);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TBHrsToWork);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TBHrsToRest);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TBHrsToStopGms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSleepTime);
            this.Controls.Add(this.lblMotivationHints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBHrsToStopGms;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnDefault;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBHrsToRest;
        private System.Windows.Forms.TextBox TBHrsToWork;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBGetStatsHrs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TBFunHrsPerWeek;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox CBGamesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddGame;
        private System.Windows.Forms.Button BtnRemoveGame;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.MaskedTextBox MTBSleepBegin;
        private System.Windows.Forms.MaskedTextBox MTBSleepEnd;
        private BiggerCheckBox ChBMotivHints;
        private BiggerCheckBox ChBCloseGames;
    }
}