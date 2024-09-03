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
            if (textBoxPassword.Text != "")
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.UpdateLabelText("afefergfegf");
                form3.Show();
            }
            else
            {
                MessageBox.Show("Ange giltig epost eller telefonnummer.");
            }
        }

       
    }
}
