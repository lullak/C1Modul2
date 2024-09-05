namespace FormsFile2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdVisaFiler_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            string[] files = Directory.GetFiles(userInput);


            foreach (string file in files)
            {
                int position = file.IndexOf(@"\");
                file.Substring(position, + 1);
                lstFiles.Items.Add(file);
            }

        }
      
    }
}
