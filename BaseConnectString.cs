using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace cardAplcation
{
    static class BaseConnectString
    {
        
        public static string GetString()
        {
            
            MySqlConnection connection;
            MySqlCommand command;

            string connectString = "SELECT * FROM Connection;";
            connection = new MySqlConnection(GetLocalString(true));
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Проверьте соединение с базой");
            }

            command = new MySqlCommand(connectString, connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Строка подключения к базе отсутствует!");
                return "";
            }

            string str = "server=" + reader["ServerName"].ToString() +
            ";user=" + reader["UserName"].ToString() +
            ";database=" + reader["DbName"].ToString() +
            ";port=" + reader["Port"].ToString() +
            ";password=" + reader["Password"].ToString() + ";" +
            ";Convert Zero Datetime=True;";

            connection.Close();

            return str;

        }
        public static string GetIds()
        {
            MySqlCommand command;
            string ids = "";
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(true)))
            {

                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Проверьте соединение с базой");
                    return "-1";
                }

                string getPolicysId = "SELECT * FROM Policys";
                command = new MySqlCommand(getPolicysId, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ids += reader["policyId"].ToString() + ',';
                }
                ids = ids.TrimEnd(',');
                if (ids == "") ids = "-1";


            }
            return ids;
        }
        public static string val = "C3CB-F942-05C1-8BCA-7E2A-4A31-A922-F617";
        public static string GetLocalString(bool baseCreated)
        {
            MySqlConnectionStringBuilder connectionStr = new MySqlConnectionStringBuilder();
            string connectString;

            connectionStr.Server = "localhost"; 
            connectionStr.Port = 3306;
            connectionStr.UserID = "root";
            connectionStr.Password = "1234521";
            if (baseCreated) connectionStr.Database = "cardlocal";

            connectString = connectionStr.GetConnectionString(true);

            return connectString;

        }

        public static string GetLocalConnetion()
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(DateTime.Now.Date.ToString().Split(' ')[0].ToString()));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

    }
}
