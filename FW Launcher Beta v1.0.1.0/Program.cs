namespace FW_Launcher_Beta_v1._0._1._0
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Sepo.CreateRegDir();
            Sepo.CreateAndReadPauseTime();
            Sepo.CreateAndReadGamePath();
            Sepo.CreateAndReadAccsChoise();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain());
        }
    }
}
