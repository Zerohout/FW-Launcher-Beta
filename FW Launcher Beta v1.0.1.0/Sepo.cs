namespace FW_Launcher_Beta_v1._0._1._0
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Win32;
    internal class Sepo
    {
        public static string DefAccName = "Имя аккаунта";
        public static string DefAccLogin = "Логин (почта)";
        public static string DefAccPass = "Пароль";
        public static string DefGamePath = @"C:\";
        public static string RAccName = "";
        public static string RAccLogin = "";
        public static string RAccPass = "";
        public static string RHelpAccName = "";
        public static string RHelpAccLogin = "";
        public static string RHelpAccPass = "";
        public static string RGamePath = "";
        public static string BeginKeyName = @"Software\Sepo";
        public static string RegKeyName = @"Software\Sepo\FW Launcher Beta";
        public static string RegAccData = @"Software\Sepo\FW Launcher Beta\AccData";
        public static string RegParamData = @"Software\Sepo\FW Launcher Beta\ParamData";
        public static string RegHelpData = @"Software\Sepo\FW Launcher Beta\HelpData";
        public static string RegHelpAccData = @"Software\Sepo\FW Launcher Beta\HelpData\HelpAccData";
        public static string VPathGame = "Путь до игры: ";
        public static string VNotExist = "Отстутствует";
        public static int DefPauseStart = 10;
        public static int DefPauseLogin = 1000;
        public static int DefPauseClose = 20;
        public static int RPauseStart;
        public static int RPauseLogin;
        public static int RPauseClose;
        public static List<string> AccNames = new List<string>();
        public static List<string> AccLogins = new List<string>();
        public static List<string> SelAccs = new List<string>();
        public static List<string> RSelAccs = new List<string>();
        public static List<string> RSelAccLogins = new List<string>();
        public static List<string> RSelAccPass = new List<string>();
        public static List<string> HelpAccNames = new List<string>();
        public static List<string> SavedSelAccs = new List<string>();
        public static bool SaveAccChoise;



        #region Не работающий прототип двумерного массива со всеми данными всех аккаунтов

        //static public List<string> accData = new List<string>();
        //static public string[,] fullAccData = new string[20, 3];
        //static public List<List<string>> fullAccData = new List<List<string>>();

        //static public void CreateFullDataFiles() 
        ////Создание файлов (fullAccData, accNames, accPasses) 
        //{
        //    RegistryKey rk = null;
        //    try
        //    {
        //        rk = Registry.CurrentUser.OpenSubKey(regAccData);
        //        if (rk != null)
        //        {
        //            int numAcc = 0;
        //            int numAccData = 0;
        //            if (accNames.Count > 0) accNames.Clear();
        //            if (accLogins.Count > 0) accLogins.Clear();
        //            if (fullAccData != null) fullAccData = null;
        //            accNames.AddRange(rk.GetSubKeyNames());
        //            //fullAccData.Add(new List<string>());
        //            try
        //            {
        //                foreach (string str in accNames)
        //                {
        //                    fullAccData[numAcc, 0] = ((string)rk.GetValue("\\" + str + "\\" + "AccName"));
        //                    //numAccData++;

        //                    fullAccData[numAcc, 1] = ((string)rk.GetValue("\\" + str + "\\" + "AccLogin"));
        //                    numAccData++;
        //                    fullAccData[numAcc, 2] = ((string)rk.GetValue("\\" + str + "\\" + "AccPass"));
        //                    numAcc++;
        //                    numAccData = 0;
        //                    accLogins.Add((string)rk.GetValue("\\" + str + "\\" + "AccLogin"));
        //                }
        //            }
        //            catch (TypeInitializationException ex)
        //            {

        //                Console.WriteLine(ex.InnerException);
        //            }
        //        }
        //    }
        //    finally
        //    {
        //        if (rk != null) rk.Close();

        //    }
        //}

        #endregion

        public static void CreateRegDir()
        //Создание разделов программы (основной, данные аккаунтов, данные настроек) в реестре
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegKeyName);
                rk = Registry.CurrentUser.CreateSubKey(RegAccData);
                rk = Registry.CurrentUser.CreateSubKey(RegParamData);
                rk = Registry.CurrentUser.CreateSubKey(RegHelpData);
                if (rk == null)
                {
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        #region Справка Менеджера аккаунтов

        public static void CreateHelpAccData(string helpAccName, string helpAccLogin, string helpAccPass)
        //Запись УКАЗАННЫХ данных АККАУНТА СПРАВКИ в РЕЕСТРЕ
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegHelpAccData + "\\" + helpAccName);
                if (rk == null) return;
                rk.SetValue("HelpAccName", helpAccName);
                rk.SetValue("HelpAccLogin", helpAccLogin);
                rk.SetValue("HelpAccPass", helpAccPass);
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void ReadHelpAccData(string helpAccName)
        //Чтение данных УКАЗАННОГО АККАУНТА СПРАВКИ  из РЕЕСТРА в переменные (rHelpAcc)
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegHelpAccData + "\\" + helpAccName);
                if (rk == null) return;
                RHelpAccName = (string)rk.GetValue("HelpAccName");
                RHelpAccLogin = (string)rk.GetValue("HelpAccLogin");
                RHelpAccPass = (string)rk.GetValue("HelpAccPass");
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void ModifyRegHelpAccData(string helpAccName, string helpDataName, string helpDataValue)
        //Изменение данных АККАУНТА СПРАВКИ в РЕЕСТРЕ
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegHelpAccData + "\\" + helpAccName);
                rk?.SetValue(helpDataName, helpDataValue);
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void CreateHelpAccNames()
        //Получение СПИСКА созданных АККАУНТОВ СПРАВКИ из РЕЕСТРА
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegHelpAccData);
                if (rk == null) return;
                if (rk.SubKeyCount <= 0) return;
                if (HelpAccNames.Count > 0)
                {
                    HelpAccNames.Clear();
                }
                HelpAccNames.AddRange(rk.GetSubKeyNames());
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void DeleteHelpAcc(string helpAccName)
        //Удаление УКАЗАННОГО АКАУНТА СПРАВКИ из РЕЕСТРА
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegHelpAccData);
                rk?.DeleteSubKey(helpAccName);
            }
            finally
            {
                rk?.Close();
            }
        }

        #endregion

        #region Менеджер аккаунтов

        public static void CreateAccData(string accName, string accLogin, string accPass)
        //Запись УКАЗАННЫХ данных АККАУНТА в РЕЕСТР
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegAccData + "\\" + accName);
                if (rk == null) return;
                rk.SetValue("AccName", accName);
                rk.SetValue("AccLogin", accLogin);
                rk.SetValue("AccPass", accPass);
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void ReadAccData(string accName)
        //Чтение данных УКАЗАННОГО АККАУНТА из РЕЕСТРА в переменные (rAcc)
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegAccData + "\\" + accName);
                if (rk == null) return;
                RAccName = (string)rk.GetValue("AccName");
                RAccLogin = (string)rk.GetValue("AccLogin");
                RAccPass = (string)rk.GetValue("AccPass");
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void ModifyRegAccData(string accName, string dataName, string dataValue)
        //Изменение данных АККАУНТА в РЕЕСТРЕ
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegAccData + "\\" + accName);
                rk?.SetValue(dataName, dataValue);
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void CreateAccNames()
        //Получение СПИСКА всех созданных АККАУНТОВ из РЕЕСТРА
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegAccData);
                if (rk == null) return;
                if (rk.SubKeyCount <= 0) return;
                if (AccNames.Count > 0)
                {
                    AccNames.Clear();
                }
                AccNames.AddRange(rk.GetSubKeyNames());
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void CreateSelAccs(List<string> selAccs)
        //Создание значений в РЕЕСТРЕ с выбранными АККАУНТАМИ из СПИСКА 
        {
            RefreshSelAccs();
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegParamData + "\\" + "SelAccs");
                if (rk == null) return;
                foreach (var str in selAccs)
                {
                    rk.SetValue(str, str);
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void ReadSelAccs()
        //Чтение выбранных АККАУНТОВ из РЕЕСТРА в СПИСОК 
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegParamData + "\\" + "SelAccs");
                if (rk == null) return;
                if (RSelAccs.Count > 0)
                {
                    RSelAccs.Clear();
                }

                if (RSelAccLogins.Count > 0)
                {
                    RSelAccLogins.Clear();
                }

                if (RSelAccPass.Count > 0)
                {
                    RSelAccPass.Clear();
                }

                RSelAccs.AddRange(rk.GetValueNames());

                foreach (var str in RSelAccs)
                {
                    var rks = Registry.CurrentUser.OpenSubKey(RegAccData + "\\" + str);
                    RSelAccLogins.Add((string)rks?.GetValue("AccLogin"));
                    RSelAccPass.Add((string)rks?.GetValue("AccPass"));
                    rks?.Close();
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void RefreshSelAccs()
        //Удалить данные о ВЫБРАННЫХ АККАУНТАХ изи РЕЕСТРА
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegParamData);
                if (rk == null) return;
                try
                {
                    rk.DeleteSubKey("SelAccs");
                }
                catch
                {
                    rk.CreateSubKey("SelAccs");
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void DeleteAcc(string accName)
        //Удаление АКАУНТА из РЕЕСТРА
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegAccData);
                rk?.DeleteSubKey(accName);
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void ClearAccDataLists()
        //Очистка хранящихся данных АККАУНТА
        {
            AccNames.Clear();
            AccLogins.Clear();
        }

        public static void DeleteAllAccRegData()
        //Удалить ВСЕ АККАУНТЫ и их данные из РЕЕСТРА
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegKeyName);
                rk?.DeleteSubKeyTree("AccData");
            }
            finally
            {
                rk?.Close();
            }
        }

        #endregion

        #region Настройки

        public static void CreateAndReadGamePath()
        //Создание и чтение пути игры в переменную rGamePath
        {
            RegistryKey rk = null;
            var temp = "";
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegParamData);
                if (rk == null) return;
                try
                {
                    temp = rk.GetValue("GamePath").ToString();
                }
                catch
                {
                    CreateParamData("GamePath", DefGamePath);
                    temp = DefGamePath;
                }
                finally
                {
                    RGamePath = temp;
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void CreateAndReadAccsChoise()
        //Создание и чтение статуса сохранения выбранных аккаунтов
        {
            RegistryKey rk = null;
            var temp = false;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegParamData);
                if (rk == null) return;
                try
                {
                    temp = Convert.ToBoolean(rk.GetValue("SaveChoise"));
                }
                catch
                {
                    CreateParamData("SaveChoise", false.ToString());
                }
                finally
                {
                    SaveAccChoise = temp;
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void CreateAndReadPauseTime()
        //Создание и чтение данных ПАУЗЫ из РЕЕСТРА в переменные (rPause)
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegParamData);
                if (rk == null) return;
                if (Convert.ToInt32(rk.GetValue("PauseStart")) < 1)
                {
                    CreateParamData("PauseStart", DefPauseStart.ToString());
                    CreateParamData("PauseLogin", DefPauseLogin.ToString());
                    CreateParamData("PauseClose", DefPauseClose.ToString());
                    RPauseStart = DefPauseStart;
                    RPauseLogin = DefPauseLogin;
                    RPauseClose = DefPauseClose;
                }
                else
                {
                    RPauseStart = Convert.ToInt32(rk.GetValue("PauseStart"));
                    RPauseLogin = Convert.ToInt32(rk.GetValue("PauseLogin"));
                    RPauseClose = Convert.ToInt32(rk.GetValue("PauseClose"));
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void ReadGamePath()
        //Чтение пути игры
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegParamData);
                if (rk != null)
                {
                    RGamePath = (string)rk.GetValue("GamePath");
                }
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void CreateParamData(string paramName, string paramValue)
        //Создание КЛЮЧА с параметрами программы в РЕЕСТРЕ
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegParamData);
                rk?.SetValue(paramName, paramValue);
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void DeleteParamValue(string valName)
        //Удаление значения заданного ПАРАМЕТРА программы из РЕЕСТРА
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegParamData);
                rk?.DeleteValue(valName);
            }
            finally
            {
                rk?.Close();
            }
        }

        public static void DeleteAllRegData()
        //Подготовка к ПОЛНОМУ УДАЛЕНИЮ программы
        {
            RegistryKey rk = null;
            RegistryKey rks = null;
            try
            {
                rks = Registry.CurrentUser.CreateSubKey("Software");
                rk = Registry.CurrentUser.CreateSubKey(BeginKeyName);
                if (rk == null) return;
                var temp = new List<string>();
                temp.AddRange(rk.GetSubKeyNames());
                if (temp.Count < 2)
                {
                    rks?.DeleteSubKeyTree("Sepo");
                }
                else if (temp.Count > 1)
                {
                    rk.DeleteSubKeyTree("FW Launcher Beta");
                }
            }
            finally
            {
                rk?.Close();

                rks?.Close();
            }
        }

        #endregion







    }
}
