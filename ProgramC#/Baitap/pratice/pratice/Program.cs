namespace pratice;

internal static class Program
{
    [STAThread]
    static void Main()
    {
<<<<<<< HEAD
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
=======
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
>>>>>>> df9c5f74b99e2cb01ee8f3e26b4419e643439da3
    }
}