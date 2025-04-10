using Infrastructure;
namespace GUI
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
            if (!Config.ConfigFileExists())
            {
                using (var configForm = new frmConfig())
                {   
                    if (configForm.ShowDialog() != DialogResult.OK)
                    {
                        Application.Exit(); // or show again
                        return;
                    }
                }
                using (var loginForm = new frmLogin())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // If login is successful, show main form
                        Application.Run(new Home(new DTO.Employee()));
                    }
                    else
                    {
                        // User closed login or failed — exit
                        Application.Exit();
                    }
                }
            }
            else
            {
                Config.LoadConfig();
                using (var loginForm = new frmLogin())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // If login is successful, show main form
                        Application.Run(new Home(new DTO.Employee()));
                    }
                    else
                    {
                        // User closed login or failed — exit
                        Application.Exit();
                    }
                }
            }
           
            //Application.Run(new Home(new DTO.Employee()));
            //Application.Run(new frmLogin());
        }
    }
}