namespace FormsFile2
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
            label1 = new Label();
            textBox1 = new TextBox();
            lstFiles = new ListBox();
            cmdVisaFiler = new Button();
            buttonOpen = new Button();
            buttonSave = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 35);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Filkatalog";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 1;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.Location = new Point(123, 130);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(255, 204);
            lstFiles.TabIndex = 2;
            // 
            // cmdVisaFiler
            // 
            cmdVisaFiler.Location = new Point(121, 352);
            cmdVisaFiler.Name = "cmdVisaFiler";
            cmdVisaFiler.Size = new Size(129, 51);
            cmdVisaFiler.TabIndex = 3;
            cmdVisaFiler.Text = "Visa filer";
            cmdVisaFiler.UseVisualStyleBackColor = true;
            cmdVisaFiler.Click += cmdVisaFiler_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(525, 352);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 4;
            buttonOpen.Text = "Öppna";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(625, 352);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(480, 133);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 201);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(cmdVisaFiler);
            Controls.Add(lstFiles);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox lstFiles;
        private Button cmdVisaFiler;
        private Button buttonOpen;
        private Button buttonSave;
        private TextBox textBox2;
    }
}
