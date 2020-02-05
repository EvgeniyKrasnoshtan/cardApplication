using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardAplcation
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(false)))
            {
                MySqlCommand command;
                MySqlDataReader reader;
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Проверьте подключение к базе и перезапустите программу.");
                    return;
                }

                string baseCreate = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'cardlocal'";
                command = new MySqlCommand(baseCreate, connection);
                reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    Application.Run(new Enter());
                }
                else
                {
                    Application.Run(new AuthorizationForm(false));
                }
            }

                    
        }
    }
}
