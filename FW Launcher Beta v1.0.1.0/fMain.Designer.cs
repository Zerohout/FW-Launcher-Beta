namespace FW_Launcher_Beta_v1._0._1._0
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.clbStartAccList = new System.Windows.Forms.CheckedListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartFW = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnManAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbStartAccList
            // 
            this.clbStartAccList.CheckOnClick = true;
            this.clbStartAccList.FormattingEnabled = true;
            this.clbStartAccList.Location = new System.Drawing.Point(12, 12);
            this.clbStartAccList.Name = "clbStartAccList";
            this.clbStartAccList.Size = new System.Drawing.Size(273, 184);
            this.clbStartAccList.TabIndex = 13;
            this.clbStartAccList.SelectedIndexChanged += new System.EventHandler(this.clbStartAccList_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(464, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 78);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartFW
            // 
            this.btnStartFW.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartFW.Location = new System.Drawing.Point(291, 120);
            this.btnStartFW.Name = "btnStartFW";
            this.btnStartFW.Size = new System.Drawing.Size(167, 78);
            this.btnStartFW.TabIndex = 11;
            this.btnStartFW.Text = "Start FW";
            this.btnStartFW.UseVisualStyleBackColor = true;
            this.btnStartFW.Click += new System.EventHandler(this.btnStartFW_Click);
            // 
            // btnParams
            // 
            this.btnParams.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParams.Location = new System.Drawing.Point(464, 11);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(167, 78);
            this.btnParams.TabIndex = 10;
            this.btnParams.Text = "Настройки";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnManAcc
            // 
            this.btnManAcc.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManAcc.Location = new System.Drawing.Point(291, 12);
            this.btnManAcc.Name = "btnManAcc";
            this.btnManAcc.Size = new System.Drawing.Size(167, 78);
            this.btnManAcc.TabIndex = 9;
            this.btnManAcc.Text = "Менеджер аккаунтов";
            this.btnManAcc.UseVisualStyleBackColor = true;
            this.btnManAcc.Click += new System.EventHandler(this.btnManAcc_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 211);
            this.ControlBox = false;
            this.Controls.Add(this.clbStartAccList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartFW);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnManAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FW Launcher Beta v1.0.1";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox clbStartAccList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartFW;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnManAcc;
    }
}

