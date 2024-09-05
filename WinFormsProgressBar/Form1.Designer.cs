namespace WinFormsProgressBar
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(158, 75);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(225, 29);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(158, 137);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(225, 29);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(158, 191);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(225, 29);
            progressBar3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 75);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Sekunder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 137);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Minuter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 191);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Timmar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
