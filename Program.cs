namespace Agent_Program
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            while (true)
            {
                using (LoginSignup login = new LoginSignup())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break; // 로그인 취소하면 종료
                }

                var main = new Main();
                Application.Run(main);

                if (!main.IsLogout)
                    break; // 메인 폼이 그냥 닫힌 경우엔 앱 종료
            }

        }

    }
}