namespace FW_Launcher_Beta_v1._0._1._0
{
    partial class FParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FParams));
            this.btnDelGamePath = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnModGamePath = new System.Windows.Forms.Button();
            this.btnAddGamePath = new System.Windows.Forms.Button();
            this.lblGamePath = new System.Windows.Forms.Label();
            this.tbGamePath = new System.Windows.Forms.TextBox();
            this.btnBackFromSet = new System.Windows.Forms.Button();
            this.btnSavePause = new System.Windows.Forms.Button();
            this.lblClosePause = new System.Windows.Forms.Label();
            this.lblLoginPause = new System.Windows.Forms.Label();
            this.lblStartPause = new System.Windows.Forms.Label();
            this.tbClosePause = new System.Windows.Forms.TextBox();
            this.tbLoginPause = new System.Windows.Forms.TextBox();
            this.tbStartPause = new System.Windows.Forms.TextBox();
            this.btnDelAllParam = new System.Windows.Forms.Button();
            this.btnDefPauses = new System.Windows.Forms.Button();
            this.cbSaveCheckedAccs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDelGamePath
            // 
            this.btnDelGamePath.Location = new System.Drawing.Point(212, 157);
            this.btnDelGamePath.Name = "btnDelGamePath";
            this.btnDelGamePath.Size = new System.Drawing.Size(93, 32);
            this.btnDelGamePath.TabIndex = 34;
            this.btnDelGamePath.Text = "Удалить путь";
            this.btnDelGamePath.UseVisualStyleBackColor = true;
            this.btnDelGamePath.Click += new System.EventHandler(this.btnDelPath_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(310, 157);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(93, 32);
            this.btnHelp.TabIndex = 33;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnModGamePath
            // 
            this.btnModGamePath.Location = new System.Drawing.Point(113, 157);
            this.btnModGamePath.Name = "btnModGamePath";
            this.btnModGamePath.Size = new System.Drawing.Size(93, 32);
            this.btnModGamePath.TabIndex = 32;
            this.btnModGamePath.Text = "Изменить путь";
            this.btnModGamePath.UseVisualStyleBackColor = true;
            this.btnModGamePath.Click += new System.EventHandler(this.btnModPath_Click);
            // 
            // btnAddGamePath
            // 
            this.btnAddGamePath.Location = new System.Drawing.Point(12, 157);
            this.btnAddGamePath.Name = "btnAddGamePath";
            this.btnAddGamePath.Size = new System.Drawing.Size(95, 32);
            this.btnAddGamePath.TabIndex = 31;
            this.btnAddGamePath.Text = "Добавить путь";
            this.btnAddGamePath.UseVisualStyleBackColor = true;
            this.btnAddGamePath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // lblGamePath
            // 
            this.lblGamePath.AutoSize = true;
            this.lblGamePath.Location = new System.Drawing.Point(11, 105);
            this.lblGamePath.Name = "lblGamePath";
            this.lblGamePath.Size = new System.Drawing.Size(80, 13);
            this.lblGamePath.TabIndex = 30;
            this.lblGamePath.Text = "Путь до игры: ";
            // 
            // tbGamePath
            // 
            this.tbGamePath.Location = new System.Drawing.Point(12, 131);
            this.tbGamePath.Name = "tbGamePath";
            this.tbGamePath.Size = new System.Drawing.Size(391, 20);
            this.tbGamePath.TabIndex = 29;
            this.tbGamePath.Text = "C:\\Program Files (x86)\\Forsaken World_en\\patcher.exe";
            // 
            // btnBackFromSet
            // 
            this.btnBackFromSet.Location = new System.Drawing.Point(409, 157);
            this.btnBackFromSet.Name = "btnBackFromSet";
            this.btnBackFromSet.Size = new System.Drawing.Size(72, 32);
            this.btnBackFromSet.TabIndex = 28;
            this.btnBackFromSet.Text = "Вернуться";
            this.btnBackFromSet.UseVisualStyleBackColor = true;
            this.btnBackFromSet.Click += new System.EventHandler(this.btnBackFromSet_Click);
            // 
            // btnSavePause
            // 
            this.btnSavePause.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSavePause.Location = new System.Drawing.Point(409, 12);
            this.btnSavePause.Name = "btnSavePause";
            this.btnSavePause.Size = new System.Drawing.Size(72, 35);
            this.btnSavePause.TabIndex = 27;
            this.btnSavePause.Text = "Сохранить паузы";
            this.btnSavePause.UseVisualStyleBackColor = true;
            this.btnSavePause.Click += new System.EventHandler(this.btnSavePause_Click);
            // 
            // lblClosePause
            // 
            this.lblClosePause.AutoSize = true;
            this.lblClosePause.Location = new System.Drawing.Point(118, 67);
            this.lblClosePause.Name = "lblClosePause";
            this.lblClosePause.Size = new System.Drawing.Size(285, 13);
            this.lblClosePause.TabIndex = 26;
            this.lblClosePause.Text = "Пауза перед закрытием процесса Arc.exe (в секундах)";
            // 
            // lblLoginPause
            // 
            this.lblLoginPause.AutoSize = true;
            this.lblLoginPause.Location = new System.Drawing.Point(118, 41);
            this.lblLoginPause.Name = "lblLoginPause";
            this.lblLoginPause.Size = new System.Drawing.Size(269, 13);
            this.lblLoginPause.TabIndex = 25;
            this.lblLoginPause.Text = "Интервал между вводом данных (в миллисекундах)";
            // 
            // lblStartPause
            // 
            this.lblStartPause.AutoSize = true;
            this.lblStartPause.Location = new System.Drawing.Point(118, 15);
            this.lblStartPause.Name = "lblStartPause";
            this.lblStartPause.Size = new System.Drawing.Size(216, 13);
            this.lblStartPause.TabIndex = 24;
            this.lblStartPause.Text = "Пауза перед вводом данных (в секундах)";
            // 
            // tbClosePause
            // 
            this.tbClosePause.Location = new System.Drawing.Point(12, 64);
            this.tbClosePause.Name = "tbClosePause";
            this.tbClosePause.Size = new System.Drawing.Size(100, 20);
            this.tbClosePause.TabIndex = 23;
            this.tbClosePause.Text = "20";
            this.tbClosePause.TextChanged += new System.EventHandler(this.tbStartPause_TextChanged);
            this.tbClosePause.Leave += new System.EventHandler(this.tbStartPause_Leave);
            // 
            // tbLoginPause
            // 
            this.tbLoginPause.Location = new System.Drawing.Point(12, 38);
            this.tbLoginPause.Name = "tbLoginPause";
            this.tbLoginPause.Size = new System.Drawing.Size(100, 20);
            this.tbLoginPause.TabIndex = 22;
            this.tbLoginPause.Text = "1000";
            this.tbLoginPause.TextChanged += new System.EventHandler(this.tbStartPause_TextChanged);
            this.tbLoginPause.Leave += new System.EventHandler(this.tbStartPause_Leave);
            // 
            // tbStartPause
            // 
            this.tbStartPause.Location = new System.Drawing.Point(12, 12);
            this.tbStartPause.Name = "tbStartPause";
            this.tbStartPause.Size = new System.Drawing.Size(100, 20);
            this.tbStartPause.TabIndex = 21;
            this.tbStartPause.Text = "10";
            this.tbStartPause.TextChanged += new System.EventHandler(this.tbStartPause_TextChanged);
            this.tbStartPause.Leave += new System.EventHandler(this.tbStartPause_Leave);
            // 
            // btnDelAllParam
            // 
            this.btnDelAllParam.Location = new System.Drawing.Point(409, 105);
            this.btnDelAllParam.Name = "btnDelAllParam";
            this.btnDelAllParam.Size = new System.Drawing.Size(72, 46);
            this.btnDelAllParam.TabIndex = 37;
            this.btnDelAllParam.TabStop = false;
            this.btnDelAllParam.Text = "Удалить ВСЁ";
            this.btnDelAllParam.UseVisualStyleBackColor = true;
            this.btnDelAllParam.Click += new System.EventHandler(this.btnDelAllParam_Click);
            // 
            // btnDefPauses
            // 
            this.btnDefPauses.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDefPauses.Location = new System.Drawing.Point(409, 52);
            this.btnDefPauses.Name = "btnDefPauses";
            this.btnDefPauses.Size = new System.Drawing.Size(71, 47);
            this.btnDefPauses.TabIndex = 38;
            this.btnDefPauses.Text = "По умолчанию";
            this.btnDefPauses.UseVisualStyleBackColor = true;
            this.btnDefPauses.Click += new System.EventHandler(this.btnDefPauses_Click);
            // 
            // cbSaveCheckedAccs
            // 
            this.cbSaveCheckedAccs.AutoSize = true;
            this.cbSaveCheckedAccs.Location = new System.Drawing.Point(14, 195);
            this.cbSaveCheckedAccs.Name = "cbSaveCheckedAccs";
            this.cbSaveCheckedAccs.Size = new System.Drawing.Size(350, 17);
            this.cbSaveCheckedAccs.TabIndex = 39;
            this.cbSaveCheckedAccs.Text = "Сохранять выбранные аккаунты для следующих запусков игры";
            this.cbSaveCheckedAccs.UseVisualStyleBackColor = true;
            this.cbSaveCheckedAccs.CheckedChanged += new System.EventHandler(this.cbSaveCheckedAccs_CheckedChanged);
            // 
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 217);
            this.ControlBox = false;
            this.Controls.Add(this.cbSaveCheckedAccs);
            this.Controls.Add(this.btnDefPauses);
            this.Controls.Add(this.btnDelAllParam);
            this.Controls.Add(this.btnDelGamePath);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnModGamePath);
            this.Controls.Add(this.btnAddGamePath);
            this.Controls.Add(this.lblGamePath);
            this.Controls.Add(this.tbGamePath);
            this.Controls.Add(this.btnBackFromSet);
            this.Controls.Add(this.btnSavePause);
            this.Controls.Add(this.lblClosePause);
            this.Controls.Add(this.lblLoginPause);
            this.Controls.Add(this.lblStartPause);
            this.Controls.Add(this.tbClosePause);
            this.Controls.Add(this.tbLoginPause);
            this.Controls.Add(this.tbStartPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParams_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fParams_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelGamePath;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnModGamePath;
        private System.Windows.Forms.Button btnAddGamePath;
        private System.Windows.Forms.Button btnBackFromSet;
        private System.Windows.Forms.Button btnSavePause;
        private System.Windows.Forms.Label lblClosePause;
        private System.Windows.Forms.Label lblLoginPause;
        private System.Windows.Forms.Label lblStartPause;
        public System.Windows.Forms.TextBox tbClosePause;
        public System.Windows.Forms.TextBox tbLoginPause;
        public System.Windows.Forms.TextBox tbStartPause;
        private System.Windows.Forms.Button btnDelAllParam;
        private System.Windows.Forms.Button btnDefPauses;
        public System.Windows.Forms.Label lblGamePath;
        public System.Windows.Forms.TextBox tbGamePath;
        private System.Windows.Forms.CheckBox cbSaveCheckedAccs;
    }
}