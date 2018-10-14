using System;
using System.IO;
using System.Windows.Forms;

namespace FW_Launcher_Beta_v1._0._1._0
{
    public partial class ParamHelp : Form
    {
        private readonly FParams _fp;
        private readonly OpenFileDialog _ofd = new OpenFileDialog();

        public ParamHelp(FParams fp)
        {
            _ofd.RestoreDirectory = true;
            _fp = fp;
            InitializeComponent();
        }

        private void ParamHelp_Load(object sender, EventArgs e)
        //Загрузка формы
        {
            SetBool(true, false, false, true);
            SetGamePath(@"C:\", "Отсутствует");
            tcParamHelp.SelectedTab = tpHelpAddGamePath;
            btnPrevTabHelpParam.Enabled = false;
            btnSepoModHelp.Enabled = false;
            tbHelpStartPause.Text = "10";
            tbHelpLoginPause.Text = "1000";
            tbHelpClosePause.Text = "20";
            btnHelpDefPauses.Enabled = false;
            btnHelpSavePause.Enabled = false;
        }

        #region Вкладка Добавить путь

        private void btnHelpAddPath_Click(object sender, EventArgs e)
        //Кнопка Добавить путь
        {
            if (!File.Exists(tbHelpAddGamePath.Text))
            {
                HelpOpenDir();
            }
            else
            {
                SetGamePath(tbHelpAddGamePath.Text, tbHelpAddGamePath.Text);
                SetBool(false, true, true, false);
                if (cbAutoNextTab.Checked)
                {
                    tcParamHelp.SelectedIndex = tcParamHelp.SelectedIndex + 1;
                }
            }
            btnSepoModHelp.Enabled = true;
        }

        #endregion

        #region Вкладка Изменить путь

        private void btnHelpModGamePath_Click(object sender, EventArgs e)
        //Кнопка Изменить путь
        {
            if (lblHelpModGamePath.Text.Contains(tbHelpModGamePath.Text))
            {
                HelpOpenDir();
            }
            else
            {
                SetGamePath(tbHelpAddGamePath.Text, tbHelpAddGamePath.Text);
                SetBool(false, true, true, false);
                if (cbAutoNextTab.Checked)
                {
                    tcParamHelp.SelectedIndex = tcParamHelp.SelectedIndex + 1;
                }
            }
        }

        #endregion

        #region Вкладка Удалить путь

        private void btnHelpDelGamePath_Click(object sender, EventArgs e)
        //Кнопка Удалить путь
        {
            SetBool(true, false, false, true);
            SetGamePath(@"C:\", "Отсутствует");
            if (cbAutoNextTab.Checked)
            {
                tcParamHelp.SelectedIndex = tcParamHelp.SelectedIndex + 1;
            }

            if (btnSepoModHelp.Visible) return;
            var dir = new DirectoryInfo(@"C:\Sepo");
            dir.Delete(true);
            btnSepoModHelp.Visible = true;
        }

        #endregion

        #region Не относящееся к определенной вкладке

        private void SetGamePath(string tbGamePath, string lblGamePath)
        //Выставить пути в надписи и поля
        {
            tbHelpAddGamePath.Text = tbGamePath;
            tbHelpModGamePath.Text = tbGamePath;
            tbHelpDelGamePath.Text = tbGamePath;
            lblHelpAddGamePath.Text = "Путь до игры: " + lblGamePath;
            lblHelpModGamePath.Text = "Путь до игры: " + lblGamePath;
            lblHelpDelGamePath.Text = "Путь до игры: " + lblGamePath;
        }

        #region Кнопки

        private void SetBool(bool btnAddGamePath, bool btnModGamePath, bool btnDelGamePath, bool tbGamePath)
        //Активировать/дезактивировать кнопки
        {
            btnHelpAddGamePath.Enabled = btnAddGamePath;
            btnHelpModGamePath.Enabled = btnModGamePath;
            btnHelpDelGamePath.Enabled = btnDelGamePath;
            tbHelpAddGamePath.Enabled = tbGamePath;
            tbHelpModGamePath.Enabled = tbGamePath;
            tbHelpDelGamePath.Enabled = tbGamePath;
        }

        private void HelpOpenDir()
        //Выбор директории игры
        {
            if (lblHelpModGamePath.Text.Contains("Отсутствует"))
            {
                _ofd.InitialDirectory = @"C:\";
            }
            else if (File.Exists(@"C:\Sepo\Forsaken World_en\patcher.exe"))
            {
                _ofd.InitialDirectory = @"C:\Sepo\Forsaken World_en\";
            }
            else
            {
                _ofd.InitialDirectory = _fp.lblGamePath.Text.Replace("Путь до игры: ", "");
            }

            _ofd.Filter = "|patcher.exe";
            _ofd.FileName = "patcher.exe";

            if (_ofd.ShowDialog() != DialogResult.OK) return;
            if (Path.GetFileName(_ofd.FileName) != "patcher.exe" ||
                !Path.GetDirectoryName(_ofd.FileName).Contains("Forsaken World_en"))
            {
                if (Path.GetFileName(_ofd.FileName) == "patcher.exe" &&
                    !Path.GetDirectoryName(_ofd.FileName).Contains("Forsaken World_en"))
                {
                    MessageBox.Show("Выберите patcher.exe находящийся в папке Forsaken World_en", "Sepo");
                }
                else if (Path.GetFileName(_ofd.FileName) != "patcher.exe")
                {
                    MessageBox.Show("Файл patcher.exe отсутствует", "Sepo");
                }
                else if (tbHelpAddGamePath.Text == _ofd.FileName)
                {
                    return;
                }
            }
            else
            {
                if (lblHelpAddGamePath.Text.Contains("Отсутствует"))
                {
                    SetGamePath(_ofd.FileName, "Отсутствует");
                    SetBool(true, false, false, false);
                }
                else if (!lblHelpAddGamePath.Text.Contains("Отсутствует"))
                {
                    SetGamePath(_ofd.FileName, lblHelpAddGamePath.Text.Replace("Путь до игры: ", ""));
                    SetBool(false, true, true, false);
                    btnHelpDelGamePath.Enabled = false;
                }
            }

            if (lblHelpAddGamePath.Text.Contains(tbHelpAddGamePath.Text))
            {
                SetBool(false, true, true, false);
            }
            else if (!lblHelpAddGamePath.Text.Contains(tbHelpAddGamePath.Text))
            {
                if (!lblHelpAddGamePath.Text.Contains("Отсутствует"))
                {
                    SetBool(false, true, false, false);
                }
            }
        }

        private void btnNextTabHelpParam_Click(object sender, EventArgs e)
        //Кнопка Следующая вкладка
        {
            var i = tcParamHelp.SelectedIndex;
            var j = tcParamHelp.TabCount;
            if (i + 1 < j - 1)
            {
                tcParamHelp.SelectedIndex = i + 1;
                btnPrevTabHelpParam.Enabled = true;
            }
            else if (i + 1 == j - 1)
            {
                tcParamHelp.SelectedIndex = i + 1;
                btnNextTabHelpParam.Enabled = false;
                btnPrevTabHelpParam.Enabled = true;
            }
        }

        private void btnPrevTabHelpParam_Click(object sender, EventArgs e)
        //Кнопка предыдущая вкладка
        {

            var i = tcParamHelp.SelectedIndex;
            if (i - 1 > 0)
            {
                tcParamHelp.SelectedIndex = i - 1;
                btnNextTabHelpParam.Enabled = true;
            }
            else if (i - 1 == 0)
            {
                tcParamHelp.SelectedIndex = i - 1;
                btnNextTabHelpParam.Enabled = true;
                btnPrevTabHelpParam.Enabled = false;
            }
        }

        private void btnReturnFromParamHelp_Click(object sender, EventArgs e)
        //Кнопка Вернуться
        {
            if (File.Exists(@"C:\Sepo\Forsaken Worl_en\patcher.exe"))
            {
                var dir = new DirectoryInfo(@"C:\Sepo");
                dir.Delete(true);
                btnSepoModHelp.Visible = true;
            }
            Hide();
            _fp.Show();
        }

        #endregion

        private void ParamHelp_KeyDown(object sender, KeyEventArgs e)
        //Клавиши
        {
            if (e.KeyCode != Keys.Escape) return;
            if (!lblHelpAddGamePath.Text.Contains("Отсутствует"))
            {
                if (!lblHelpAddGamePath.Text.Contains(tbHelpAddGamePath.Text))
                {
                    SetBool(false, true, false, false);
                    SetGamePath(lblHelpAddGamePath.Text.Replace("Путь до игры: ", ""),
                        lblHelpAddGamePath.Text.Replace("Путь до игры: ", ""));
                }
                else
                {
                    return;
                }
            }
            else if (lblHelpAddGamePath.Text.Contains("Отсутствует"))
            {
                SetBool(false, false, true, true);
                SetGamePath(@"C:\", lblHelpAddGamePath.Text.Replace("Путь до игры: ", ""));
            }
            if (!btnSepoModHelp.Visible)
            {

                btnSepoModHelp.Visible = true;
            }

            if (!File.Exists(@"C:\Sepo\Forsaken Worl_en\patcher.exe")) return;
            var dir = new DirectoryInfo(@"C:\Sepo");
            dir.Delete(true);
        }

        #endregion

        private void btnSepoModHelp_Click(object sender, EventArgs e)
        //Кнопка Схитрить
        {
            const string dirC = @"C:\";
            const string sepoDir = @"Sepo\Forsaken World_en";
            var dir = new DirectoryInfo(dirC);

            dir.CreateSubdirectory(sepoDir);
            CreateHelpFile();
            btnSepoModHelp.Visible = false;
        }

        private void CreateHelpFile()
        //Создание файла для помощи
        {
            using (var fs = File.Create(@"C:\Sepo\Forsaken World_en\patcher.exe"))
            {
                fs.Close();
            }
        }

        private void tcParamHelp_SelectedIndexChanged(object sender, EventArgs e)
        //Переключение вкладок
        {
            if (tcParamHelp.SelectedIndex == 0)
            {
                btnPrevTabHelpParam.Enabled = false;
                btnNextTabHelpParam.Enabled = true;
            }
            else if (tcParamHelp.SelectedIndex == tcParamHelp.TabCount - 1)
            {
                btnPrevTabHelpParam.Enabled = true;
                btnNextTabHelpParam.Enabled = false;
            }
            else
            {
                btnPrevTabHelpParam.Enabled = true;
                btnNextTabHelpParam.Enabled = true;
            }
        }

        private void btnSavePause_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Так как это всего лишь справка, то ваши паузы типо сохранены.", "Sepo");
            btnHelpSavePause.Enabled = false;
        }

        private void tbStartPause_TextChanged(object sender, EventArgs e)
        {
            if ((tbHelpStartPause.Text == "10" &&
                tbHelpLoginPause.Text == "1000" &&
                tbHelpClosePause.Text == "20") ||
                (tbHelpStartPause.Text.Length == 0 ||
                tbHelpLoginPause.Text.Length == 0 ||
                tbHelpClosePause.Text.Length == 0))
            {
                btnHelpDefPauses.Enabled = false;
                btnHelpSavePause.Enabled = false;
            }
            else
            {
                btnHelpSavePause.Enabled = true;
                btnHelpDefPauses.Enabled = true;
            }
        }

        private void btnHelpDefPauses_Click(object sender, EventArgs e)
        {
            tbHelpStartPause.Text = "10";
            tbHelpLoginPause.Text = "1000";
            tbHelpClosePause.Text = "20";
            btnHelpDefPauses.Enabled = false;
        }

        private void tbHelpStartPause_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                (sender as TextBox).Undo();
            }
        }
    }
}
