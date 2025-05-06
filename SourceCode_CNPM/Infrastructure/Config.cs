using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infrastructure
{
    public static class Config
    {
        public static string? Mode { get; private set; }
        public static string? ServerName { get; private set; }
        public static string? DatabaseName { get; private set; }
        public static string? Username { get; private set; }
        public static string? Password { get; private set; }

       
        public static bool ConfigFileExists()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");
            return File.Exists(path);
        }
        public static void WriteToFile(string[] lines)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");

            try
            {
                File.WriteAllText(path, string.Join(Environment.NewLine, lines));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing config: " + ex.Message);
            }
        }
        public static void LoadConfig()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");

            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException("Configuration file not found.", configPath);
            }
                

            string[] lines = File.ReadAllLines(configPath);

            if (lines.Length < 3)
                throw new Exception("Configuration file does not have enough lines.");

            Mode = lines[0].Trim().ToLower();

            if (Mode == "windows")
            {
                ServerName = lines[1].Trim();
                DatabaseName = lines[2].Trim();
                Username = null;
                Password = null;
            }
            else if (Mode == "server")
            {
                if (lines.Length < 5)
                    throw new Exception("Configuration file missing username or password in 'server' mode.");

                ServerName = lines[1].Trim();
                DatabaseName = lines[2].Trim();
                Username = lines[3].Trim();
                Password = lines[4].Trim();
            }
            else
            {
                throw new Exception("Invalid mode in config file. Use 'windows' or 'server' as the first line.");
            }
            //thử connect database
        }
    }
}
