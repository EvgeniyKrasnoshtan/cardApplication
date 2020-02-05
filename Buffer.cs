//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.Entity;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace cardAplcation
//{
//    public partial class MainForm : Form
//    {
//        AuthorizationForm form;
//        int holderId;
//        int cardObjectId = -1;
//        List<string> policyCumPeriod = new List<string>();
//        List<string> policyCumType = new List<string>();
//        List<string> holderSex = new List<string>();

//        public MainForm(AuthorizationForm form, bool admin)
//        {
//            this.form = form;
//            InitializeComponent();
//            //Проверка на админа
//            if (!admin)
//            {
//                базаДанныхToolStripMenuItem.Visible = false;
//                опцииToolStripMenuItem.Visible = false;
//            }
//        }

//        public MainForm()
//        {
//            InitializeComponent();
//        }

//        private void ChangeCardDataButton_Click(object sender, EventArgs e)
//        {
//            string date = "";

//            if (cardObjectId == -1)
//            {
//                MessageBox.Show("Карта не выбрана!");
//                return;
//            }

//            if (CardBirthDatePicker.Text != "")
//            {
//                date = CardBirthDatePicker.Text.Substring(6, 4) + "-" + CardBirthDatePicker.Text.Substring(3, 2) + "-" + CardBirthDatePicker.Text.Substring(0, 2) + "'";
//            }

//            // Если картодержатель существует, то апдейтим информацию про него
//            if (holderId != 0)
//            {
//                string holderUpdate =
//                    "UPDATE net_list_card_holders " +
//                    "SET holderName='" + CardFIOTextBox.Text + "', " +
//                    "holderPhone='" + CardPhoneTextBox.Text + "', " +
//                    "holderBirthday='" + date +
//                    " WHERE Id='" + holderId + "';";

//                using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetString()))
//                {
//                    try
//                    {
//                        connection.Open();
//                    }
//                    catch
//                    {
//                        MessageBox.Show("Проверьте соединение с базой");
//                        return;
//                    }
//                    MySqlCommand command = new MySqlCommand(holderUpdate, connection);
//                    int result = command.ExecuteNonQuery();

//                    if (result != 0)
//                    {
//                        MessageBox.Show("Данные изменены");
//                    }

//                    connection.Close();

//                }
//            }
//            else if (holderId == 0)
//            {


//                string selectObjectIdMaxDiscounts = "SELECT MAX(objectId) FROM net_list_purse_discount";
//                string selectObjectIdMaxHolders = "SELECT MAX(objectId) FROM net_list_card_holders";

//                int maxObjectIdHolders;
//                int maxObjectIdDiscounts;

//                //Получение последнего objcetId 
//                using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetString()))
//                {
//                    try
//                    {
//                        connection.Open();
//                    }
//                    catch
//                    {
//                        MessageBox.Show("Проверьте соединение с базой");
//                        return;
//                    }

//                    MySqlCommand command = new MySqlCommand(selectObjectIdMaxHolders, connection);
//                    MySqlDataReader reader = command.ExecuteReader();
//                    reader.Read();
//                    maxObjectIdHolders = reader.GetInt32(0) + 1;

//                    reader.Close();

//                    command = new MySqlCommand(selectObjectIdMaxDiscounts, connection);
//                    reader = command.ExecuteReader();
//                    reader.Read();
//                    maxObjectIdDiscounts = reader.GetInt32(0) + 1;

//                    reader.Close();
//                    //reader.Dispose();

//                }

//                string holderInsert =
//                    "INSERT net_list_card_holders" +
//                    "(holderName," +
//                    "cardCount," +
//                    "firmId," +
//                    "holderSex," +
//                    "holderEmail," +
//                    "holderBirthday," +
//                    "objectId," +
//                    "objectType," +
//                    "objectStatus," +
//                    "creatorId," +
//                    "dtModify," +
//                    "holderPhone) " +
//                    "VALUES(" +
//                    "'" + CardFIOTextBox.Text + "'," +
//                    "0," +
//                    "2," +
//                    "'" + (holderSex.IndexOf(CardGenderComboBox.Text) + 4230) + "'," +
//                    "'" + CardEmailTextBox.Text + "'," +
//                    "'" + CardBirthDatePicker.Text + "'," +
//                    "'" + maxObjectIdHolders + "'," +
//                    "'" + 140 + "'," +
//                    "'" + 150 + "'," +
//                    "'" + 100 + "'," +
//                    "NOW()," +
//                    "'" + CardPhoneTextBox.Text + "');";

//                string cardUpdate =
//                    "UPDATE net_list_cards " +
//                    "SET holderId=" + maxObjectIdHolders + ", objectStatus=" + 150 + ",  objectType=" + 140 + ", firmId=" + 2 + " " +
//                    "WHERE cardSerial='" + CardNumberTextBox.Text + "' AND holderId=" + 0 + " AND firmId=" + 0 + ";";

//                string policyInsert =
//                    "INSERT net_list_purse_discount " +
//                    "(cardId, policyId, objectId, objectType, objectStatus, creatorId, dtModify) " +
//                    "VALUES(" + cardObjectId + "," + 10 + "," + maxObjectIdDiscounts + "," + 140 + "," + 150 + "," + 100 + "," + "NOW()), " +
//                    "(" + cardObjectId + "," + 12 + "," + ++maxObjectIdDiscounts + "," + 140 + "," + 150 + "," + 100 + "," + "NOW()), " +
//                    "(" + cardObjectId + "," + 15 + "," + ++maxObjectIdDiscounts + "," + 140 + "," + 150 + "," + 100 + "," + "NOW());";

//                using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetString()))
//                {
//                    try
//                    {
//                        connection.Open();
//                    }
//                    catch
//                    {
//                        MessageBox.Show("Проверьте соединение с базой");
//                        return;
//                    }

//                    MySqlCommand command = new MySqlCommand(holderInsert, connection);
//                    command.ExecuteNonQuery();

//                    command = new MySqlCommand(cardUpdate, connection);
//                    command.ExecuteNonQuery();

//                    command = new MySqlCommand(policyInsert, connection);
//                    command.ExecuteNonQuery();
//                }
//            }
//            ControlsClear();
//            ControlsEnable(false);
//        }



//        private void CardNumberButtonSearch_Click(object sender, EventArgs e)
//        {
//            if (CardNumberTextBox.Text == "")
//            {
//                MessageBox.Show("Введите номер карты");
//                return;
//            }
//            else if (CardNumberTextBox.Text.Length < 6)
//            {
//                CardNumberTextBox.Text = CardNumberTextBox.Text.PadLeft(6, '0');
//            }

//            string checkCard = "SELECT holderId, objectId FROM net_list_cards WHERE objectType = 140 AND objectStatus = 150 AND cardSerial = '" + CardNumberTextBox.Text + "';";

//            using (MySqlConnection connection = new MySqlConnection(BaseConnectString.GetString()))
//            {
//                try
//                {
//                    connection.Open();
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Хъюстон, у нас проблемы!");
//                    return;
//                }


//                MySqlCommand command = new MySqlCommand(checkCard, connection);
//                MySqlDataReader reader = command.ExecuteReader();

//                if (reader.Read())
//                {
//                    cardObjectId = reader.GetInt32("objectId");

//                    if (reader.GetInt32("holderId") != 0)
//                    {
//                        string getHolderData =
//                        "SELECT cardHold.holderName, cards.objectId, cardHold.holderSex, firms.firmName, cards.holderId, cardHold.holderEmail, cardHold.holderBirthday, cardHold.holderPhone, cards.cardSerial " +
//                        "FROM net_list_cards AS cards, net_list_card_firms AS firms, net_list_card_holders AS cardHold " +
//                        "WHERE firms.id = cardHold.firmId AND cardHold.objectType = 140 AND cards.holderId = cardHold.objectId AND cards.objectType = 140 AND " +
//                        "cards.cardSerial = '" + CardNumberTextBox.Text + "';";


//                        reader.Close();

//                        command = new MySqlCommand(getHolderData, connection);
//                        reader = command.ExecuteReader();

//                        reader.Read();

//                        CardFIOTextBox.Text = reader["holderName"].ToString();
//                        CardPhoneTextBox.Text = reader["holderPhone"].ToString();
//                        CardEmailTextBox.Text = reader["holderEmail"].ToString();
//                        CardFirmTextBox.Text = reader["firmName"].ToString();

//                        if (reader.GetMySqlDateTime("holderBirthday").IsValidDateTime)
//                        {
//                            CardBirthDatePicker.Text = reader.GetMySqlDateTime("holderBirthday").ToString();
//                        }
//                        else
//                        {
//                            //поставить дефолтное значение для даты, если невалидно
//                            //Изменить парсинг даты 
//                            CardBirthDatePicker.Text = "";
//                        }

//                        CardGenderComboBox.SelectedItem = holderSex[reader.GetInt32("holderSex") - 4230];
//                        holderId = reader.GetUInt16("holderId");

//                        string getCardDiscount = "SELECT policys.policyName, policys.policyDescription, policys.policyCumulationPeriod, policys.policyCumulationUnit " +
//                        "FROM net_list_cards AS cards, net_list_purse_discount AS discounts, net_list_policys AS policys " +
//                        "WHERE cards.objectId = discounts.cardId AND policys.objectId = discounts.policyId AND policys.objectType = 140 AND cards.objectType = 140 AND cards.cardSerial='" + CardNumberTextBox.Text + "';";

//                        reader.Close();
//                        command = new MySqlCommand(getCardDiscount, connection);
//                        reader = command.ExecuteReader();

//                        dataGridView1.Rows.Clear();

//                        while (reader.Read())
//                        {
//                            //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
//                            dataGridView1.Rows.Add(reader["policyName"].ToString(),
//                                                   reader["policyDescription"].ToString(),
//                                                   policyCumPeriod[reader.GetInt16("policyCumulationPeriod") - 280],
//                                                   policyCumType[reader.GetInt16("policyCumulationUnit") - 300]);
//                        }

//                        connection.Close();

//                    }
//                    else
//                    {
//                        DialogResult dialogResult = MessageBox.Show("К карте пользователь не привязан. Привязать нового пользователя к этой карте?", "Создание пользователя", MessageBoxButtons.YesNo);
//                        if (dialogResult == DialogResult.Yes)
//                        {
//                            ControlsEnable(true);
//                            ControlsClear();
//                        }
//                        else if (dialogResult == DialogResult.No)
//                        {
//                            ControlsClear();
//                            return;

//                        }
//                    }

//                }
//                else
//                {
//                    MessageBox.Show("Карта не найдена!");
//                    ControlsClear();
//                    return;
//                }

//            }

//        }

//        private void базаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            BaseConnectForm baseForm = new BaseConnectForm();
//            baseForm.Show();
//        }

//        private void сменаПользователяToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            //AuthorizationForm authForm = new AuthorizationForm(this);
//            form.Clear();
//            form.Show();
//            form = null;
//            this.Close();

//        }

//        private void ControlsEnable(bool trigger)
//        {
//            CardFIOTextBox.ReadOnly = !trigger;
//            CardFirmTextBox.ReadOnly = !trigger;
//            CardEmailTextBox.ReadOnly = !trigger;
//            CardPhoneTextBox.ReadOnly = !trigger;
//            CardCommentRichTextBox.ReadOnly = !trigger;
//            CardGenderComboBox.Enabled = trigger;
//            ChangeCardDataButton.Enabled = trigger;
//            CardBirthDatePicker.Enabled = trigger;
//        }

//        private void ControlsClear()
//        {
//            CardFIOTextBox.Clear();
//            CardFirmTextBox.Clear();
//            CardEmailTextBox.Clear();
//            CardPhoneTextBox.Clear();
//            CardCommentRichTextBox.Clear();
//            CardGenderComboBox.SelectedValue = holderSex[0];
//            CardBirthDatePicker.Value = DateTime.Now;
//            dataGridView1.Rows.Clear();
//        }

//        private void MainForm_Load(object sender, EventArgs e)
//        {
//            policyCumPeriod.Add("Не считать");
//            policyCumPeriod.Add("Всегда");
//            policyCumPeriod.Add("Разово");
//            policyCumPeriod.Add("Тек. неделя");
//            policyCumPeriod.Add("Прошлая неделя");
//            policyCumPeriod.Add("Тек. месяц");
//            policyCumPeriod.Add("Прошлый месяц");
//            policyCumPeriod.Add("Текущий квартал");
//            policyCumPeriod.Add("Прошлый квартал");
//            policyCumPeriod.Add("Текущий год");
//            policyCumPeriod.Add("Прошлый год");
//            policyCumPeriod.Add("Текущий день");
//            policyCumPeriod.Add("Прошлый день");
//            policyCumType.Add("Деньги");
//            policyCumType.Add("Объем");
//            holderSex.Add("Не указано");
//            holderSex.Add("Мужской");
//            holderSex.Add("Женский");
//            ControlsEnable(false);

//        }

//        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            if (form != null) this.form.Close();
//        }

//        private void CardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
//        {

//            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
//            {
//                e.Handled = true;
//            }

//        }

//        private void скидкиToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            PolicyBindForm firmForm = new PolicyBindForm();
//            firmForm.Show();
//        }

//        private void фирмыToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
