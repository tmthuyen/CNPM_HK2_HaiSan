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
                using (frmConfig configForm = new frmConfig())
                {   
                    if (configForm.ShowDialog() != DialogResult.OK)
                    {
                        Application.Exit(); 
                        return;
                    }
                }
                
            }
            
            try
            {
                Config.LoadConfig();
                Application.Run(new frmLogin());
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return; 
            }
            
            
           
            //Application.Run(new Home(new DTO.Employee()));
            //Application.Run(new frmLogin());
        }
    }
}