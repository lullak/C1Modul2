namespace frmAdressBok
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
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtSecurityNumber = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            cmbMaritialStatus = new ComboBox();
            lblName = new Label();
            lblSurname = new Label();
            lblSecurityNumber = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblMaritialStatus = new Label();
            btnCmdCheck = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(178, 102);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 1;
            // 
            // txtSecurityNumber
            // 
            txtSecurityNumber.Location = new Point(178, 145);
            txtSecurityNumber.Name = "txtSecurityNumber";
            txtSecurityNumber.Size = new Size(125, 27);
            txtSecurityNumber.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(178, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(178, 237);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 4;
            // 
            // cmbMaritialStatus
            // 
            cmbMaritialStatus.FormattingEnabled = true;
            cmbMaritialStatus.Location = new Point(178, 281);
            cmbMaritialStatus.Name = "cmbMaritialStatus";
            cmbMaritialStatus.Size = new Size(151, 28);
            cmbMaritialStatus.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(60, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Förnamn";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(60, 105);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(77, 20);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Efternamn";
            // 
            // lblSecurityNumber
            // 
            lblSecurityNumber.AutoSize = true;
            lblSecurityNumber.Location = new Point(60, 145);
            lblSecurityNumber.Name = "lblSecurityNumber";
            lblSecurityNumber.Size = new Size(107, 20);
            lblSecurityNumber.TabIndex = 8;
            lblSecurityNumber.Text = "Personnummer";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(60, 192);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(60, 240);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(113, 20);
            lblPhoneNumber.TabIndex = 10;
            lblPhoneNumber.Text = "Telefonnummer";
            // 
            // lblMaritialStatus
            // 
            lblMaritialStatus.AutoSize = true;
            lblMaritialStatus.Location = new Point(60, 284);
            lblMaritialStatus.Name = "lblMaritialStatus";
            lblMaritialStatus.Size = new Size(73, 20);
            lblMaritialStatus.TabIndex = 11;
            lblMaritialStatus.Text = "Civilstånd";
            // 
            // btnCmdCheck
            // 
            btnCmdCheck.Location = new Point(178, 347);
            btnCmdCheck.Name = "btnCmdCheck";
            btnCmdCheck.Size = new Size(94, 29);
            btnCmdCheck.TabIndex = 12;
            btnCmdCheck.Text = "OK";
            btnCmdCheck.UseVisualStyleBackColor = true;
            btnCmdCheck.Click += btnCmdCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 435);
            Controls.Add(btnCmdCheck);
            Controls.Add(lblMaritialStatus);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblSecurityNumber);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(cmbMaritialStatus);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSecurityNumber);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtSecurityNumber;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private ComboBox cmbMaritialStatus;
        private Label lblName;
        private Label lblSurname;
        private Label lblSecurityNumber;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblMaritialStatus;
        private Button btnCmdCheck;
    }
}
