using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace frmLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Credentials credentials = new Credentials();
            

            if (textBoxPassword.Text != "" && textBoxPassword.Text == credentials.Password)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.UpdateLabelText($"Välkommen {credentials.Username}");
                form3.Show();
            }
            else
            {
                MessageBox.Show("Fel lösenord");
            }
        }

       
    }
}
