namespace frmCalculator
{
    public partial class Form1 : Form
    {
        string operation;
        double firstNumber;
        public Form1()
        {
            InitializeComponent();
        }

        public string ButtonToText(string text)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                return textBox1.Text = text;
            }
            else
            {
                return textBox1.Text = textBox1.Text + text;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            ButtonToText("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            ButtonToText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ButtonToText("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            ButtonToText("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            ButtonToText("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            ButtonToText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ButtonToText("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            ButtonToText("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            ButtonToText("9");
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            ButtonToText(",");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";

            }
            else
            {
                double squareRoot = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = $"{squareRoot:##.##}";
            }
        }

        private void btnPowerOf_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";

            }
            else
            {
                double numberPow = Convert.ToDouble(textBox1.Text);
                double powerOf = Math.Pow(numberPow, numberPow);
                textBox1.Text = $"{powerOf:##.##}";
            }
        }

        private void btnDenominator_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";

            }
            else
            {
                double denominator = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"0{1 / denominator:##.######}";
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";

            }
            else
            {
                double percentage = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{percentage:P}";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sum;
            if (operation == "+")
            {
                sum = firstNumber + Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{sum}";
            }
            if (operation == "-")
            {
                sum = firstNumber - Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{sum}";
            }
            if (operation == "/")
            {
                sum = firstNumber / Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{sum}";
            }
            if (operation == "*")
            {
                sum = firstNumber * Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{sum}";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
