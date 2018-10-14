using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FW_Launcher_Beta_v1._0._1._0
{
    public partial class FAccMan : Form
    {
        private readonly FMain _fm;
        private readonly AccManHelp _amh;
        public FAccMan(FMain fm)
        {
            _amh = new AccManHelp(this);
            _fm = fm;
            InitializeComponent();
        }

        private void fAccMan_Load(object sender, EventArgs e)
        //Загрузка формы
        {
            tbAccPass.UseSystemPasswordChar = true;
            btnAccAdd.Enabled = false;
            btnAccMod.Enabled = false;
            btnAccDel.Enabled = false;
            btnAccManDelAll.Enabled = false;
            btnAccManDelAll.Enabled = lbAccList.Items.Count > 1;
        }

        #region Текстовые поля

        private void tbAccName_TextChanged(object sender, EventArgs e)
        //Действие при изменение текстовых полей
        {
            if (lbAccList.Enabled) //Список аккаунтов Активен
            {
                btnAccMod.Enabled = false;
                if (lbAccList.SelectedItems.Count < 1) //Если ни один аккаунт не выбран
                {
                    btnAccDel.Enabled = false;

                    #region Развернутый вариант условий для деактивации кнопки Добавить аккаунт
                    //if(tbAccName.Text.Length == 0 || 
                    //    tbAccLogin.Text.Length == 0 || 
                    //    tbAccPass.Text.Length == 0)
                    //{
                    //    btnAccAdd.Enabled = false;
                    //} else if (tbAccName.Text == Sepo.defAccName || 
                    //    tbAccLogin.Text == Sepo.defAccLogin || 
                    //    tbAccPass.Text == Sepo.defAccPass)
                    //{
                    //    btnAccAdd.Enabled = false;
                    //} else if (Sepo.accNames.Contains(tbAccName.Text) || Sepo.accLogins.Contains(tbAccLogin.Text))
                    //{
                    //    btnAccAdd.Enabled = false;
                    //}
                    #endregion

                    if ((tbAccName.Text.Length == 0 ||
                        tbAccLogin.Text.Length == 0 ||
                        tbAccPass.Text.Length == 0) ||
                        (tbAccName.Text == Sepo.DefAccName ||
                        tbAccLogin.Text == Sepo.DefAccLogin ||
                        tbAccPass.Text == Sepo.DefAccPass) ||
                        (Sepo.AccNames.Contains(tbAccName.Text) ||
                        Sepo.AccLogins.Contains(tbAccLogin.Text)))
                    {
                        btnAccAdd.Enabled = false;
                    }
                    else
                    {
                        btnAccAdd.Enabled = true;
                    }
                }
                else //Если аккаунт выделен
                {
                    btnAccAdd.Enabled = false;
                    btnAccDel.Enabled = true;
                }
            }
            else //Список аккаунтов НЕ активен
            {
                Sepo.ReadAccData((string)lbAccList.SelectedItem);
                btnAccAdd.Enabled = false;
                btnAccDel.Enabled = false;
                if ((tbAccName.Text.Length == 0 ||
                    tbAccLogin.Text.Length == 0 ||
                    tbAccPass.Text.Length == 0) ||
                    (tbAccName.Text == Sepo.DefAccName ||
                    tbAccLogin.Text == Sepo.DefAccLogin ||
                    tbAccPass.Text == Sepo.DefAccPass) ||
                    (tbAccName.Text == Sepo.RAccName &&
                    tbAccLogin.Text == Sepo.RAccLogin &&
                    tbAccPass.Text == Sepo.RAccPass))
                {
                    btnAccMod.Enabled = false;
                }
                else
                {
                    btnAccMod.Enabled = true;
                }
            }
            btnShowPass.Enabled = tbAccPass.Text.Length != 0;
        }

        private void tbAccName_DoubleClick(object sender, EventArgs e)
        //Двойной клик по текстовому полю
        {
            if (((TextBox)sender).SelectedText.Any())
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void SetTextToDefault()
        //Выставить текст в полях по умолчанию
        {
            tbAccName.Text = Sepo.DefAccName;
            tbAccLogin.Text = Sepo.DefAccLogin;
            tbAccPass.Text = Sepo.DefAccPass;
        }

        #endregion

        #region Список аккаунтов

        private void lbAccList_SelectedIndexChanged(object sender, EventArgs e)
        //Изменение выбранных аккаунтов
        {
            if (lbAccList.Enabled) //Если список аккаунтов активен
            {
                if (lbAccList.SelectedItems.Count < 0) //Если ни один аккаунт не выбран
                {
                    btnAccDel.Enabled = false;
                    btnAccMod.Enabled = false;
                }
                else //Если выбран аккаунт
                {
                    if (lbAccList.Enabled)
                    {
                        btnAccDel.Enabled = true;
                    }
                }
                if (lbAccList.Items.Count > 1)
                {
                    btnAccManDelAll.Enabled = true;
                }
            }
        }

        private void lbAccList_DoubleClick(object sender, EventArgs e)
        //Двойной клик по списку аккаунтов
        {
            if (lbAccList.SelectedItems.Count <= 0) return;
            Sepo.ReadAccData((string)lbAccList.SelectedItem);
            lbAccList.Enabled = false;
            tbAccName.Text = Sepo.RAccName;
            tbAccLogin.Text = Sepo.RAccLogin;
            tbAccPass.Text = Sepo.RAccPass;
            btnAccDel.Enabled = false;
        }

        #endregion

        #region Кнопки

        #region Кнопка показа пароля

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        //Кнопка мыши нажата
        {
            tbAccPass.UseSystemPasswordChar = false;
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        //Кнопка мыши отжата
        {
            tbAccPass.UseSystemPasswordChar = true;
        }

        #endregion

        private void btnAccAdd_Click(object sender, EventArgs e)
        //Кнопка Добавить Аккаунт
        {
            Sepo.CreateAccData(tbAccName.Text, tbAccLogin.Text, tbAccPass.Text);
            lbAccList.Items.Add(tbAccName.Text);
            _fm.clbStartAccList.Items.Add(tbAccName.Text);
            SetTextToDefault();
            if (lbAccList.SelectedItems.Count > 0)
            {
                lbAccList.ClearSelected();
            }
            btnAccAdd.Enabled = false;
            btnAccManDelAll.Enabled = lbAccList.Items.Count > 1;
        }

        private void btnAccMod_Click(object sender, EventArgs e)
        //Кнопка Изменить аккаунт
        {
            var tempAccName = (string)lbAccList.SelectedItem;
            Sepo.ReadAccData(tempAccName);
            var tempAccData = new List<string>() { Sepo.RAccName, Sepo.RAccLogin, Sepo.RAccPass };
            if ((string)lbAccList.SelectedItem != tbAccName.Text)
            {
                Sepo.CreateAccData(tbAccName.Text, tbAccLogin.Text, tbAccPass.Text);
                Sepo.DeleteAcc(tempAccName);
                _fm.clbStartAccList.Items.Add(tbAccName.Text);
                _fm.clbStartAccList.Items.Remove(tempAccName);
                lbAccList.Items.Add(tbAccName.Text);
                lbAccList.Items.Remove(tempAccName);
            }
            else
            {
                if (tempAccData[1] != tbAccLogin.Text)
                {
                    Sepo.ModifyRegAccData(tempAccName, "AccLogin", tbAccLogin.Text);
                }
                if (tempAccData[2] != tbAccPass.Text)
                {
                    Sepo.ModifyRegAccData(tempAccName, "AccPass", tbAccPass.Text);
                }
            }
            SetTextToDefault();
            lbAccList.ClearSelected();
            lbAccList.Enabled = true;
            btnAccMod.Enabled = false;
        }

        private void btnAccDel_Click(object sender, EventArgs e)
        //Кнопка Удалить Аккаунт
        {
            var tempAccName = (string)lbAccList.SelectedItem;
            _fm.clbStartAccList.Items.Remove(tempAccName);
            lbAccList.Items.Remove(tempAccName);
            Sepo.DeleteAcc(tempAccName);
            btnAccDel.Enabled = false;
            if (lbAccList.SelectedItems.Count > 0)
            {
                lbAccList.ClearSelected();
            }
            SetTextToDefault();
            btnAccManDelAll.Enabled = lbAccList.Items.Count > 1;
        }

        private void btnAccManDelAll_Click(object sender, EventArgs e)
        //Кнопка Удалить ВСЕ аккаунты
        {
            var result = MessageBox.Show("Все данные Аккаунтов из реестра будут удалены.\nВы действительно хотите этого?", "Sepo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Sepo.CreateAccNames();
                foreach (var str in Sepo.AccNames)
                {
                    _fm.clbStartAccList.Items.Remove(str);
                    lbAccList.Items.Remove(str);
                }
                Sepo.ClearAccDataLists();
                Sepo.DeleteAllAccRegData();
                btnAccManDelAll.Enabled = false;
            }
        }

        private void btnAccManHelp_Click(object sender, EventArgs e)
        //Кнопка Справки
        {
            Hide();
            _amh.Show();
        }

        private void btnBackFromAccMan_Click(object sender, EventArgs e)
        //Кнопка возврата
        {
            if (lbAccList.SelectedItems.Count > 0)
            {
                lbAccList.ClearSelected();
            }
            if (lbAccList.Enabled == false)
            {
                lbAccList.Enabled = true;
            }
            Hide();
            _fm.Show();
        }

        #endregion

        private void lbAccList_KeyDown(object sender, KeyEventArgs e)
        //Клавиши
        {
            if (e.KeyCode == Keys.Escape) //Клавиша ESC
            {
                if (lbAccList.Enabled == false)
                {
                    lbAccList.ClearSelected();
                    SetTextToDefault();
                    lbAccList.Enabled = true;
                }
                else
                {
                    if (lbAccList.SelectedItems.Count > 0)
                    {
                        lbAccList.ClearSelected();
                        btnAccDel.Enabled = false;
                    }
                    if ((tbAccName.Text.Length == 0 ||
                        tbAccLogin.Text.Length == 0 ||
                        tbAccPass.Text.Length == 0) ||
                        (tbAccName.Text == Sepo.DefAccName ||
                        tbAccLogin.Text == Sepo.DefAccLogin ||
                        tbAccPass.Text == Sepo.DefAccPass))
                    {
                        SetTextToDefault();
                    }
                }
            }
            if (e.KeyCode == Keys.Enter) //Клавиша ENTER
            {
                if (btnAccAdd.Enabled)
                {
                    btnAccAdd.PerformClick();
                }
                else if (btnAccMod.Enabled)
                {
                    btnAccMod.PerformClick();
                }
                tbAccName.Focus();
            }
            if (e.KeyCode == Keys.Delete) //Клавиша DELETE
            {
                if (lbAccList.SelectedItems.Count > 0)
                {
                    btnAccDel.PerformClick();
                }
            }

            if (e.KeyCode != Keys.Delete || !e.Shift) return;
            if (btnAccManDelAll.Enabled)
            {
                btnAccManDelAll.PerformClick();
            }
        }

        private void tbAccName_Click(object sender, EventArgs e)
        //Одинарный клик по текстовому полю
        {
            if (lbAccList.Enabled)
            {
                lbAccList.ClearSelected();
                btnAccDel.Enabled = false;
            }
            else
            {
                btnAccDel.Enabled = false;
            }
        }
    }
}
