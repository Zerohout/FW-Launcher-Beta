using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace FW_Launcher_Beta_v1._0._1._0
{
    public partial class FMain : Form
    {
        private readonly FAccMan _fam;
        private readonly FParams _fp;

        private OpenFileDialog _fd = new OpenFileDialog();


        public FMain()
        {
            _fam = new FAccMan(this);
            _fp = new FParams(this);
            Sepo.CreateAccNames();
            InitializeComponent();
            foreach (var str in Sepo.AccNames)
            {
                clbStartAccList.Items.Add(str);
                _fam.lbAccList.Items.Add(str);
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        //Загрузка формы
        {
            btnStartFW.Enabled = false;
            if (!Sepo.SaveAccChoise) return;
            Sepo.ReadSelAccs();
            if (Sepo.RSelAccs.Count > 0)
            {
                foreach (var str in Sepo.RSelAccs)
                {
                    clbStartAccList.SetItemChecked(clbStartAccList.Items.IndexOf(str), true);
                }

                btnStartFW.Enabled = true;
            }
            else
            {
                btnStartFW.Enabled = false;
            }
        }

        private void clbStartAccList_SelectedIndexChanged(object sender, EventArgs e)
        //Изменение выбора в списке аккаунтов
        {
            btnStartFW.Enabled = clbStartAccList.CheckedItems.Count != 0;
            if (clbStartAccList.CheckedItems.Count > 3)
            {
                clbStartAccList.SetItemChecked(clbStartAccList.SelectedIndex, false);
            }
            clbStartAccList.ClearSelected();

            if (Sepo.SelAccs.Count > 0)
            {
                Sepo.SelAccs.Clear();
            }
            foreach (string str in clbStartAccList.CheckedItems)
            {
                Sepo.SelAccs.Add(str);
            }
            Sepo.CreateSelAccs(Sepo.SelAccs);
        }

        private void btnManAcc_Click(object sender, EventArgs e)
        //Кнопка Менеджер аккаунтов
        {
            Hide();
            _fam.ShowDialog();
        }

        private void btnParams_Click(object sender, EventArgs e)
        //КНопка параметры
        {
            _fp.Show();
            Hide();
        }

        private void btnStartFW_Click(object sender, EventArgs e)
        //Кнопка Start FW
        {
            if (!File.Exists(_fp.tbGamePath.Text))
            {
                var warning = MessageBox.Show("Для запуска игры требуется указать местоположение английского клиента в настройках. Хотите перейти в настройки?", "Sepo", MessageBoxButtons.YesNo);
                if (warning == DialogResult.Yes)
                {
                    btnParams.PerformClick();
                }
}
            else
            {
                var startWork = new Thread(WorkInArc);
                startWork.Start();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        //Кнопка выхода
        {
            Application.Exit();
        }

        public void WorkInArc()
        //Запуск FW
        {
            var i = 0;
            Sepo.ReadSelAccs();
            Sepo.ReadGamePath();
            foreach (var dummy in Sepo.RSelAccs)
            {
                Process.Start(Sepo.RGamePath);
                Thread.Sleep((Sepo.RPauseStart * 1000));
                SendKeys.SendWait("^{TAB}");
                Thread.Sleep(Sepo.RPauseLogin);
                SendKeys.SendWait("+{END}");
                Thread.Sleep(Sepo.RPauseLogin);
                SendKeys.SendWait(Sepo.RSelAccLogins[i]);
                Thread.Sleep(Sepo.RPauseLogin);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(Sepo.RPauseLogin);
                SendKeys.SendWait(Sepo.RSelAccPass[i]);
                Thread.Sleep(Sepo.RPauseLogin);
                SendKeys.SendWait("~");
                Thread.Sleep((Sepo.RPauseClose * 1000));
                i++;
                foreach (var proc in Process.GetProcessesByName("Arc"))
                {
                    proc.Kill();
                }
            }
            Thread.Sleep(500);
            Application.Exit();
        }
    }
}

