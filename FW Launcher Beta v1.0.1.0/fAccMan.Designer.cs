namespace FW_Launcher_Beta_v1._0._1._0
{
    partial class FAccMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAccMan));
            this.btnAccManHelp = new System.Windows.Forms.Button();
            this.btnAccManDelAll = new System.Windows.Forms.Button();
            this.btnAccMod = new System.Windows.Forms.Button();
            this.btnAccDel = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.tbAccPass = new System.Windows.Forms.TextBox();
            this.tbAccLogin = new System.Windows.Forms.TextBox();
            this.tbAccName = new System.Windows.Forms.TextBox();
            this.btnAccAdd = new System.Windows.Forms.Button();
            this.lbAccList = new System.Windows.Forms.ListBox();
            this.btnBackFromAccMan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccManHelp
            // 
            this.btnAccManHelp.Location = new System.Drawing.Point(432, 165);
            this.btnAccManHelp.Name = "btnAccManHelp";
            this.btnAccManHelp.Size = new System.Drawing.Size(72, 59);
            this.btnAccManHelp.TabIndex = 9;
            this.btnAccManHelp.Text = "Справка";
            this.btnAccManHelp.UseVisualStyleBackColor = true;
            this.btnAccManHelp.Click += new System.EventHandler(this.btnAccManHelp_Click);
            // 
            // btnAccManDelAll
            // 
            this.btnAccManDelAll.Location = new System.Drawing.Point(432, 90);
            this.btnAccManDelAll.Name = "btnAccManDelAll";
            this.btnAccManDelAll.Size = new System.Drawing.Size(72, 59);
            this.btnAccManDelAll.TabIndex = 10;
            this.btnAccManDelAll.Text = "Удалить ВСЕ аккаунты";
            this.btnAccManDelAll.UseVisualStyleBackColor = true;
            this.btnAccManDelAll.Click += new System.EventHandler(this.btnAccManDelAll_Click);
            // 
            // btnAccMod
            // 
            this.btnAccMod.Location = new System.Drawing.Point(284, 165);
            this.btnAccMod.Name = "btnAccMod";
            this.btnAccMod.Size = new System.Drawing.Size(68, 59);
            this.btnAccMod.TabIndex = 5;
            this.btnAccMod.Text = "Изменить данные";
            this.btnAccMod.UseVisualStyleBackColor = true;
            this.btnAccMod.Click += new System.EventHandler(this.btnAccMod_Click);
            // 
            // btnAccDel
            // 
            this.btnAccDel.Location = new System.Drawing.Point(358, 90);
            this.btnAccDel.Name = "btnAccDel";
            this.btnAccDel.Size = new System.Drawing.Size(68, 59);
            this.btnAccDel.TabIndex = 7;
            this.btnAccDel.Text = "Удалить данные";
            this.btnAccDel.UseVisualStyleBackColor = true;
            this.btnAccDel.Click += new System.EventHandler(this.btnAccDel_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackgroundImage = global::FW_Launcher_Beta_v1._0._1._0.Properties.Resources.showPass;
            this.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPass.Location = new System.Drawing.Point(477, 63);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(27, 20);
            this.btnShowPass.TabIndex = 17;
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // tbAccPass
            // 
            this.tbAccPass.Location = new System.Drawing.Point(284, 64);
            this.tbAccPass.Name = "tbAccPass";
            this.tbAccPass.Size = new System.Drawing.Size(187, 20);
            this.tbAccPass.TabIndex = 3;
            this.tbAccPass.Text = "Пароль";
            this.tbAccPass.Click += new System.EventHandler(this.tbAccName_Click);
            this.tbAccPass.TextChanged += new System.EventHandler(this.tbAccName_TextChanged);
            this.tbAccPass.DoubleClick += new System.EventHandler(this.tbAccName_DoubleClick);
            // 
            // tbAccLogin
            // 
            this.tbAccLogin.Location = new System.Drawing.Point(283, 38);
            this.tbAccLogin.Name = "tbAccLogin";
            this.tbAccLogin.Size = new System.Drawing.Size(221, 20);
            this.tbAccLogin.TabIndex = 2;
            this.tbAccLogin.Text = "Логин (почта)";
            this.tbAccLogin.Click += new System.EventHandler(this.tbAccName_Click);
            this.tbAccLogin.TextChanged += new System.EventHandler(this.tbAccName_TextChanged);
            this.tbAccLogin.DoubleClick += new System.EventHandler(this.tbAccName_DoubleClick);
            // 
            // tbAccName
            // 
            this.tbAccName.Location = new System.Drawing.Point(284, 12);
            this.tbAccName.Name = "tbAccName";
            this.tbAccName.Size = new System.Drawing.Size(220, 20);
            this.tbAccName.TabIndex = 1;
            this.tbAccName.Text = "Имя аккаунта";
            this.tbAccName.Click += new System.EventHandler(this.tbAccName_Click);
            this.tbAccName.TextChanged += new System.EventHandler(this.tbAccName_TextChanged);
            this.tbAccName.DoubleClick += new System.EventHandler(this.tbAccName_DoubleClick);
            // 
            // btnAccAdd
            // 
            this.btnAccAdd.Location = new System.Drawing.Point(284, 90);
            this.btnAccAdd.Name = "btnAccAdd";
            this.btnAccAdd.Size = new System.Drawing.Size(68, 59);
            this.btnAccAdd.TabIndex = 4;
            this.btnAccAdd.Text = "Добавить данные";
            this.btnAccAdd.UseVisualStyleBackColor = true;
            this.btnAccAdd.Click += new System.EventHandler(this.btnAccAdd_Click);
            // 
            // lbAccList
            // 
            this.lbAccList.FormattingEnabled = true;
            this.lbAccList.Location = new System.Drawing.Point(12, 12);
            this.lbAccList.Name = "lbAccList";
            this.lbAccList.Size = new System.Drawing.Size(265, 212);
            this.lbAccList.TabIndex = 12;
            this.lbAccList.SelectedIndexChanged += new System.EventHandler(this.lbAccList_SelectedIndexChanged);
            this.lbAccList.DoubleClick += new System.EventHandler(this.lbAccList_DoubleClick);
            // 
            // btnBackFromAccMan
            // 
            this.btnBackFromAccMan.Location = new System.Drawing.Point(358, 165);
            this.btnBackFromAccMan.Name = "btnBackFromAccMan";
            this.btnBackFromAccMan.Size = new System.Drawing.Size(68, 59);
            this.btnBackFromAccMan.TabIndex = 8;
            this.btnBackFromAccMan.Text = "Вернуться";
            this.btnBackFromAccMan.UseVisualStyleBackColor = true;
            this.btnBackFromAccMan.Click += new System.EventHandler(this.btnBackFromAccMan_Click);
            // 
            // fAccMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 236);
            this.ControlBox = false;
            this.Controls.Add(this.btnAccManHelp);
            this.Controls.Add(this.btnAccManDelAll);
            this.Controls.Add(this.btnAccMod);
            this.Controls.Add(this.btnAccDel);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.tbAccPass);
            this.Controls.Add(this.tbAccLogin);
            this.Controls.Add(this.tbAccName);
            this.Controls.Add(this.btnAccAdd);
            this.Controls.Add(this.lbAccList);
            this.Controls.Add(this.btnBackFromAccMan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FAccMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер аккаунтов";
            this.Load += new System.EventHandler(this.fAccMan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAccList_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccManHelp;
        private System.Windows.Forms.Button btnAccManDelAll;
        private System.Windows.Forms.Button btnAccMod;
        private System.Windows.Forms.Button btnAccDel;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.TextBox tbAccPass;
        private System.Windows.Forms.TextBox tbAccLogin;
        private System.Windows.Forms.TextBox tbAccName;
        private System.Windows.Forms.Button btnAccAdd;
        public System.Windows.Forms.ListBox lbAccList;
        private System.Windows.Forms.Button btnBackFromAccMan;
    }
}