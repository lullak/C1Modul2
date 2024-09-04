namespace frmAdressBok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbMaritialStatus.Items.AddRange(new object[] { "Gift", "Ogift", "Uppgift saknas" });
        }

        private void btnCmdCheck_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" &&  txtSurname.Text != "" && txtEmail.Text != "" && txtPhoneNumber.Text != "" && txtSecurityNumber.Text != "" && cmbMaritialStatus.Text != "")
            {
                MessageBox.Show($"Alla f�llt �r ifyllda. \n" +
                    $"Namn: {txtName.Text}.\nEfternamn: {txtSurname.Text}.\nEmail: {txtEmail.Text}.\nTelefonnummer: {txtPhoneNumber.Text}.\nPersonnummer: {txtSecurityNumber.Text}." +
                    $"\nCivilst�nd: {cmbMaritialStatus.Text}.");
            }
            else
            {
                string missing = "";
                if (txtName.Text == "")
                {
                    missing += "F�rnamn saknas.\n";
                }
                if (txtSurname.Text == "")
                {
                    missing += "Efternamn saknas.\n";
                }
                if (txtEmail.Text == "")
                {
                    missing += "Email saknas.\n";
                }
                if (txtPhoneNumber.Text == "")
                {
                    missing += "Telefonnummer saknas.\n";
                }
                if (txtSecurityNumber.Text == "")
                {
                    missing += "Personnummer saknas.\n";
                }
                if (cmbMaritialStatus.Text == "")
                {
                    missing += "Civilst�nd saknas.\n";
                }

                MessageBox.Show(missing);

               
                // Facit l�gger till texter tex f�rnamn ,efternamn etc. Om placeringen p� komma �r p� index 0 s� tar den bort den.
                //if (saknas.IndexOf(",") == 0)
                //{
                //    saknas = saknas.Substring(1, saknas.Length - 1);
                //}


            }
        }
    }
}
