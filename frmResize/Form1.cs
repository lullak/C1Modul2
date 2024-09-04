namespace frmResize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Width = this.ClientSize.Width - 80;
            textBox1.Height = this.ClientSize.Height - 80;
            textBox1.Left = 40;
            textBox1.Top = 40;
        }
    }
}
