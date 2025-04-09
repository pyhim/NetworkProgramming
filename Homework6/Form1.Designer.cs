namespace Homework6
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
            txtName = new TextBox();
            btnStart = new Button();
            listBox1 = new ListBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your name";
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(159, 23);
            txtName.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(291, 23);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(14, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 274);
            listBox1.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(14, 332);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(352, 23);
            txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(152, 361);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 389);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(listBox1);
            Controls.Add(btnStart);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnStart;
        private ListBox listBox1;
        private TextBox txtMessage;
        private Button btnSend;
    }
}
