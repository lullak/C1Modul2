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
                MessageBox.Show($"Alla fällt är ifyllda. \n" +
                    $"Namn: {txtName.Text}.\nEfternamn: {txtSurname.Text}.\nEmail: {txtEmail.Text}.\nTelefonnummer: {txtPhoneNumber.Text}.\nPersonnummer: {txtSecurityNumber.Text}." +
                    $"\nCivilstånd: {cmbMaritialStatus.Text}.");
            }
            else
            {
                string missing = "";
                if (txtName.Text == "")
                {
                    missing += "Förnamn saknas.\n";
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
                    missing += "Civilstånd saknas.\n";
                }

                MessageBox.Show(missing);

               
                // Facit lägger till texter tex förnamn ,efternamn etc. Om placeringen på komma är på index 0 så tar den bort den.
                //if (saknas.IndexOf(",") == 0)
                //{
                //    saknas = saknas.Substring(1, saknas.Length - 1);
                //}


            }
        }
    }
}
