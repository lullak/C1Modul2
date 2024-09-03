namespace frmLogin
{
    public partial class Form1 : Form
    {
        public string username = "Dennis";
        public string password = "password";
     
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBoxEmail.Text != "" && username == "Dennis")
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
