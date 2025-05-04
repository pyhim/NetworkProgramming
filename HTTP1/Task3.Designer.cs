namespace HTTP1
{
    partial class Task3
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
            searchTextBox = new TextBox();
            searchButton = new Button();
            resultsTextBox = new TextBox();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 821);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(676, 27);
            searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(694, 821);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(141, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // resultsTextBox
            // 
            resultsTextBox.Location = new Point(12, 12);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.ScrollBars = ScrollBars.Vertical;
            resultsTextBox.Size = new Size(823, 803);
            resultsTextBox.TabIndex = 2;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 860);
            Controls.Add(resultsTextBox);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Name = "Task3";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Button searchButton;
        private TextBox resultsTextBox;
    }
}