namespace frmVisaTextMeddelande
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
            txtTextruta1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtTextruta2 = new TextBox();
            cmdVisaMeddelande = new Button();
            SuspendLayout();
            // 
            // txtTextruta1
            // 
            txtTextruta1.Location = new Point(235, 74);
            txtTextruta1.Name = "txtTextruta1";
            txtTextruta1.Size = new Size(303, 27);
            txtTextruta1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtTextruta2
            // 
            txtTextruta2.Location = new Point(235, 146);
            txtTextruta2.Name = "txtTextruta2";
            txtTextruta2.Size = new Size(303, 27);
            txtTextruta2.TabIndex = 2;
            // 
            // cmdVisaMeddelande
            // 
            cmdVisaMeddelande.Location = new Point(325, 204);
            cmdVisaMeddelande.Name = "cmdVisaMeddelande";
            cmdVisaMeddelande.Size = new Size(94, 29);
            cmdVisaMeddelande.TabIndex = 3;
            cmdVisaMeddelande.Text = "Visa";
            cmdVisaMeddelande.UseVisualStyleBackColor = true;
            cmdVisaMeddelande.Click += cmdVisaMeddelande_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdVisaMeddelande);
            Controls.Add(txtTextruta2);
            Controls.Add(txtTextruta1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTextruta1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtTextruta2;
        private Button cmdVisaMeddelande;
    }
}
