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
    public partial class UsersForm : Form
    {
       
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            GridRefresh();
        }
        private void GridRefresh()
        {
            string sql = "SELECT Login, Password, Privileges FROM Users;";
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
                finally
                {
                   
                }
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Login"].ToString(), reader["Password"].ToString(),
                                           reader["Privileges"].ToString());
                }

            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(true)))
                {
                    connection.Open();
                    string addUser = "INSERT Users(Login, Password, Privileges)" +
                        "VALUES('" + LoginTextBox.Text + "', '" + PasswordTextBox.Text + "', "+ checkBox1.Checked +");";
                    MySqlCommand command = new MySqlCommand(addUser, connection);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            dataGridView1.Rows.Clear();
            GridRefresh();
            ControlsClear();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            LoginTextBox.Text = selectedRow.Cells[0].Value.ToString();
            PasswordTextBox.Text = selectedRow.Cells[1].Value.ToString();
            checkBox1.Checked = bool.Parse(selectedRow.Cells[2].Value.ToString());

            dataGridView1.Enabled = false;
            AddButton.Enabled = false; 
            ChangeButton.Enabled = false;
            DeleteButton.Enabled = false;
            SaveButton.Enabled = true;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(true)))
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                connection.Open();
                string updateUser = "UPDATE Users SET Login = " + LoginTextBox.Text + ", " +
                    "Password = " + PasswordTextBox.Text + ", " +
                    "Privileges = " + checkBox1.Checked + " " +
                    "WHERE Login = " + selectedRow.Cells[0].Value.ToString() + " AND " +
                    "Password = " + selectedRow.Cells[1].Value.ToString() + " AND " +
                    "Privileges = " + bool.Parse(selectedRow.Cells[2].Value.ToString()) + ";";

                MySqlCommand command = new MySqlCommand(updateUser, connection);
                command.ExecuteNonQuery();
            }


            dataGridView1.Enabled = true;
            AddButton.Enabled = true;
            ChangeButton.Enabled = true;
            DeleteButton.Enabled = true;
            SaveButton.Enabled = false;
            dataGridView1.Rows.Clear();
            ControlsClear();
            GridRefresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetLocalString(true)))
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                connection.Open();
                string updateUser = "DELETE FROM Users " +
                    "WHERE Login = '" + selectedRow.Cells[0].Value.ToString() + "' AND " +
                    "Password = '" + selectedRow.Cells[1].Value.ToString() + "' AND " +
                    "Privileges = " + bool.Parse(selectedRow.Cells[2].Value.ToString()) + ";";

                MySqlCommand command = new MySqlCommand(updateUser, connection);
                command.ExecuteNonQuery();
            }
            dataGridView1.Rows.Clear();
            ControlsClear();
            GridRefresh();
        }

        private void ControlsClear()
        {
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            checkBox1.Checked = false;
        }
    }
}
