using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLoginTxt
{
    public partial class frmLogin : Form
    {
        public string path = @"C:\Users\Birca\Desktop\Code\pmc\Modul2\frmLoginTxt\users.txt";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
       
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            frmRegister frm = new frmRegister();
            frm.Show();
            this.Hide();
            
        }
        public bool UserLogin()
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            using (StreamReader sr = new StreamReader(path))
            {
                string row;
                while ((row = sr.ReadLine()) != null)
                {
                    string[] strings = row.Split(",");
                    if (strings[0] == username && strings[1] == password)
                    {
                        MessageBox.Show("Du är nu inloggad!");
                        return true;
                    }
                }
            }
            MessageBox.Show("Felaktiga användarnamn eller lösenord");
            return false;
            
        }
    }
}
