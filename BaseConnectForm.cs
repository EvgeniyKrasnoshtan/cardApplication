using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardAplcation
{
    public partial class BaseConnectForm : Form
    {
        MySqlCommand command;
        public BaseConnectForm()
        {
            InitializeComponent();
        }

        private void BaseConnectionCheckButton_Click(object sender, EventArgs e)
        {
            string connetionResult = "Успешно";

            string str = "server=" + BaseServerNameTextBox.Text +
            ";user=" + BaseUserNameTextBox.Text +
            ";database=" + BaseNameTextBox.Text +
            ";port=" + BasePortTextBox.Text +
            ";password=" + BasePasswordTextBox.Text + ";" +
            ";Convert Zero Datetime=True;";

            using (MySqlConnection connection = new MySqlConnection(str))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    connetionResult = "Ошибка подключения. Код ошибки: " + ex.Message;
                }
                finally
                {
                    BaseConnectionCheckLabel.Text = connetionResult;
                }
            }
        }

        private void BaseConnectForm_Load(object sender, EventArgs e)
        {
            string connectString = "SELECT * FROM Connection;";

            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(true)))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Проверьте соединение с базой");
                    return;
                }
                command = new MySqlCommand(connectString, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    BaseServerNameTextBox.Text = reader["ServerName"].ToString();
                    BaseUserNameTextBox.Text = reader["UserName"].ToString();
                    BaseNameTextBox.Text = reader["DbName"].ToString();
                    BasePortTextBox.Text = reader["Port"].ToString();
                    BasePasswordTextBox.Text = reader["Password"].ToString();
                }

                
            }   
           
        }

        private void BaseConnetionSaveButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(true)))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Проверьте соединение с базой");
                    return;
                }

                string checkConnetion = "SELECT * FROM Connection";
                command = new MySqlCommand(checkConnetion, connection);
                MySqlDataReader reader = command.ExecuteReader();

                string insertConnetion;

                if (!reader.Read())
                {
                    insertConnetion = "INSERT Connection(ServerName, UserName, DbName, Port, Password)" +
                    "VALUES" +
                    "('" + BaseServerNameTextBox.Text + "'," +
                    "'" + BaseUserNameTextBox.Text + "'," +
                    "'" + BaseNameTextBox.Text + "'," +
                    "'" + BasePortTextBox.Text + "'," +
                    "'" + BasePasswordTextBox.Text + "');";

                    reader.Close();

                    command = new MySqlCommand(insertConnetion, connection);
                    command.ExecuteNonQuery();

                    
                }
                else
                {
                    string connectUpdate = "UPDATE Connection SET " +
                    "ServerName ='" + BaseServerNameTextBox.Text + "', " +
                    "UserName ='" + BaseUserNameTextBox.Text + "', " +
                    "DbName ='" + BaseNameTextBox.Text + "', " +
                    "Port ='" + BasePortTextBox.Text + "', " +
                    "Password ='" + BasePasswordTextBox.Text + "';";
                    reader.Close();
                    command = new MySqlCommand(connectUpdate, connection);
                    command.ExecuteNonQuery();
                }




            }
            Close();
        }

        private void BaseConnectionCancelButton_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }       
}           
