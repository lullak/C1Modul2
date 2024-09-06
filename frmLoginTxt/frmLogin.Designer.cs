namespace frmLoginTxt
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegister = new Button();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 87);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Användarnamn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 140);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Lösenord";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(207, 110);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(242, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(207, 163);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(242, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(207, 196);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(94, 29);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Registrera";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(355, 196);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Logga in";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 351);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonRegister;
        private Button buttonLogin;
    }
}