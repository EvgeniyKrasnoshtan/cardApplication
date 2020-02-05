using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardAplcation
{
    public partial class PolicyBindForm : Form
    {
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MainForm mainForm;

        public PolicyBindForm()
        {
            InitializeComponent();
        }
        public PolicyBindForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void FirmBindForm_Load(object sender, EventArgs e)
        {
            GridRefresh();
            GridLocalRefresh();
        }

        

        private void GridRefresh()
        {
            string sql = "SELECT objectId, policyName, policyDescription, policyDiscounts FROM net_list_policys WHERE objectType = 140 AND objectStatus = 150";
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetString()))
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
                adapter = new MySqlDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    switch (i)
                    {
                        case 1:
                            dataGridView1.Columns[i].HeaderText = "Название";
                            break;
                        case 2:
                            dataGridView1.Columns[i].HeaderText = "Описание";
                            break;
                        case 3:
                            dataGridView1.Columns[i].HeaderText = "Скидки";
                            break;
                        default:
                            dataGridView1.Columns[i].Visible = false;
                            break;
                    }
                }
            }
            
        }//GridRefresh

        private void GridLocalRefresh()
        {
            string sql = "SELECT objectId, policyName, policyDescription, policyDiscounts FROM net_list_policys WHERE objectId IN (" + BaseConnectString.GetIds() + ") AND objectType = 140 AND objectStatus = 150;";
            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetString()))
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
                command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                

                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader["objectId"].ToString(), reader["policyName"].ToString(),
                                           reader["policyDescription"].ToString(), reader["policyDiscounts"].ToString());
                }
            }

        }

        private void FirmBindDeleteButton_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            //{

            //}
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
                
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    string deleteRow = "DELETE FROM policys WHERE policyId = " + row.Cells[0].Value.ToString() + ";";
                    command = new MySqlCommand(deleteRow, connection);
                    command.ExecuteNonQuery();
                } 
            }
            
            dataGridView2.Rows.Clear();
            GridLocalRefresh();
        }

        private void FimrBindAddButton_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    string insertRow = "INSERT policys (policyId) VALUES (" + row.Cells[0].Value.ToString() + ");";
                    command = new MySqlCommand(insertRow, connection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Duplicate entry"))
                        {
                            MessageBox.Show("Объект уже добален");
                        }
                    
                    }

                }
            }
            dataGridView2.Rows.Clear();
            GridLocalRefresh();
        }

        private void FirmBindForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        
    }
}
