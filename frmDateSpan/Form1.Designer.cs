namespace frmDateSpan
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
            startDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            buttonCalculateTimeDifference = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(124, 56);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(250, 27);
            startDateTimePicker.TabIndex = 0;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(124, 109);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(250, 27);
            endDateTimePicker.TabIndex = 1;
            // 
            // buttonCalculateTimeDifference
            // 
            buttonCalculateTimeDifference.Location = new Point(537, 72);
            buttonCalculateTimeDifference.Name = "buttonCalculateTimeDifference";
            buttonCalculateTimeDifference.Size = new Size(138, 55);
            buttonCalculateTimeDifference.TabIndex = 2;
            buttonCalculateTimeDifference.Text = "Beräkna tid";
            buttonCalculateTimeDifference.UseVisualStyleBackColor = true;
            buttonCalculateTimeDifference.Click += buttonCalculateTimeDifference_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(79, 223);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 196);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Skillnad mellan datumen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 140);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 9;
            label3.Text = "År";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 88);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 8;
            label2.Text = "Månader";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "Dagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 27);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 10;
            label4.Text = "Endast månader";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 110);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 11;
            label5.Text = "Endast dagar";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(362, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(362, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(buttonCalculateTimeDifference);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateTimePicker);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private Button buttonCalculateTimeDifference;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
    }
}
