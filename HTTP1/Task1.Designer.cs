namespace HTTP1
{
    partial class Task1
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
            mainRichTextBox = new RichTextBox();
            downloadButton = new Button();
            SuspendLayout();
            // 
            // mainRichTextBox
            // 
            mainRichTextBox.Location = new Point(12, 12);
            mainRichTextBox.Name = "mainRichTextBox";
            mainRichTextBox.Size = new Size(837, 834);
            mainRichTextBox.TabIndex = 0;
            mainRichTextBox.Text = "";
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(12, 852);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(837, 63);
            downloadButton.TabIndex = 1;
            downloadButton.Text = "Download Shakespear's Hamlet ";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += DownloadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 927);
            Controls.Add(downloadButton);
            Controls.Add(mainRichTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox mainRichTextBox;
        private Button downloadButton;
    }
}
