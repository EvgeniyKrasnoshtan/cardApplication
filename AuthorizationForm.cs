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
using System.Configuration;

namespace cardAplcation
{
    public partial class AuthorizationForm : Form
    {
        MySqlConnectionStringBuilder connectionStr = new MySqlConnectionStringBuilder();
        MySqlConnection connection;
        MySqlCommand command;
        bool what;
        public AuthorizationForm(bool what)
        {
            this.what = what;
            InitializeComponent();
        }
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(false)))
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Проверьте подключение к базе и перезапустите программу.");
                    Close();
                    return;
                }
                finally
                {
                    
                }
                string baseCreate = "CREATE DATABASE IF NOT EXISTS cardlocal";
                command = new MySqlCommand(baseCreate, connection);
                if (FingerPrint.Value() != BaseConnectString.val) Close();
                int result = command.ExecuteNonQuery();

                if (what)
                {
                    //firstEnter = true;
                    
                    MessageBox.Show("Base created!");

                    string useBase = "USE cardlocal;";


                    command = new MySqlCommand(useBase, connection);
                    command.ExecuteNonQuery();


                    string usersTable = "CREATE TABLE IF NOT EXISTS Users (" +
                               "User_id INT AUTO_INCREMENT PRIMARY KEY," +
                                "Login VARCHAR(255) NOT NULL," +
                                "Password VARCHAR(255)," +
                                "Privileges BOOLEAN NOT NULL)";

                    command = new MySqlCommand(usersTable, connection);
                    command.ExecuteNonQuery();

                    string firmTable = "CREATE TABLE IF NOT EXISTS Firms (" +
                               "id INT AUTO_INCREMENT PRIMARY KEY," +
                               "firmId INT NOT NULL," +
                               "firmName VARCHAR(255) NOT NULL," +
                               "firmNameExt VARCHAR(255) NOT NULL)";

                    command = new MySqlCommand(firmTable, connection);
                    command.ExecuteNonQuery();

                    string firmInsert = "INSERT Firms(firmId, firmName, firmNameExt) VALUES(2, '', '')";

                    command = new MySqlCommand(firmInsert, connection);
                    command.ExecuteNonQuery();

                    string connectionTable = "CREATE TABLE IF NOT EXISTS Connection (" +
                                              "Connection_id INT AUTO_INCREMENT PRIMARY KEY," +
                                              "ServerName VARCHAR(255) NOT NULL," +
                                              "UserName VARCHAR(255) NOT NULL," +
                                              "DbName VARCHAR(255) NOT NULL," +
                                              "Port VARCHAR(255) NOT NULL," +
                                              "Password VARCHAR(255) NOT NULL)";

                    command = new MySqlCommand(connectionTable, connection);
                    command.ExecuteNonQuery();

                    string policyTable = "CREATE TABLE IF NOT EXISTS Policys ( id INT AUTO_INCREMENT PRIMARY KEY," +
                                         "policyId INT UNIQUE NOT NULL)";

                    command = new MySqlCommand(policyTable, connection);
                    command.ExecuteNonQuery();

                    //string insertConnetion = "INSERT Connection(ServerName, UserName, DbName, Port, Password) VALUES ('', '', '', '', '');";

                    //command = new MySqlCommand(insertConnetion, connection);
                    //command.ExecuteNonQuery();

                }

            }



        }

        private void AuthorizationEnterButton_Click(object sender, EventArgs e)
        {
            if (AuthorizationLoginTextBox.Text == "" || AuthorizationPasswordTextBox.Text == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

          

            using (connection = new MySqlConnection(BaseConnectString.GetLocalString(true)))
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Проверьте подключение к базе и перезапустите программу.");
                    Close();
                    return;
                }

                //проверка наличия хотя бы одного юзера
                string checkUsers = "SELECT * FROM Users;";
                MySqlCommand commandUsers = new MySqlCommand(checkUsers, connection);
                MySqlDataReader readerUsers = commandUsers.ExecuteReader();


                //Если первый вход
                if (!readerUsers.Read())
                {
                    readerUsers.Close();
                    //Добавляем админа 
                    string addAdmin = "INSERT Users(Login, Password, Privileges)" +
                        "VALUES('" + AuthorizationLoginTextBox.Text + "', '" + AuthorizationPasswordTextBox.Text + "', TRUE);";

                    command = new MySqlCommand(addAdmin, connection);
                    int result = command.ExecuteNonQuery();

                    //Переходим на главное окно
                    if (result != 0)
                    {
                        MessageBox.Show("Учетная запись администратора создана");
                        MainForm main = new MainForm(this, true);
                        main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении администратора");

                    }

                }
                //Иначе проверяем наличие пользователя
                else
                {


                    string loginIn = "SELECT * FROM Users WHERE Login='" + AuthorizationLoginTextBox.Text + "' AND Password='" + AuthorizationPasswordTextBox.Text + "';";
                    readerUsers.Close();
                    command = new MySqlCommand(loginIn, connection);
                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {
                        reader.Read();
                        //Тут добавил проверку привелегий
                        MainForm main = new MainForm(this, reader.GetBoolean("Privileges"));

                        main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь или пароль не найдены!");
                        //return;

                    }
                }
            }



        }
        public void Clear()
        {
            AuthorizationLoginTextBox.Text = "";
            AuthorizationPasswordTextBox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
