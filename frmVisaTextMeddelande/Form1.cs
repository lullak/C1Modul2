namespace frmVisaTextMeddelande
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdVisaMeddelande_Click(object sender, EventArgs e)
        {
            string textBox1 = txtTextruta1.Text;
            string textBox2 = txtTextruta2.Text;

            MessageBox.Show($"{textBox1} {textBox2}");
        }
    }
}
