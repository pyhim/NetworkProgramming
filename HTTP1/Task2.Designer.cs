namespace HTTP1
{
    partial class Task2
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
            groupBox1 = new GroupBox();
            loadButton = new Button();
            booksListBox = new ListBox();
            groupBox2 = new GroupBox();
            bookTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loadButton);
            groupBox1.Controls.Add(booksListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 858);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top 100 Popular Books";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(6, 816);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(376, 36);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += LoadButton_Click;
            // 
            // booksListBox
            // 
            booksListBox.FormattingEnabled = true;
            booksListBox.Location = new Point(6, 26);
            booksListBox.Name = "booksListBox";
            booksListBox.Size = new Size(376, 784);
            booksListBox.TabIndex = 0;
            booksListBox.SelectedIndexChanged += BooksListBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bookTextBox);
            groupBox2.Location = new Point(406, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 858);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Text";
            // 
            // bookTextBox
            // 
            bookTextBox.Location = new Point(6, 26);
            bookTextBox.Multiline = true;
            bookTextBox.Name = "bookTextBox";
            bookTextBox.ScrollBars = ScrollBars.Vertical;
            bookTextBox.Size = new Size(595, 826);
            bookTextBox.TabIndex = 2;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 877);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Task2";
            Text = "Task2";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox booksListBox;
        private GroupBox groupBox2;
        private TextBox bookTextBox;
        private Button loadButton;
    }
}