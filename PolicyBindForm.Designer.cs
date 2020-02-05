namespace cardAplcation
{
    partial class PolicyBindForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirmBindDeleteButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyDescriprion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyDiscounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FimrBindAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(418, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(383, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirmBindDeleteButton
            // 
            this.FirmBindDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.FirmBindDeleteButton.ForeColor = System.Drawing.Color.Red;
            this.FirmBindDeleteButton.Location = new System.Drawing.Point(368, 12);
            this.FirmBindDeleteButton.Name = "FirmBindDeleteButton";
            this.FirmBindDeleteButton.Size = new System.Drawing.Size(44, 67);
            this.FirmBindDeleteButton.TabIndex = 1;
            this.FirmBindDeleteButton.Text = ">";
            this.FirmBindDeleteButton.UseVisualStyleBackColor = true;
            this.FirmBindDeleteButton.Click += new System.EventHandler(this.FirmBindDeleteButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.policyName,
            this.policyDescriprion,
            this.policyDiscounts});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(350, 302);
            this.dataGridView2.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // policyName
            // 
            this.policyName.HeaderText = "Название";
            this.policyName.Name = "policyName";
            this.policyName.ReadOnly = true;
            // 
            // policyDescriprion
            // 
            this.policyDescriprion.HeaderText = "Описание";
            this.policyDescriprion.Name = "policyDescriprion";
            this.policyDescriprion.ReadOnly = true;
            // 
            // policyDiscounts
            // 
            this.policyDiscounts.HeaderText = "Скидки";
            this.policyDiscounts.Name = "policyDiscounts";
            this.policyDiscounts.ReadOnly = true;
            // 
            // FimrBindAddButton
            // 
            this.FimrBindAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.3F);
            this.FimrBindAddButton.ForeColor = System.Drawing.Color.Lime;
            this.FimrBindAddButton.Location = new System.Drawing.Point(368, 247);
            this.FimrBindAddButton.Name = "FimrBindAddButton";
            this.FimrBindAddButton.Size = new System.Drawing.Size(44, 67);
            this.FimrBindAddButton.TabIndex = 3;
            this.FimrBindAddButton.Text = "<";
            this.FimrBindAddButton.UseVisualStyleBackColor = true;
            this.FimrBindAddButton.Click += new System.EventHandler(this.FimrBindAddButton_Click);
            // 
            // PolicyBindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 332);
            this.Controls.Add(this.FimrBindAddButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.FirmBindDeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PolicyBindForm";
            this.ShowIcon = false;
            this.Text = "Привязка скидок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirmBindForm_FormClosed);
            this.Load += new System.EventHandler(this.FirmBindForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FirmBindDeleteButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button FimrBindAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyDescriprion;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyDiscounts;
    }
}