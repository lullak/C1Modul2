namespace FormsFile2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdVisaFiler_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            if (Directory.Exists(userInput))
            {
                lstFiles.Items.Clear();
                string[] files = Directory.GetFiles(userInput);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    lstFiles.Items.Add(fileName);
                }
            }
            else
            {
                MessageBox.Show("Filadresen finns inte.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                string directoryPath = textBox1.Text;
                string fileName = lstFiles.SelectedItem.ToString();
                string filePath = Path.Combine(directoryPath, fileName);

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(textBox2.Text);
                }
            }
            else
            {
                MessageBox.Show("Välj en fil från listan.");
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                string directoryPath = textBox1.Text;
                string fileName = lstFiles.SelectedItem.ToString();
                string filePath = Path.Combine(directoryPath, fileName);

                if (File.Exists(filePath))
                {
                    textBox2.Text = File.ReadAllText(filePath);
                }
                else
                {
                    MessageBox.Show("Filen kunde inte öppnas.");
                }
            }
            else
            {
                MessageBox.Show("Välj en fil från listan.");
            }
        }
    }
}