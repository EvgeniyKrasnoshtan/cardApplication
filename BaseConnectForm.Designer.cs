namespace cardAplcation
{
    partial class BaseConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseServerNameTextBox = new System.Windows.Forms.TextBox();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.BaseUserNameTextBox = new System.Windows.Forms.TextBox();
            this.BaseNameTextBox = new System.Windows.Forms.TextBox();
            this.BasePortTextBox = new System.Windows.Forms.TextBox();
            this.BasePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BaseConnectionCheckButton = new System.Windows.Forms.Button();
            this.BaseConnectionCheckLabel = new System.Windows.Forms.Label();
            this.BaseConnetionSaveButton = new System.Windows.Forms.Button();
            this.BaseConnectionCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BaseServerNameTextBox
            // 
            this.BaseServerNameTextBox.Location = new System.Drawing.Point(25, 18);
            this.BaseServerNameTextBox.Name = "BaseServerNameTextBox";
            this.BaseServerNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.BaseServerNameTextBox.TabIndex = 0;
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Location = new System.Drawing.Point(257, 21);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(83, 13);
            this.ServerNameLabel.TabIndex = 1;
            this.ServerNameLabel.Text = "Адрес сервера";
            // 
            // BaseUserNameTextBox
            // 
            this.BaseUserNameTextBox.Location = new System.Drawing.Point(25, 45);
            this.BaseUserNameTextBox.Name = "BaseUserNameTextBox";
            this.BaseUserNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.BaseUserNameTextBox.TabIndex = 2;
            // 
            // BaseNameTextBox
            // 
            this.BaseNameTextBox.Location = new System.Drawing.Point(25, 72);
            this.BaseNameTextBox.Name = "BaseNameTextBox";
            this.BaseNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.BaseNameTextBox.TabIndex = 3;
            // 
            // BasePortTextBox
            // 
            this.BasePortTextBox.Location = new System.Drawing.Point(25, 99);
            this.BasePortTextBox.Name = "BasePortTextBox";
            this.BasePortTextBox.Size = new System.Drawing.Size(226, 20);
            this.BasePortTextBox.TabIndex = 4;
            // 
            // BasePasswordTextBox
            // 
            this.BasePasswordTextBox.Location = new System.Drawing.Point(25, 126);
            this.BasePasswordTextBox.Name = "BasePasswordTextBox";
            this.BasePasswordTextBox.Size = new System.Drawing.Size(226, 20);
            this.BasePasswordTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя базы данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Порт для подключения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль для подключения";
            // 
            // BaseConnectionCheckButton
            // 
            this.BaseConnectionCheckButton.Location = new System.Drawing.Point(25, 172);
            this.BaseConnectionCheckButton.Name = "BaseConnectionCheckButton";
            this.BaseConnectionCheckButton.Size = new System.Drawing.Size(173, 34);
            this.BaseConnectionCheckButton.TabIndex = 10;
            this.BaseConnectionCheckButton.Text = "Проверить соединение";
            this.BaseConnectionCheckButton.UseVisualStyleBackColor = true;
            this.BaseConnectionCheckButton.Click += new System.EventHandler(this.BaseConnectionCheckButton_Click);
            // 
            // BaseConnectionCheckLabel
            // 
            this.BaseConnectionCheckLabel.AutoSize = true;
            this.BaseConnectionCheckLabel.Location = new System.Drawing.Point(257, 183);
            this.BaseConnectionCheckLabel.Name = "BaseConnectionCheckLabel";
            this.BaseConnectionCheckLabel.Size = new System.Drawing.Size(110, 13);
            this.BaseConnectionCheckLabel.TabIndex = 11;
            this.BaseConnectionCheckLabel.Text = "Ожидание проверки";
            // 
            // BaseConnetionSaveButton
            // 
            this.BaseConnetionSaveButton.Location = new System.Drawing.Point(12, 231);
            this.BaseConnetionSaveButton.Name = "BaseConnetionSaveButton";
            this.BaseConnetionSaveButton.Size = new System.Drawing.Size(173, 34);
            this.BaseConnetionSaveButton.TabIndex = 12;
            this.BaseConnetionSaveButton.Text = "Сохранить";
            this.BaseConnetionSaveButton.UseVisualStyleBackColor = true;
            this.BaseConnetionSaveButton.Click += new System.EventHandler(this.BaseConnetionSaveButton_Click);
            // 
            // BaseConnectionCancelButton
            // 
            this.BaseConnectionCancelButton.Location = new System.Drawing.Point(215, 231);
            this.BaseConnectionCancelButton.Name = "BaseConnectionCancelButton";
            this.BaseConnectionCancelButton.Size = new System.Drawing.Size(167, 34);
            this.BaseConnectionCancelButton.TabIndex = 13;
            this.BaseConnectionCancelButton.Text = "Отмена";
            this.BaseConnectionCancelButton.UseVisualStyleBackColor = true;
            this.BaseConnectionCancelButton.Click += new System.EventHandler(this.BaseConnectionCancelButton_Click);
            // 
            // BaseConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 277);
            this.Controls.Add(this.BaseConnectionCancelButton);
            this.Controls.Add(this.BaseConnetionSaveButton);
            this.Controls.Add(this.BaseConnectionCheckLabel);
            this.Controls.Add(this.BaseConnectionCheckButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BasePasswordTextBox);
            this.Controls.Add(this.BasePortTextBox);
            this.Controls.Add(this.BaseNameTextBox);
            this.Controls.Add(this.BaseUserNameTextBox);
            this.Controls.Add(this.ServerNameLabel);
            this.Controls.Add(this.BaseServerNameTextBox);
            this.Name = "BaseConnectForm";
            this.ShowIcon = false;
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.BaseConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BaseServerNameTextBox;
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.TextBox BaseUserNameTextBox;
        private System.Windows.Forms.TextBox BaseNameTextBox;
        private System.Windows.Forms.TextBox BasePortTextBox;
        private System.Windows.Forms.TextBox BasePasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BaseConnectionCheckButton;
        private System.Windows.Forms.Label BaseConnectionCheckLabel;
        private System.Windows.Forms.Button BaseConnetionSaveButton;
        private System.Windows.Forms.Button BaseConnectionCancelButton;
    }
}