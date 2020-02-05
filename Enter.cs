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
    public partial class Enter : Form
    {
        public Enter()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (KeyTextBox.Text != BaseConnectString.GetLocalConnetion())
            {
              
                Close();
            }
            else
            {
                new AuthorizationForm(true).Show();
            }
        }

        private void Enter_Load(object sender, EventArgs e)
        {

        }
    }
}
