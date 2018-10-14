using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FW_Launcher_Beta_v1._0._1._0
{
    public partial class AccManHelp : Form
    {
        private readonly Random _ran = new Random();

        private readonly FAccMan _fam;
        public AccManHelp(FAccMan fam)
        {
            _fam = fam;
            InitializeComponent();
        }

        private void AccManHelp_Load(object sender, EventArgs e)
        //Загрузка формы
        {
            SetHelpDataToDefault();
            btnPrevTabHelpAcc.Enabled = false;
            tbHelpAddAccPass.UseSystemPasswordChar = true;
            tbHelpModAccPass.UseSystemPasswordChar = true;
            Sepo.CreateHelpAccData("Справочный аккаунт", @"почта@что-то.нечто", @"#&*Бел_е6е_RDA*&#");
            RefreshHelpLists();
        }

        #region Вкладка Создание

        private void btnHelpAccAdd_Click(object sender, EventArgs e)
        //Кнопка Добавить данные
        {
            Sepo.CreateHelpAccNames();
            if (Sepo.HelpAccNames.Count < 6)
            {
                Sepo.CreateHelpAccData(tbHelpAddAccName.Text, tbHelpAddAccLogin.Text, tbHelpAddAccPass.Text);
                lbHelpModAccList.Items.Add(tbHelpAddAccName.Text);
                lbHelpDelAccList.Items.Add(tbHelpAddAccName.Text);
                MessageBox.Show("Ваш аккаунт успешно добавлен!", "Sepo");
                btnHelpAddAcc.Focus();
            }
            else
            {
                MessageBox.Show("Это всего лишь справка и больше 5-ти аккаунтов создавать не хочется...\nЕсли вы все-таки НАСТАИВАЕТЕ, то удалите какой-нибудь не нужный (но только не созданный мною, он ОЧЕНЬ нужный).", "Sepo");
            }
            SetHelpDataToDefault();
            btnHelpAddAcc.Enabled = false;
        }

        #endregion

        #region Вкладка Изменение

        private void btnHelpModAcc_Click(object sender, EventArgs e)
        //Кнопка Изменить аккаунт
        {
            var tempAccName = (string)lbHelpModAccList.SelectedItem;
            Sepo.ReadHelpAccData(tempAccName);
            var tempAccData = new List<string>() { Sepo.RHelpAccName, Sepo.RHelpAccLogin, Sepo.RHelpAccPass };
            if (lbHelpModAccList.SelectedItem.ToString() == "Справочный аккаунт")
            {
                MessageBox.Show("Эх.. Я так старался, создавал этот аккаунт, а вы так вероломно изменяете его данные. Ну чтож, я просто вынужден восстановить его данные для вселенской идиллии. Но сделаю это (между прочем ради вас) только через секунд так 5 - 10.", "Sepo");
                timer1.Interval = _ran.Next(5, 10);
                timer1.Start();
            }
            if ((string)lbHelpModAccList.SelectedItem != tbHelpModAccName.Text)
            {
                Sepo.CreateHelpAccData(tbHelpModAccName.Text, tbHelpModAccLogin.Text, tbHelpModAccPass.Text);
                Sepo.DeleteHelpAcc(tempAccName);
                lbHelpModAccList.Items.Add(tbHelpModAccName.Text);
                lbHelpModAccList.Items.Remove(tempAccName);
            }
            else
            {
                if (tempAccData[1] != tbHelpModAccLogin.Text)
                {
                    Sepo.ModifyRegAccData(tempAccName, "HelpAccLogin", tbHelpModAccLogin.Text);
                }
                if (tempAccData[2] != tbHelpModAccPass.Text)
                {
                    Sepo.ModifyRegHelpAccData(tempAccName, "HelpAccPass", tbHelpModAccPass.Text);
                }
            }
            SetHelpDataToDefault();
            lbHelpModAccList.ClearSelected();
            lbHelpModAccList.Enabled = true;
            btnHelpModAcc.Enabled = false;
            MessageBox.Show("Данные аккаунта успешно изменены.", "Sepo");
            lbHelpModAccList.Focus();
        }

        #endregion

        #region Вкладка Удаление

        private void btnHelpDelAcc_Click(object sender, EventArgs e)
        //Кнопка Удалить данные
        {
            if (lbHelpDelAccList.SelectedItem.ToString() == "Справочный аккаунт")
            {
                MessageBox.Show("Ай-яй-яй, удалять моё творение решили значит... Ну ладно, ничего страшного, через 1 - 5 секунд я его восстановлю :Р", "Sepo");
                timer1.Interval = _ran.Next(1, 5);
                timer1.Start();
            }
            Sepo.DeleteHelpAcc(lbHelpDelAccList.SelectedItem.ToString());
            btnHelpDelAcc.Enabled = false;
            lbHelpDelAccList.Items.Remove(lbHelpDelAccList.SelectedItem);
            SetHelpDataToDefault();
            MessageBox.Show("Аккаунт успешно удален!", "Sepo");
        }

        private void lbHelpDelAccList_SelectedIndexChanged(object sender, EventArgs e)
        //Выбор аккаунта в списке во вкладке Удаление
        {
            btnHelpDelAcc.Enabled = lbHelpDelAccList.SelectedItems.Count > 0;
        }

        #endregion

        #region Не относящееся к определённой вкладке

        private void tcAccManHelp_SelectedIndexChanged(object sender, EventArgs e)
        //Действие при переключении между вкладками
        {
            SetHelpDataToDefault();
            RefreshHelpLists();
        }

        private void lbHelpModAccList_DoubleClick(object sender, EventArgs e)
        //Двойной клик по списку справочных аккаунтов
        {
            if (tcAccManHelp.SelectedTab != tpHelpModAcc) return;
            if (lbHelpModAccList.SelectedItems.Count <= 0) return;
            Sepo.ReadHelpAccData(lbHelpModAccList.SelectedItem.ToString());
            lbHelpModAccList.Enabled = false;
            tbHelpModAccName.Text = Sepo.RHelpAccName;
            tbHelpModAccName.Focus();
            tbHelpModAccLogin.Text = Sepo.RHelpAccLogin;
            tbHelpModAccPass.Text = Sepo.RHelpAccPass;
        }

        private void TextBox_DoubleClick(object sender, EventArgs e)
        //Двойной клик по полю текста
        {
            (sender as TextBox).SelectAll();
        }

        private void TextBox_TextChange(object sender, EventArgs e)
        //Изменение текстовых полей
        {
            if (tcAccManHelp.SelectedTab == tpHelpAddAcc) //Вкладка Создание аккаунта
            {
                btnHelpAddAccShowPass.Enabled = tbHelpAddAccPass.Text.Length != 0;
                if ((tbHelpAddAccName.Text.Length == 0 ||
                    tbHelpAddAccLogin.Text.Length == 0 ||
                    tbHelpAddAccPass.Text.Length == 0) ||
                    (tbHelpAddAccName.Text == Sepo.DefAccName ||
                    tbHelpAddAccLogin.Text == Sepo.DefAccLogin ||
                    tbHelpAddAccPass.Text == Sepo.DefAccPass))
                {
                    btnHelpAddAcc.Enabled = false;
                }
                else
                {
                    btnHelpAddAcc.Enabled = true;
                }
            }
            else if (tcAccManHelp.SelectedTab == tpHelpModAcc) //Вкладка Изменение аккаунта
            {
                btnHelpModAccShowPass.Enabled = tbHelpModAccPass.Text.Length != 0;
                if ((tbHelpModAccName.Text.Length == 0 ||
                    tbHelpModAccLogin.Text.Length == 0 ||
                    tbHelpModAccPass.Text.Length == 0) ||
                    (tbHelpModAccName.Text == Sepo.DefAccName ||
                    tbHelpModAccLogin.Text == Sepo.DefAccLogin ||
                    tbHelpModAccPass.Text == Sepo.DefAccPass))
                {
                    btnHelpModAcc.Enabled = false;
                }
                else
                {
                    btnHelpModAcc.Enabled = true;
                }
            }
        }

        private void tbHelpAccPass_KeyDown(object sender, KeyEventArgs e)
        //Нажатие Клавиш
        {
            if (e.KeyCode != Keys.Enter)
            {
                if (e.KeyCode != Keys.Escape)
                {
                    if (e.KeyCode == Keys.Delete && e.Shift)
                    {
                        if (btnHelpDelAllAcc.Enabled)
                        {
                            btnHelpDelAllAcc.PerformClick();
                        }
                    }
                }
                else
                {
                    SetHelpDataToDefault();
                }
            }
            else
            {
                if (tcAccManHelp.SelectedTab == tpHelpAddAcc)
                {
                    if (btnHelpAddAcc.Enabled)
                    {
                        btnHelpAddAcc.PerformClick();
                    }
                }
                else if (tcAccManHelp.SelectedTab == tpHelpModAcc)
                {
                    if (btnHelpModAcc.Enabled)
                    {
                        btnHelpModAcc.PerformClick();
                    }
                }
            }

            if (e.KeyCode != Keys.Delete) return;
            if (lbHelpDelAccList.SelectedItems.Count > 0)
            {
                btnHelpDelAcc.PerformClick();
            }
        }

        #region Кнопки

        #region Кнопка показа пароля

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        //Кнопка мыши нажата
        {
            if (tcAccManHelp.SelectedTab == tpHelpAddAcc)
            {
                tbHelpAddAccPass.UseSystemPasswordChar = false;
            }
            else if (tcAccManHelp.SelectedTab == tpHelpModAcc)
            {
                tbHelpModAccPass.UseSystemPasswordChar = false;
            }
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        //Кнопка мыши отжата
        {
            if (tcAccManHelp.SelectedTab == tpHelpAddAcc)
            {
                tbHelpAddAccPass.UseSystemPasswordChar = true;
            }
            else if (tcAccManHelp.SelectedTab == tpHelpModAcc)
            {
                tbHelpModAccPass.UseSystemPasswordChar = true;
            }
        }

        #endregion

        private void btnNextTabFromHelpAddAcc_Click(object sender, EventArgs e)
        //Кнопка Следующая вкладка
        {
            var i = tcAccManHelp.SelectedIndex;
            var j = tcAccManHelp.TabCount;

            if (i + 1 < j - 1)
            {
                tcAccManHelp.SelectedIndex = i + 1;
                btnPrevTabHelpAcc.Enabled = true;
            }
            else if (i + 1 == j - 1)
            {
                tcAccManHelp.SelectedIndex = i + 1;
                btnNextTabHelpAcc.Enabled = false;
                btnPrevTabHelpAcc.Enabled = true;
            }
        }

        private void btnPrevTabHelpAcc_Click(object sender, EventArgs e)
        //Кнопка Предыдущая вкладка
        {
            var i = tcAccManHelp.SelectedIndex;

            if (i - 1 > 0)
            {
                tcAccManHelp.SelectedIndex = i - 1;
                btnNextTabHelpAcc.Enabled = true;
            }
            else if (i - 1 == 0)
            {
                tcAccManHelp.SelectedIndex = i - 1;
                btnPrevTabHelpAcc.Enabled = false;
                btnNextTabHelpAcc.Enabled = true;
            }
        }

        private void btnReturnFromAccManHelp_Click(object sender, EventArgs e)
        //Кнопка Вернуться в Менеджер аккаунтов
        {
            SetHelpDataToDefault();
            tcAccManHelp.SelectedTab = tpHelpAddAcc;
            _fam.Show();
            Hide();
        }

        #endregion

        private void RefreshHelpLists()
        //Обновление списков аккунтов справки
        {
            Sepo.CreateHelpAccNames();
            if (lbHelpModAccList.Items.Count > 0)
            {
                lbHelpModAccList.Items.Clear();
            }
            if (lbHelpDelAccList.Items.Count > 0)
            {
                lbHelpDelAccList.Items.Clear();
            }
            foreach (var str in Sepo.HelpAccNames)
            {
                lbHelpModAccList.Items.Add(str);
                lbHelpDelAccList.Items.Add(str);
            }
            btnHelpDelAllAcc.Enabled = lbHelpDelAccList.Items.Count > 1;
            lbHelpModAccList.ClearSelected();
            lbHelpDelAccList.ClearSelected();
            btnHelpAddAcc.Enabled = false;
            btnHelpModAcc.Enabled = false;
            btnHelpDelAcc.Enabled = false;
        }

        private void SetHelpDataToDefault()
        //Сброс по умолчанию
        {
            if (tcAccManHelp.SelectedTab == tpHelpAddAcc)
            {
                tbHelpAddAccName.Text = Sepo.DefAccName;
                tbHelpAddAccLogin.Text = Sepo.DefAccLogin;
                tbHelpAddAccPass.Text = Sepo.DefAccPass;
                btnHelpAddAcc.Enabled = false;
            }

            if (tcAccManHelp.SelectedTab != tpHelpModAcc) return;
            if (!lbHelpModAccList.Enabled)
            {
                lbHelpModAccList.Enabled = true;
                lbHelpModAccList.ClearSelected();
            }
            tbHelpModAccName.Text = Sepo.DefAccName;
            tbHelpModAccLogin.Text = Sepo.DefAccLogin;
            tbHelpModAccPass.Text = Sepo.DefAccPass;
            btnHelpModAcc.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        //Таймер
        {
            if (tcAccManHelp.SelectedTab == tpHelpDelAcc)
            {
                if (lbHelpDelAccList.Items.Contains("Справочный аккаунт")) return;
                Sepo.CreateHelpAccData("Справочный аккаунт", @"почта@что-то.нечто", @"#&*Бел_е6е_RDA*&#");
                RefreshHelpLists();
                timer1.Stop();
            }
            else if (tcAccManHelp.SelectedTab == tpHelpModAcc)
            {
                Sepo.DeleteHelpAcc("Справочный аккаунт");
                Sepo.ModifyRegHelpAccData("Справочный аккаунт", @"почта@что-то.нечто", @"#&*Бел_е6е_RDA*&#");
                RefreshHelpLists();
                timer1.Stop();
            }
        }

        #endregion

    }
}
