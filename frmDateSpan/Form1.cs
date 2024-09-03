namespace frmDateSpan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateTimeDifference_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = startDateTimePicker.Value;
            DateTime endDateTime = endDateTimePicker.Value;

            int years = endDateTime.Year - startDateTime.Year;

            if (endDateTime.Month < startDateTime.Month || (endDateTime.Month == startDateTime.Month && endDateTime.Day < startDateTime.Day))
            {
                years--;
            }


            int months = endDateTime.Month - startDateTime.Month;
            if (endDateTime.Day < startDateTime.Day)
            {
                months--;
            }
            if (months < 0)
            {
                months += 12;
            }

            int days = (endDateTime - startDateTime.AddYears(years).AddMonths(months)).Days;

            int onlyDays = (endDateTime - startDateTime).Days;
            int onlyMonths = (endDateTime.Year - startDateTime.Year) * 12 + (endDateTime.Month - startDateTime.Month);
            if (endDateTime.Day < startDateTime.Day)
            {
                onlyMonths--;
            }

            textBox1.Text = days.ToString();
            textBox2.Text = years.ToString();
            textBox3.Text = months.ToString();
            textBox4.Text = onlyMonths.ToString();
            textBox5.Text = onlyDays.ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
