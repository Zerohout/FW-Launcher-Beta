namespace FW_Launcher_Beta_v1._0._1._0
{
    partial class AccManHelp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccManHelp));
            this.tcAccManHelp = new System.Windows.Forms.TabControl();
            this.tpHelpAddAcc = new System.Windows.Forms.TabPage();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.btnHelpAddAccShowPass = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btnHelpAddAcc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHelpAddAccPass = new System.Windows.Forms.TextBox();
            this.tbHelpAddAccLogin = new System.Windows.Forms.TextBox();
            this.tbHelpAddAccName = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tpHelpModAcc = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnHelpModAcc = new System.Windows.Forms.Button();
            this.btnHelpModAccShowPass = new System.Windows.Forms.Button();
            this.tbHelpModAccPass = new System.Windows.Forms.TextBox();
            this.tbHelpModAccLogin = new System.Windows.Forms.TextBox();
            this.tbHelpModAccName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbHelpModAccList = new System.Windows.Forms.ListBox();
            this.tpHelpDelAcc = new System.Windows.Forms.TabPage();
            this.btnReturnFromAccManHelp = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbHelpDelAccList = new System.Windows.Forms.ListBox();
            this.btnHelpDelAcc = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnHelpDelAllAcc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNextTabHelpAcc = new System.Windows.Forms.Button();
            this.btnPrevTabHelpAcc = new System.Windows.Forms.Button();
            this.tcAccManHelp.SuspendLayout();
            this.tpHelpAddAcc.SuspendLayout();
            this.tpHelpModAcc.SuspendLayout();
            this.tpHelpDelAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAccManHelp
            // 
            this.tcAccManHelp.Controls.Add(this.tpHelpAddAcc);
            this.tcAccManHelp.Controls.Add(this.tpHelpModAcc);
            this.tcAccManHelp.Controls.Add(this.tpHelpDelAcc);
            resources.ApplyResources(this.tcAccManHelp, "tcAccManHelp");
            this.tcAccManHelp.Multiline = true;
            this.tcAccManHelp.Name = "tcAccManHelp";
            this.tcAccManHelp.SelectedIndex = 0;
            this.tcAccManHelp.SelectedIndexChanged += new System.EventHandler(this.tcAccManHelp_SelectedIndexChanged);
            this.tcAccManHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHelpAccPass_KeyDown);
            // 
            // tpHelpAddAcc
            // 
            this.tpHelpAddAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpHelpAddAcc.Controls.Add(this.tb3);
            this.tpHelpAddAcc.Controls.Add(this.btnHelpAddAccShowPass);
            this.tpHelpAddAcc.Controls.Add(this.tb2);
            this.tpHelpAddAcc.Controls.Add(this.btnHelpAddAcc);
            this.tpHelpAddAcc.Controls.Add(this.label3);
            this.tpHelpAddAcc.Controls.Add(this.label2);
            this.tpHelpAddAcc.Controls.Add(this.label1);
            this.tpHelpAddAcc.Controls.Add(this.tbHelpAddAccPass);
            this.tpHelpAddAcc.Controls.Add(this.tbHelpAddAccLogin);
            this.tpHelpAddAcc.Controls.Add(this.tbHelpAddAccName);
            this.tpHelpAddAcc.Controls.Add(this.tb1);
            resources.ApplyResources(this.tpHelpAddAcc, "tpHelpAddAcc");
            this.tpHelpAddAcc.Name = "tpHelpAddAcc";
            this.tpHelpAddAcc.UseVisualStyleBackColor = true;
            // 
            // tb3
            // 
            resources.ApplyResources(this.tb3, "tb3");
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.TabStop = false;
            // 
            // btnHelpAddAccShowPass
            // 
            this.btnHelpAddAccShowPass.BackgroundImage = global::FW_Launcher_Beta_v1._0._1._0.Properties.Resources.showPass;
            resources.ApplyResources(this.btnHelpAddAccShowPass, "btnHelpAddAccShowPass");
            this.btnHelpAddAccShowPass.Name = "btnHelpAddAccShowPass";
            this.btnHelpAddAccShowPass.UseVisualStyleBackColor = true;
            this.btnHelpAddAccShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnHelpAddAccShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // tb2
            // 
            resources.ApplyResources(this.tb2, "tb2");
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.TabStop = false;
            // 
            // btnHelpAddAcc
            // 
            resources.ApplyResources(this.btnHelpAddAcc, "btnHelpAddAcc");
            this.btnHelpAddAcc.Name = "btnHelpAddAcc";
            this.btnHelpAddAcc.UseVisualStyleBackColor = true;
            this.btnHelpAddAcc.Click += new System.EventHandler(this.btnHelpAccAdd_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbHelpAddAccPass
            // 
            resources.ApplyResources(this.tbHelpAddAccPass, "tbHelpAddAccPass");
            this.tbHelpAddAccPass.Name = "tbHelpAddAccPass";
            this.tbHelpAddAccPass.TextChanged += new System.EventHandler(this.TextBox_TextChange);
            this.tbHelpAddAccPass.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // tbHelpAddAccLogin
            // 
            resources.ApplyResources(this.tbHelpAddAccLogin, "tbHelpAddAccLogin");
            this.tbHelpAddAccLogin.Name = "tbHelpAddAccLogin";
            this.tbHelpAddAccLogin.TextChanged += new System.EventHandler(this.TextBox_TextChange);
            this.tbHelpAddAccLogin.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // tbHelpAddAccName
            // 
            resources.ApplyResources(this.tbHelpAddAccName, "tbHelpAddAccName");
            this.tbHelpAddAccName.Name = "tbHelpAddAccName";
            this.tbHelpAddAccName.TextChanged += new System.EventHandler(this.TextBox_TextChange);
            this.tbHelpAddAccName.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // tb1
            // 
            resources.ApplyResources(this.tb1, "tb1");
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.TabStop = false;
            // 
            // tpHelpModAcc
            // 
            this.tpHelpModAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpHelpModAcc.Controls.Add(this.textBox2);
            this.tpHelpModAcc.Controls.Add(this.textBox5);
            this.tpHelpModAcc.Controls.Add(this.btnHelpModAcc);
            this.tpHelpModAcc.Controls.Add(this.btnHelpModAccShowPass);
            this.tpHelpModAcc.Controls.Add(this.tbHelpModAccPass);
            this.tpHelpModAcc.Controls.Add(this.tbHelpModAccLogin);
            this.tpHelpModAcc.Controls.Add(this.tbHelpModAccName);
            this.tpHelpModAcc.Controls.Add(this.textBox1);
            this.tpHelpModAcc.Controls.Add(this.lbHelpModAccList);
            resources.ApplyResources(this.tpHelpModAcc, "tpHelpModAcc");
            this.tpHelpModAcc.Name = "tpHelpModAcc";
            this.tpHelpModAcc.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.TabStop = false;
            // 
            // btnHelpModAcc
            // 
            resources.ApplyResources(this.btnHelpModAcc, "btnHelpModAcc");
            this.btnHelpModAcc.Name = "btnHelpModAcc";
            this.btnHelpModAcc.UseVisualStyleBackColor = true;
            this.btnHelpModAcc.Click += new System.EventHandler(this.btnHelpModAcc_Click);
            // 
            // btnHelpModAccShowPass
            // 
            this.btnHelpModAccShowPass.BackgroundImage = global::FW_Launcher_Beta_v1._0._1._0.Properties.Resources.showPass;
            resources.ApplyResources(this.btnHelpModAccShowPass, "btnHelpModAccShowPass");
            this.btnHelpModAccShowPass.Name = "btnHelpModAccShowPass";
            this.btnHelpModAccShowPass.UseVisualStyleBackColor = true;
            this.btnHelpModAccShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnHelpModAccShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // tbHelpModAccPass
            // 
            resources.ApplyResources(this.tbHelpModAccPass, "tbHelpModAccPass");
            this.tbHelpModAccPass.Name = "tbHelpModAccPass";
            this.tbHelpModAccPass.TextChanged += new System.EventHandler(this.TextBox_TextChange);
            this.tbHelpModAccPass.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // tbHelpModAccLogin
            // 
            resources.ApplyResources(this.tbHelpModAccLogin, "tbHelpModAccLogin");
            this.tbHelpModAccLogin.Name = "tbHelpModAccLogin";
            this.tbHelpModAccLogin.TextChanged += new System.EventHandler(this.TextBox_TextChange);
            this.tbHelpModAccLogin.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // tbHelpModAccName
            // 
            resources.ApplyResources(this.tbHelpModAccName, "tbHelpModAccName");
            this.tbHelpModAccName.Name = "tbHelpModAccName";
            this.tbHelpModAccName.TextChanged += new System.EventHandler(this.TextBox_TextChange);
            this.tbHelpModAccName.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TabStop = false;
            // 
            // lbHelpModAccList
            // 
            this.lbHelpModAccList.FormattingEnabled = true;
            resources.ApplyResources(this.lbHelpModAccList, "lbHelpModAccList");
            this.lbHelpModAccList.Name = "lbHelpModAccList";
            this.lbHelpModAccList.DoubleClick += new System.EventHandler(this.lbHelpModAccList_DoubleClick);
            // 
            // tpHelpDelAcc
            // 
            this.tpHelpDelAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpHelpDelAcc.Controls.Add(this.btnHelpDelAllAcc);
            this.tpHelpDelAcc.Controls.Add(this.textBox4);
            this.tpHelpDelAcc.Controls.Add(this.textBox3);
            this.tpHelpDelAcc.Controls.Add(this.btnHelpDelAcc);
            this.tpHelpDelAcc.Controls.Add(this.lbHelpDelAccList);
            resources.ApplyResources(this.tpHelpDelAcc, "tpHelpDelAcc");
            this.tpHelpDelAcc.Name = "tpHelpDelAcc";
            this.tpHelpDelAcc.UseVisualStyleBackColor = true;
            // 
            // btnReturnFromAccManHelp
            // 
            resources.ApplyResources(this.btnReturnFromAccManHelp, "btnReturnFromAccManHelp");
            this.btnReturnFromAccManHelp.Name = "btnReturnFromAccManHelp";
            this.btnReturnFromAccManHelp.UseVisualStyleBackColor = true;
            this.btnReturnFromAccManHelp.Click += new System.EventHandler(this.btnReturnFromAccManHelp_Click);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.TabStop = false;
            // 
            // lbHelpDelAccList
            // 
            this.lbHelpDelAccList.FormattingEnabled = true;
            resources.ApplyResources(this.lbHelpDelAccList, "lbHelpDelAccList");
            this.lbHelpDelAccList.Name = "lbHelpDelAccList";
            this.lbHelpDelAccList.SelectedIndexChanged += new System.EventHandler(this.lbHelpDelAccList_SelectedIndexChanged);
            // 
            // btnHelpDelAcc
            // 
            resources.ApplyResources(this.btnHelpDelAcc, "btnHelpDelAcc");
            this.btnHelpDelAcc.Name = "btnHelpDelAcc";
            this.btnHelpDelAcc.UseVisualStyleBackColor = true;
            this.btnHelpDelAcc.Click += new System.EventHandler(this.btnHelpDelAcc_Click);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.TabStop = false;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.TabStop = false;
            // 
            // btnHelpDelAllAcc
            // 
            resources.ApplyResources(this.btnHelpDelAllAcc, "btnHelpDelAllAcc");
            this.btnHelpDelAllAcc.Name = "btnHelpDelAllAcc";
            this.btnHelpDelAllAcc.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNextTabHelpAcc
            // 
            resources.ApplyResources(this.btnNextTabHelpAcc, "btnNextTabHelpAcc");
            this.btnNextTabHelpAcc.Name = "btnNextTabHelpAcc";
            this.btnNextTabHelpAcc.UseVisualStyleBackColor = true;
            this.btnNextTabHelpAcc.Click += new System.EventHandler(this.btnNextTabFromHelpAddAcc_Click);
            // 
            // btnPrevTabHelpAcc
            // 
            resources.ApplyResources(this.btnPrevTabHelpAcc, "btnPrevTabHelpAcc");
            this.btnPrevTabHelpAcc.Name = "btnPrevTabHelpAcc";
            this.btnPrevTabHelpAcc.UseVisualStyleBackColor = true;
            this.btnPrevTabHelpAcc.Click += new System.EventHandler(this.btnPrevTabHelpAcc_Click);
            // 
            // AccManHelp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnNextTabHelpAcc);
            this.Controls.Add(this.btnPrevTabHelpAcc);
            this.Controls.Add(this.btnReturnFromAccManHelp);
            this.Controls.Add(this.tcAccManHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AccManHelp";
            this.Load += new System.EventHandler(this.AccManHelp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHelpAccPass_KeyDown);
            this.tcAccManHelp.ResumeLayout(false);
            this.tpHelpAddAcc.ResumeLayout(false);
            this.tpHelpAddAcc.PerformLayout();
            this.tpHelpModAcc.ResumeLayout(false);
            this.tpHelpModAcc.PerformLayout();
            this.tpHelpDelAcc.ResumeLayout(false);
            this.tpHelpDelAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAccManHelp;
        private System.Windows.Forms.TabPage tpHelpAddAcc;
        private System.Windows.Forms.TabPage tpHelpModAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHelpAddAccPass;
        private System.Windows.Forms.TextBox tbHelpAddAccLogin;
        private System.Windows.Forms.TextBox tbHelpAddAccName;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TabPage tpHelpDelAcc;
        private System.Windows.Forms.Button btnHelpAddAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btnHelpAddAccShowPass;
        private System.Windows.Forms.Button btnReturnFromAccManHelp;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button btnHelpModAcc;
        private System.Windows.Forms.Button btnHelpModAccShowPass;
        private System.Windows.Forms.TextBox tbHelpModAccPass;
        private System.Windows.Forms.TextBox tbHelpModAccLogin;
        private System.Windows.Forms.TextBox tbHelpModAccName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbHelpModAccList;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnHelpDelAcc;
        private System.Windows.Forms.ListBox lbHelpDelAccList;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnHelpDelAllAcc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNextTabHelpAcc;
        private System.Windows.Forms.Button btnPrevTabHelpAcc;
    }
}