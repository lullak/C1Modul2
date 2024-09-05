namespace DemoWinForms2
{
    partial class FormSearch
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
            textBoxSearchCondition = new TextBox();
            buttonSearch = new Button();
            listBoxSearchResults = new ListBox();
            SuspendLayout();
            // 
            // textBoxSearchCondition
            // 
            textBoxSearchCondition.Location = new Point(109, 51);
            textBoxSearchCondition.Name = "textBoxSearchCondition";
            textBoxSearchCondition.Size = new Size(241, 27);
            textBoxSearchCondition.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(379, 49);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.Location = new Point(109, 118);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(364, 244);
            listBoxSearchResults.TabIndex = 2;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxSearchResults);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearchCondition);
            Name = "FormSearch";
            Text = "Sök på namn i en text fil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchCondition;
        private Button buttonSearch;
        private ListBox listBoxSearchResults;
    }
}