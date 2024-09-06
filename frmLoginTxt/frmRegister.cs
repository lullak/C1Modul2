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
    public partial class frmRegister : Form
    {
        public string path = @"C:\Users\Birca\Desktop\Code\pmc\Modul2\frmLoginTxt\users.txt";
        public frmRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        public void UserRegister()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"{}{}");
            }
        }
    }
}
