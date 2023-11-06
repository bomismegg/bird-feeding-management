namespace FeedingManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new LoginForm());
=======
            Application.Run(new BirdManagementView());
>>>>>>> 29f54bb4f74efbabf8e052f959c0fd678a43b48c
        }
    }
}