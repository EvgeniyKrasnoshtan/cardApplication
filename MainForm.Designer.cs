using System.Windows.Forms;

namespace cardAplcation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ChangeCardDataButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.CardNumberButtonSearch = new System.Windows.Forms.Button();
            this.CardFIOTextBox = new System.Windows.Forms.TextBox();
            this.CardFIOLabel = new System.Windows.Forms.Label();
            this.CardBirthDateLabel = new System.Windows.Forms.Label();
            this.CardPhoneLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CardPhoneTextBox = new System.Windows.Forms.TextBox();
            this.CardCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CardBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CardEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CardGenderComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CardFirmTextBox = new System.Windows.Forms.TextBox();
            this.CardFirmLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.policyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyCumulationPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyCumulationUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.фирмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeCardDataButton
            // 
            this.ChangeCardDataButton.Location = new System.Drawing.Point(12, 430);
            this.ChangeCardDataButton.Name = "ChangeCardDataButton";
            this.ChangeCardDataButton.Size = new System.Drawing.Size(242, 48);
            this.ChangeCardDataButton.TabIndex = 10;
            this.ChangeCardDataButton.Text = "Создать";
            this.ChangeCardDataButton.UseVisualStyleBackColor = true;
            this.ChangeCardDataButton.Click += new System.EventHandler(this.ChangeCardDataButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПользователяToolStripMenuItem,
            this.базаДанныхToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сменаПользователяToolStripMenuItem
            // 
            this.сменаПользователяToolStripMenuItem.Name = "сменаПользователяToolStripMenuItem";
            this.сменаПользователяToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сменаПользователяToolStripMenuItem.Text = "Смена пользователя";
            this.сменаПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменаПользователяToolStripMenuItem_Click);
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            this.базаДанныхToolStripMenuItem.Click += new System.EventHandler(this.базаДанныхToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.скидкиToolStripMenuItem,
            this.фирмыToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // скидкиToolStripMenuItem
            // 
            this.скидкиToolStripMenuItem.Name = "скидкиToolStripMenuItem";
            this.скидкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.скидкиToolStripMenuItem.Text = "Скидки";
            this.скидкиToolStripMenuItem.Click += new System.EventHandler(this.скидкиToolStripMenuItem_Click);
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(12, 62);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(242, 20);
            this.CardNumberTextBox.TabIndex = 1;
            this.CardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTextBox_KeyPress);
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CardNumberLabel.Location = new System.Drawing.Point(72, 39);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(120, 20);
            this.CardNumberLabel.TabIndex = 5;
            this.CardNumberLabel.Text = "Номер карты";
            // 
            // CardNumberButtonSearch
            // 
            this.CardNumberButtonSearch.Location = new System.Drawing.Point(12, 88);
            this.CardNumberButtonSearch.Name = "CardNumberButtonSearch";
            this.CardNumberButtonSearch.Size = new System.Drawing.Size(242, 48);
            this.CardNumberButtonSearch.TabIndex = 2;
            this.CardNumberButtonSearch.Text = "Поиск";
            this.CardNumberButtonSearch.UseVisualStyleBackColor = true;
            this.CardNumberButtonSearch.Click += new System.EventHandler(this.CardNumberButtonSearch_Click);
            // 
            // CardFIOTextBox
            // 
            this.CardFIOTextBox.Location = new System.Drawing.Point(382, 87);
            this.CardFIOTextBox.Name = "CardFIOTextBox";
            this.CardFIOTextBox.Size = new System.Drawing.Size(242, 20);
            this.CardFIOTextBox.TabIndex = 4;
            // 
            // CardFIOLabel
            // 
            this.CardFIOLabel.AutoSize = true;
            this.CardFIOLabel.Location = new System.Drawing.Point(630, 90);
            this.CardFIOLabel.Name = "CardFIOLabel";
            this.CardFIOLabel.Size = new System.Drawing.Size(34, 13);
            this.CardFIOLabel.TabIndex = 8;
            this.CardFIOLabel.Text = "ФИО";
            // 
            // CardBirthDateLabel
            // 
            this.CardBirthDateLabel.AutoSize = true;
            this.CardBirthDateLabel.Location = new System.Drawing.Point(630, 66);
            this.CardBirthDateLabel.Name = "CardBirthDateLabel";
            this.CardBirthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.CardBirthDateLabel.TabIndex = 9;
            this.CardBirthDateLabel.Text = "Дата рождения";
            // 
            // CardPhoneLabel
            // 
            this.CardPhoneLabel.AutoSize = true;
            this.CardPhoneLabel.Location = new System.Drawing.Point(630, 116);
            this.CardPhoneLabel.Name = "CardPhoneLabel";
            this.CardPhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.CardPhoneLabel.TabIndex = 10;
            this.CardPhoneLabel.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Комментарий";
            // 
            // CardPhoneTextBox
            // 
            this.CardPhoneTextBox.Location = new System.Drawing.Point(382, 113);
            this.CardPhoneTextBox.Name = "CardPhoneTextBox";
            this.CardPhoneTextBox.Size = new System.Drawing.Size(242, 20);
            this.CardPhoneTextBox.TabIndex = 5;
            // 
            // CardCommentRichTextBox
            // 
            this.CardCommentRichTextBox.Location = new System.Drawing.Point(12, 163);
            this.CardCommentRichTextBox.Name = "CardCommentRichTextBox";
            this.CardCommentRichTextBox.Size = new System.Drawing.Size(242, 47);
            this.CardCommentRichTextBox.TabIndex = 9;
            this.CardCommentRichTextBox.Text = "";
            // 
            // CardBirthDatePicker
            // 
            this.CardBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CardBirthDatePicker.Location = new System.Drawing.Point(382, 60);
            this.CardBirthDatePicker.Name = "CardBirthDatePicker";
            this.CardBirthDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardBirthDatePicker.Size = new System.Drawing.Size(242, 20);
            this.CardBirthDatePicker.TabIndex = 3;
            // 
            // CardEmailTextBox
            // 
            this.CardEmailTextBox.Location = new System.Drawing.Point(382, 140);
            this.CardEmailTextBox.Name = "CardEmailTextBox";
            this.CardEmailTextBox.Size = new System.Drawing.Size(242, 20);
            this.CardEmailTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email";
            // 
            // CardGenderComboBox
            // 
            this.CardGenderComboBox.FormattingEnabled = true;
            this.CardGenderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Не указано"});
            this.CardGenderComboBox.Location = new System.Drawing.Point(382, 166);
            this.CardGenderComboBox.Name = "CardGenderComboBox";
            this.CardGenderComboBox.Size = new System.Drawing.Size(242, 21);
            this.CardGenderComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Пол";
            // 
            // CardFirmTextBox
            // 
            this.CardFirmTextBox.Location = new System.Drawing.Point(382, 194);
            this.CardFirmTextBox.Name = "CardFirmTextBox";
            this.CardFirmTextBox.Size = new System.Drawing.Size(242, 20);
            this.CardFirmTextBox.TabIndex = 8;
            // 
            // CardFirmLabel
            // 
            this.CardFirmLabel.AutoSize = true;
            this.CardFirmLabel.Location = new System.Drawing.Point(630, 197);
            this.CardFirmLabel.Name = "CardFirmLabel";
            this.CardFirmLabel.Size = new System.Drawing.Size(44, 13);
            this.CardFirmLabel.TabIndex = 21;
            this.CardFirmLabel.Text = "Фирма";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.policyName,
            this.policyDescription,
            this.policyCumulationPeriod,
            this.policyCumulationUnit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(612, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // policyName
            // 
            this.policyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.policyName.HeaderText = "Название скидки";
            this.policyName.Name = "policyName";
            this.policyName.ReadOnly = true;
            this.policyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // policyDescription
            // 
            this.policyDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.policyDescription.HeaderText = "Описание скидки";
            this.policyDescription.Name = "policyDescription";
            this.policyDescription.ReadOnly = true;
            this.policyDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // policyCumulationPeriod
            // 
            this.policyCumulationPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.policyCumulationPeriod.HeaderText = "Период расчета";
            this.policyCumulationPeriod.Name = "policyCumulationPeriod";
            this.policyCumulationPeriod.ReadOnly = true;
            // 
            // policyCumulationUnit
            // 
            this.policyCumulationUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.policyCumulationUnit.HeaderText = "Ед. изм. накопл.";
            this.policyCumulationUnit.Name = "policyCumulationUnit";
            this.policyCumulationUnit.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // фирмыToolStripMenuItem
            // 
            this.фирмыToolStripMenuItem.Name = "фирмыToolStripMenuItem";
            this.фирмыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.фирмыToolStripMenuItem.Text = "Фирмы";
            this.фирмыToolStripMenuItem.Click += new System.EventHandler(this.фирмыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CardFirmLabel);
            this.Controls.Add(this.CardFirmTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardGenderComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardEmailTextBox);
            this.Controls.Add(this.CardBirthDatePicker);
            this.Controls.Add(this.CardCommentRichTextBox);
            this.Controls.Add(this.CardPhoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CardPhoneLabel);
            this.Controls.Add(this.CardBirthDateLabel);
            this.Controls.Add(this.CardFIOLabel);
            this.Controls.Add(this.CardFIOTextBox);
            this.Controls.Add(this.CardNumberButtonSearch);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.ChangeCardDataButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeCardDataButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Button CardNumberButtonSearch;
        private System.Windows.Forms.TextBox CardFIOTextBox;
        private System.Windows.Forms.Label CardFIOLabel;
        private System.Windows.Forms.Label CardBirthDateLabel;
        private System.Windows.Forms.Label CardPhoneLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardPhoneTextBox;
        private System.Windows.Forms.RichTextBox CardCommentRichTextBox;
        private System.Windows.Forms.DateTimePicker CardBirthDatePicker;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователяToolStripMenuItem;
        private System.Windows.Forms.TextBox CardEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CardGenderComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CardFirmTextBox;
        private System.Windows.Forms.Label CardFirmLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn policyName;
        private DataGridViewTextBoxColumn policyDescription;
        private DataGridViewTextBoxColumn policyCumulationPeriod;
        private DataGridViewTextBoxColumn policyCumulationUnit;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private ToolStripMenuItem скидкиToolStripMenuItem;
        private ToolStripMenuItem фирмыToolStripMenuItem;
    }
}

