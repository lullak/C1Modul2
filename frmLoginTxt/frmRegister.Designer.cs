namespace frmLoginTxt
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(334, 212);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(94, 29);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Registrera";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(186, 179);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(242, 27);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(186, 126);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(242, 27);
            textBoxUsername.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 156);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Lösenord";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 103);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 6;
            label1.Text = "Användarnamn";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 365);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label2;
        private Label label1;
    }
}