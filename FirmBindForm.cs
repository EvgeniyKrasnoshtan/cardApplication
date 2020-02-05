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
    public partial class FirmBindForm : Form
    {
        public FirmBindForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FirmBindForm_Load(object sender, EventArgs e)
        {
            GridRefresh();
            DisplayLocalFirm();

        }

        private void GridRefresh()
        {
            string sql = "SELECT objectId, firmName, firmNameExt FROM net_list_card_firms WHERE objectType = 140 AND objectStatus = 150";
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
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    switch (i)
                    {
                        case 1:
                            dataGridView1.Columns[i].HeaderText = "Имя";
                            dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            break;
                        case 2:
                            dataGridView1.Columns[i].HeaderText = "Дополнительно";
                            dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            break;
                        default:
                            dataGridView1.Columns[i].Visible = false;
                            break;
                    }
                }
            }
        }

        private void DisplayLocalFirm()
        {
            string localFirm = "SELECT firmName, firmNameExt FROM Firms;";

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

                MySqlCommand command = new MySqlCommand(localFirm, connection);
                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();
                firmNameTextBox.Text = reader[0].ToString();
                firmNameExtTextBox.Text = reader[1].ToString();
                reader.Close();
            }
            
        }
        private void ChangeButton_Click_1(object sender, EventArgs e)
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

                    string insertRow = "UPDATE Firms SET firmId = " + row.Cells[0].Value.ToString() + ", firmName = '" + row.Cells[1].Value.ToString() + "', firmNameExt = '" + row.Cells[2].Value.ToString() + "';";
                    MySqlCommand command = new MySqlCommand(insertRow, connection);

                    command.ExecuteNonQuery();
                }
            }
            DisplayLocalFirm();
        }
    }
    }

