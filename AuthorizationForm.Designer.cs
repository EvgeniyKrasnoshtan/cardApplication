namespace cardAplcation
{
    partial class AuthorizationForm
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
            this.AuthorizationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AuthorizationLoginTextBox = new System.Windows.Forms.TextBox();
            this.AuthorizationLoginLabel = new System.Windows.Forms.Label();
            this.AuthorizationPasswordLabel = new System.Windows.Forms.Label();
            this.AuthorizationEnterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorizationPasswordTextBox
            // 
            this.AuthorizationPasswordTextBox.Location = new System.Drawing.Point(12, 84);
            this.AuthorizationPasswordTextBox.MaxLength = 14;
            this.AuthorizationPasswordTextBox.Name = "AuthorizationPasswordTextBox";
            this.AuthorizationPasswordTextBox.PasswordChar = '*';
            this.AuthorizationPasswordTextBox.Size = new System.Drawing.Size(260, 20);
            this.AuthorizationPasswordTextBox.TabIndex = 2;
            // 
            // AuthorizationLoginTextBox
            // 
            this.AuthorizationLoginTextBox.Location = new System.Drawing.Point(12, 37);
            this.AuthorizationLoginTextBox.Name = "AuthorizationLoginTextBox";
            this.AuthorizationLoginTextBox.Size = new System.Drawing.Size(260, 20);
            this.AuthorizationLoginTextBox.TabIndex = 1;
            // 
            // AuthorizationLoginLabel
            // 
            this.AuthorizationLoginLabel.AutoSize = true;
            this.AuthorizationLoginLabel.Location = new System.Drawing.Point(12, 21);
            this.AuthorizationLoginLabel.Name = "AuthorizationLoginLabel";
            this.AuthorizationLoginLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorizationLoginLabel.TabIndex = 2;
            this.AuthorizationLoginLabel.Text = "Логин";
            // 
            // AuthorizationPasswordLabel
            // 
            this.AuthorizationPasswordLabel.AutoSize = true;
            this.AuthorizationPasswordLabel.Location = new System.Drawing.Point(12, 68);
            this.AuthorizationPasswordLabel.Name = "AuthorizationPasswordLabel";
            this.AuthorizationPasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.AuthorizationPasswordLabel.TabIndex = 3;
            this.AuthorizationPasswordLabel.Text = "Пароль";
            // 
            // AuthorizationEnterButton
            // 
            this.AuthorizationEnterButton.Location = new System.Drawing.Point(12, 124);
            this.AuthorizationEnterButton.Name = "AuthorizationEnterButton";
            this.AuthorizationEnterButton.Size = new System.Drawing.Size(260, 51);
            this.AuthorizationEnterButton.TabIndex = 3;
            this.AuthorizationEnterButton.Text = "Вход";
            this.AuthorizationEnterButton.UseVisualStyleBackColor = true;
            this.AuthorizationEnterButton.Click += new System.EventHandler(this.AuthorizationEnterButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AuthorizationEnterButton);
            this.Controls.Add(this.AuthorizationPasswordLabel);
            this.Controls.Add(this.AuthorizationLoginLabel);
            this.Controls.Add(this.AuthorizationLoginTextBox);
            this.Controls.Add(this.AuthorizationPasswordTextBox);
            this.Name = "AuthorizationForm";
            this.ShowIcon = false;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AuthorizationPasswordTextBox;
        private System.Windows.Forms.TextBox AuthorizationLoginTextBox;
        private System.Windows.Forms.Label AuthorizationLoginLabel;
        private System.Windows.Forms.Label AuthorizationPasswordLabel;
        private System.Windows.Forms.Button AuthorizationEnterButton;
        private System.Windows.Forms.Button button1;
    }
}