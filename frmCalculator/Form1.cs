namespace frmCalculator
{
    public partial class Form1 : Form
    {
        private string operation;
        private double result = 0;
        private bool isOperationPending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendNumber(string number)
        {
            if (textBox1.Text == "0")
                textBox1.Text = number;
            else
                textBox1.Text += number;
        }

        private void SetOperation(string op)
        {
            if (isOperationPending)
            {
                PerformCalculation();
                operation = op;
            }
            else
            {
                result = Convert.ToDouble(textBox1.Text);
                operation = op;
                isOperationPending = true;
                
            }
            operation = op;
            textBox1.Text = "0";
        }

        private void PerformCalculation()
        {
            double number = Convert.ToDouble(textBox1.Text);

            switch (operation)
            {
                case "+":
                    result += number;
                    break;
                case "-":
                    result -= number;
                    break;
                case "*":
                    result *= number;
                    break;
                case "+-":
                    result = -number;
                    break;
                case "/":
                    if (number != 0)
                        result /= number;
                    else
                        MessageBox.Show("Cannot divide by zero.");
                    break;
                default:
                    break;
            }

            textBox1.Text = $"{result}";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = ",";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperation("/");
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
            if (isOperationPending)
            {
                PerformCalculation();
                operation = "=";
                isOperationPending = false;
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePlusMinus_Click(object sender, EventArgs e)
        {
            {
                SetOperation("+-");
            }
        }
    }
}
