namespace frmLogin
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Credentials credentials = new Credentials();
            

           
            if (textBoxEmail.Text != "" && textBoxEmail.Text == credentials.Username)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Ange giltig epost eller telefonnummer.");
            }
        }
    }
}
