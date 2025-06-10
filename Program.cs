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

            while (true)
            {
                using (var loginForm = new LoginSignup())
                {
                    var loginResult = loginForm.ShowDialog();

                    if (loginResult != DialogResult.OK)
                        break; // 로그인 실패 또는 X로 닫으면 앱 종료
                }

                using (var mainForm = new Main())
                {
                    Application.Run(mainForm);

                    if (!mainForm.IsLogout)
                        break; // 로그아웃 의도 없이 그냥 창 닫으면 종료
                }
            }
        }

    }
}