namespace frmCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnPercentage = new Button();
            btnClearLastEntry = new Button();
            btnClearAll = new Button();
            btnBackspace = new Button();
            btnDenominator = new Button();
            btnPowerOf = new Button();
            btnSquareRoot = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMultiply = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSubtract = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btnChangePlusMinus = new Button();
            btnZero = new Button();
            btnComma = new Button();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(23, 127);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(390, 44);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPercentage
            // 
            btnPercentage.BackColor = SystemColors.InfoText;
            btnPercentage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPercentage.ForeColor = SystemColors.ButtonHighlight;
            btnPercentage.Location = new Point(23, 191);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(90, 66);
            btnPercentage.TabIndex = 1;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = false;
            btnPercentage.Click += btnPercentage_Click;
            // 
            // btnClearLastEntry
            // 
            btnClearLastEntry.BackColor = SystemColors.InfoText;
            btnClearLastEntry.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearLastEntry.ForeColor = SystemColors.ButtonHighlight;
            btnClearLastEntry.Location = new Point(121, 191);
            btnClearLastEntry.Name = "btnClearLastEntry";
            btnClearLastEntry.Size = new Size(90, 66);
            btnClearLastEntry.TabIndex = 2;
            btnClearLastEntry.Text = "CE";
            btnClearLastEntry.UseVisualStyleBackColor = false;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = SystemColors.InfoText;
            btnClearAll.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearAll.ForeColor = SystemColors.ButtonHighlight;
            btnClearAll.Location = new Point(217, 191);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(90, 66);
            btnClearAll.TabIndex = 3;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.InfoText;
            btnBackspace.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackspace.ForeColor = SystemColors.ButtonHighlight;
            btnBackspace.Location = new Point(323, 191);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(90, 66);
            btnBackspace.TabIndex = 4;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            // 
            // btnDenominator
            // 
            btnDenominator.BackColor = SystemColors.InfoText;
            btnDenominator.Font = new Font("Segoe UI", 13.8F);
            btnDenominator.ForeColor = SystemColors.ButtonHighlight;
            btnDenominator.Location = new Point(23, 263);
            btnDenominator.Name = "btnDenominator";
            btnDenominator.Size = new Size(90, 66);
            btnDenominator.TabIndex = 5;
            btnDenominator.Text = "1/x";
            btnDenominator.UseVisualStyleBackColor = false;
            btnDenominator.Click += btnDenominator_Click;
            // 
            // btnPowerOf
            // 
            btnPowerOf.BackColor = SystemColors.InfoText;
            btnPowerOf.Font = new Font("Segoe UI", 13.8F);
            btnPowerOf.ForeColor = SystemColors.ButtonHighlight;
            btnPowerOf.Location = new Point(121, 263);
            btnPowerOf.Name = "btnPowerOf";
            btnPowerOf.Size = new Size(90, 66);
            btnPowerOf.TabIndex = 6;
            btnPowerOf.Text = "x^2";
            btnPowerOf.UseVisualStyleBackColor = false;
            btnPowerOf.Click += btnPowerOf_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.BackColor = SystemColors.InfoText;
            btnSquareRoot.Font = new Font("Segoe UI", 13.8F);
            btnSquareRoot.ForeColor = SystemColors.ButtonHighlight;
            btnSquareRoot.Location = new Point(217, 263);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(90, 66);
            btnSquareRoot.TabIndex = 7;
            btnSquareRoot.Text = "√";
            btnSquareRoot.UseVisualStyleBackColor = false;
            btnSquareRoot.Click += btnSquareRoot_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.InfoText;
            btnDivide.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = SystemColors.ButtonHighlight;
            btnDivide.Location = new Point(323, 263);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(90, 66);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.InfoText;
            btn7.Font = new Font("Segoe UI", 13.8F);
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(23, 335);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 66);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.InfoText;
            btnEight.Font = new Font("Segoe UI", 13.8F);
            btnEight.ForeColor = SystemColors.ButtonHighlight;
            btnEight.Location = new Point(121, 335);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(90, 66);
            btnEight.TabIndex = 10;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.InfoText;
            btnNine.Font = new Font("Segoe UI", 13.8F);
            btnNine.ForeColor = SystemColors.ButtonHighlight;
            btnNine.Location = new Point(217, 335);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(90, 66);
            btnNine.TabIndex = 11;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.InfoText;
            btnMultiply.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = SystemColors.ButtonHighlight;
            btnMultiply.Location = new Point(323, 335);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(90, 66);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.InfoText;
            btnFour.Font = new Font("Segoe UI", 13.8F);
            btnFour.ForeColor = SystemColors.ButtonHighlight;
            btnFour.Location = new Point(23, 407);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(90, 66);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.InfoText;
            btnFive.Font = new Font("Segoe UI", 13.8F);
            btnFive.ForeColor = SystemColors.ButtonHighlight;
            btnFive.Location = new Point(121, 407);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(90, 66);
            btnFive.TabIndex = 14;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.InfoText;
            btnSix.Font = new Font("Segoe UI", 13.8F);
            btnSix.ForeColor = SystemColors.ButtonHighlight;
            btnSix.Location = new Point(217, 407);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(90, 66);
            btnSix.TabIndex = 15;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.InfoText;
            btnSubtract.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtract.ForeColor = SystemColors.ButtonHighlight;
            btnSubtract.Location = new Point(323, 407);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(90, 66);
            btnSubtract.TabIndex = 16;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.InfoText;
            btnOne.Font = new Font("Segoe UI", 13.8F);
            btnOne.ForeColor = SystemColors.ButtonHighlight;
            btnOne.Location = new Point(23, 479);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(90, 66);
            btnOne.TabIndex = 17;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.InfoText;
            btnTwo.Font = new Font("Segoe UI", 13.8F);
            btnTwo.ForeColor = SystemColors.ButtonHighlight;
            btnTwo.Location = new Point(121, 479);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(90, 66);
            btnTwo.TabIndex = 18;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.InfoText;
            btn3.Font = new Font("Segoe UI", 13.8F);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(217, 479);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 66);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.InfoText;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(323, 479);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 66);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnChangePlusMinus
            // 
            btnChangePlusMinus.BackColor = SystemColors.InfoText;
            btnChangePlusMinus.Font = new Font("Segoe UI", 13.8F);
            btnChangePlusMinus.ForeColor = SystemColors.ButtonHighlight;
            btnChangePlusMinus.Location = new Point(23, 556);
            btnChangePlusMinus.Name = "btnChangePlusMinus";
            btnChangePlusMinus.Size = new Size(90, 66);
            btnChangePlusMinus.TabIndex = 21;
            btnChangePlusMinus.Text = "+/-";
            btnChangePlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.InfoText;
            btnZero.Font = new Font("Segoe UI", 13.8F);
            btnZero.ForeColor = SystemColors.ButtonHighlight;
            btnZero.Location = new Point(121, 556);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(90, 66);
            btnZero.TabIndex = 22;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnComma
            // 
            btnComma.BackColor = SystemColors.InfoText;
            btnComma.Font = new Font("Segoe UI", 13.8F);
            btnComma.ForeColor = SystemColors.ButtonHighlight;
            btnComma.Location = new Point(217, 556);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(90, 66);
            btnComma.TabIndex = 23;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = false;
            btnComma.Click += btnComma_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.InfoText;
            btnCalculate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.ButtonHighlight;
            btnCalculate.Location = new Point(323, 556);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(90, 66);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "=";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(445, 634);
            Controls.Add(btnCalculate);
            Controls.Add(btnComma);
            Controls.Add(btnZero);
            Controls.Add(btnChangePlusMinus);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnSubtract);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnMultiply);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btnSquareRoot);
            Controls.Add(btnPowerOf);
            Controls.Add(btnDenominator);
            Controls.Add(btnBackspace);
            Controls.Add(btnClearAll);
            Controls.Add(btnClearLastEntry);
            Controls.Add(btnPercentage);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Kalkylator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnPercentage;
        private Button btnClearLastEntry;
        private Button btnClearAll;
        private Button btnBackspace;
        private Button btnDenominator;
        private Button btnPowerOf;
        private Button btnSquareRoot;
        private Button btnDivide;
        private Button btn7;
        private Button btnEight;
        private Button btnNine;
        private Button btnMultiply;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSubtract;
        private Button btnOne;
        private Button btnTwo;
        private Button btn3;
        private Button btnAdd;
        private Button btnChangePlusMinus;
        private Button btnZero;
        private Button btnComma;
        private Button btnCalculate;
    }
}
