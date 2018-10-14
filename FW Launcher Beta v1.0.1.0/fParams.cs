using static System.IO.Path;
// ReSharper disable All

namespace FW_Launcher_Beta_v1._0._1._0
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class FParams : Form
    {
        private readonly FMain _fm;
        private readonly ParamHelp _ph;
        private readonly OpenFileDialog _fd = new OpenFileDialog();



        public FParams(FMain fm)
        {
            _ph = new ParamHelp(this);
            _fm = fm;
            InitializeComponent();
            cbSaveCheckedAccs.Checked = Sepo.SaveAccChoise;
        }

        private void fParams_Load(object sender, EventArgs e)
        //Загрузка формы
        {
            tbStartPause.Text = Sepo.RPauseStart.ToString();
            tbLoginPause.Text = Sepo.RPauseLogin.ToString();
            tbClosePause.Text = Sepo.RPauseClose.ToString();
            btnSavePause.Enabled = false;

            Sepo.ReadGamePath();
            tbGamePath.Text = Sepo.RGamePath;
            if (File.Exists(tbGamePath.Text))
            {
                lblGamePath.Text = Sepo.VPathGame + tbGamePath.Text;
                btnAddGamePath.Enabled = false;
                btnModGamePath.Enabled = true;
                btnDelGamePath.Enabled = true;
                tbGamePath.Enabled = false;
            }
            else
            {
                lblGamePath.Text = Sepo.VPathGame + Sepo.VNotExist;
                btnAddGamePath.Enabled = true;
                btnModGamePath.Enabled = false;
                btnDelGamePath.Enabled = false;
                tbGamePath.Enabled = true;
            }
        }

        #region Тестовые поля

        private void tbStartPause_TextChanged(object sender, EventArgs e)
        //Содержимое текстовых полей с паузами изменилось
        {
            if (tbStartPause.Text != Sepo.RPauseStart.ToString() ||
                tbLoginPause.Text != Sepo.RPauseLogin.ToString() ||
                tbClosePause.Text != Sepo.RPauseClose.ToString())
            {
                btnSavePause.Enabled = true;
            }
            if (tbStartPause.Text.Length == 0 ||
                tbLoginPause.Text.Length == 0 ||
                tbClosePause.Text.Length == 0)
            {
                btnSavePause.Enabled = false;
            }
            else
            {
                btnSavePause.Enabled = true;
            }
            if (tbStartPause.Text == Sepo.DefPauseStart.ToString() &&
                tbLoginPause.Text == Sepo.DefPauseLogin.ToString() &&
                tbClosePause.Text == Sepo.DefPauseClose.ToString())
            {
                btnDefPauses.Enabled = false;
            }
            else if (Sepo.RPauseStart == Sepo.DefPauseStart &&
              Sepo.RPauseLogin == Sepo.DefPauseLogin &&
              Sepo.RPauseClose == Sepo.DefPauseClose)
            {
                btnDefPauses.Enabled = false;
            }
        }

        private void tbStartPause_Leave(object sender, EventArgs e)
        //Фокус покинул текстовое поле с паузами
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).Undo();
            }
        }

        #endregion

        #region Кнопки

        private void btnSavePause_Click(object sender, EventArgs e)
        //Кнопка Сохранить паузы
        {
            if (tbStartPause.Text.Length == 0 ||
                    tbLoginPause.Text.Length == 0 ||
                    tbClosePause.Text.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми.", "Sepo");
            }
            else
            {
                Sepo.CreateParamData("PauseStart", tbStartPause.Text);
                Sepo.CreateParamData("PauseLogin", tbLoginPause.Text);
                Sepo.CreateParamData("PauseClose", tbClosePause.Text);
                btnSavePause.Enabled = false;
            }
            Sepo.CreateAndReadPauseTime();
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        //Кнопка Добавить путь
        {
            if (lblGamePath.Text.Contains(Sepo.VNotExist) && !File.Exists(tbGamePath.Text))
            {
                OpenDir();
            }
            else if ((lblGamePath.Text.Contains(Sepo.VNotExist) && File.Exists(tbGamePath.Text)) ||
                !lblGamePath.Text.Contains(tbGamePath.Text))
            {
                Sepo.CreateParamData("GamePath", tbGamePath.Text);
                lblGamePath.Text = Sepo.VPathGame + tbGamePath.Text;
                SetBoolStatus(false, true, true, false);
            }
        }

        private void btnModPath_Click(object sender, EventArgs e)
        //Кнопка Изменить путь
        {
            if (lblGamePath.Text.Contains(tbGamePath.Text))
            {
                OpenDir();
            }
            else
            {
                btnAddGamePath.Enabled = true;
                btnAddGamePath.PerformClick();
                btnAddGamePath.Enabled = false;
            }
        }

        private void OpenDir()
        //Выбор директории файла
        {
            if (Directory.Exists(tbGamePath.Text))
            {
                _fd.InitialDirectory = tbGamePath.Text;
            }
            else
            {
                _fd.InitialDirectory = @"C:\";
            }
            _fd.Filter = "|patcher.exe";
            _fd.FileName = "patcher.exe";

            if (_fd.ShowDialog() != DialogResult.OK) return;
            switch (GetFileName(_fd.FileName))
            {
                case "patcher.exe" when GetDirectoryName(_fd.FileName).Contains("Forsaken World_en"):
                    tbGamePath.Text = _fd.FileName;
                    SetBoolStatus(true, false, false, false);
                    break;
                case "patcher.exe" when !GetDirectoryName(_fd.FileName).Contains("Forsaken World_en"):
                    MessageBox.Show("Выберите patcher.exe находящийся в папке Forsaken World_en", "Sepo");
                    break;
                default:
                    if (GetFileName(_fd.FileName) != "patcher.exe")
                    {
                        MessageBox.Show("Файл patcher.exe отсутствует", "Sepo");
                    }
                    else if (tbGamePath.Text == _fd.FileName)
                    {
                        return;
                    }

                    break;
            }

            if (lblGamePath.Text.Contains(tbGamePath.Text))
            {
                SetBoolStatus(false, true, true, false);
            }
            else if (!lblGamePath.Text.Contains(tbGamePath.Text))
            {
                if (!lblGamePath.Text.Contains(Sepo.VNotExist))
                {
                    SetBoolStatus(false, true, false, false);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnDelPath_Click(object sender, EventArgs e)
        //Кнопка Удалить путь
        {
            lblGamePath.Text = Sepo.VPathGame + Sepo.VNotExist;
            tbGamePath.Text = Sepo.DefGamePath;
            Sepo.CreateParamData("GamePath", Sepo.DefGamePath);
            SetBoolStatus(true, false, false, true);
        }

        private void SetBoolStatus(bool btnAdd, bool btnMod, bool btnDel, bool tbPath)
        //Активация/деактивация кнопок пути и текстового поля пути
        {
            btnAddGamePath.Enabled = btnAdd;
            btnModGamePath.Enabled = btnMod;
            btnDelGamePath.Enabled = btnDel;
            tbGamePath.Enabled = tbPath;

        }

        private void btnDelAllParam_Click(object sender, EventArgs e)
        //Кнопка Удалить ВСЕ
        {
            var result = MessageBox.Show("Программа будет подготовлена к удалению. Все данные аккаунтов и настроек будут удалены из реестра, после чего программа будет закрыта. Для полного удаления программы вам остается только самостоятельно удалить сам лаунчер в корзину.\nВы точно хотите это сделать?", "Sepo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Sepo.DeleteAllRegData();
                Close();
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnDefPauses_Click(object sender, EventArgs e)
        //Кнопка По умолчанию
        {
            var result = MessageBox.Show("Значения пауз будет выставлено по умолчанию.\nВы действительно хотите это сделать?.", "Sepo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Sepo.DeleteParamValue("PauseStart");
                Sepo.DeleteParamValue("PauseLogin");
                Sepo.DeleteParamValue("PauseClose");
                Sepo.CreateAndReadPauseTime();
                if (Sepo.RPauseStart > 0)
                {
                    tbStartPause.Text = Sepo.RPauseStart.ToString();
                    tbLoginPause.Text = Sepo.RPauseLogin.ToString();
                    tbClosePause.Text = Sepo.RPauseClose.ToString();
                }
                else
                {
                    tbStartPause.Text = Sepo.DefPauseStart.ToString();
                    tbLoginPause.Text = Sepo.DefPauseLogin.ToString();
                    tbClosePause.Text = Sepo.DefPauseClose.ToString();
                }
                btnSavePause.Enabled = false;
                btnDefPauses.Enabled = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        //Кнопка Справка
        {
            Hide();
            _ph.Show();
        }

        private void btnBackFromSet_Click(object sender, EventArgs e)
        //Кнопка Вернуться
        {
            if (!lblGamePath.Text.Contains(tbGamePath.Text))
            {
                if (lblGamePath.Text.Contains(Sepo.VNotExist))
                {
                    tbGamePath.Text = Sepo.DefGamePath;
                    SetBoolStatus(true, false, false, true);
                }
                else
                {
                    tbGamePath.Text = lblGamePath.Text.Replace(Sepo.VPathGame, "");
                    SetBoolStatus(false, true, true, false);
                }
            }

            if (tbStartPause.Text.Length == 0 ||
                tbStartPause.Text != Sepo.RPauseStart.ToString()) tbStartPause.Text = Sepo.RPauseStart.ToString();
            if (tbLoginPause.Text.Length == 0 ||
                tbLoginPause.Text != Sepo.RPauseLogin.ToString()) tbLoginPause.Text = Sepo.RPauseLogin.ToString();
            if (tbClosePause.Text.Length == 0 ||
                tbClosePause.Text != Sepo.RPauseClose.ToString()) tbClosePause.Text = Sepo.RPauseClose.ToString();
            btnSavePause.Enabled = false;

            _fm.Show();
            Hide();
        }

        #endregion

        private void fParams_KeyDown(object sender, KeyEventArgs e)
        //Нажатие клавиш
        {
            if (e.KeyCode == Keys.Escape) //Клавиша ESC
            {
                var str = lblGamePath.Text.Replace(Sepo.VPathGame, "");
                if (!lblGamePath.Text.Contains(Sepo.VNotExist))
                {
                    if (!lblGamePath.Text.Contains(tbGamePath.Text))
                    {
                        tbGamePath.Text = lblGamePath.Text.Replace(Sepo.VPathGame, "");
                        SetBoolStatus(false, true, true, false);
                    }
                }
                else
                {
                    SetBoolStatus(true, false, false, true);
                    tbGamePath.Text = Sepo.DefGamePath;
                }
                if (tbStartPause.Text.Length == 0 ||
                    tbStartPause.Text != Sepo.RPauseStart.ToString()) tbStartPause.Text = Sepo.RPauseStart.ToString();
                if (tbLoginPause.Text.Length == 0 ||
                    tbLoginPause.Text != Sepo.RPauseLogin.ToString()) tbLoginPause.Text = Sepo.RPauseLogin.ToString();
                if (tbClosePause.Text.Length == 0 ||
                    tbClosePause.Text != Sepo.RPauseClose.ToString()) tbClosePause.Text = Sepo.RPauseClose.ToString();
            }
            if (e.KeyCode == Keys.Enter) //Клавиша ENTER
            {
                if (btnAddGamePath.Enabled)
                {
                    btnAddGamePath.PerformClick();
                }
                else if (btnModGamePath.Enabled)
                {
                    btnModGamePath.PerformClick();
                }
            }
        }

        private void cbSaveCheckedAccs_CheckedChanged(object sender, EventArgs e)
        {
            Sepo.CreateParamData("SaveChoise", Convert.ToBoolean(cbSaveCheckedAccs.CheckState).ToString());
        }
    }
}
