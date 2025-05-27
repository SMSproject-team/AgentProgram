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

            using (LoginSignup login = new LoginSignup())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Main());
                }
            }
        }

    }
}