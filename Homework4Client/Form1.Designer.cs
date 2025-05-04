namespace Homework4Client
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label1 = new Label();
            loginTextBox = new TextBox();
            loginLabel = new Label();
            connectButton = new Button();
            chatMembersListBox = new ListBox();
            messageTextBox = new TextBox();
            sendButton = new Button();
            groupBox2 = new GroupBox();
            chatRichTextBox = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(loginTextBox);
            groupBox1.Controls.Add(loginLabel);
            groupBox1.Controls.Add(connectButton);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(288, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connect";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 76);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 4;
            textBox3.Text = "127.0.0.1";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 83);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "IP-Address";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(103, 33);
            loginTextBox.Margin = new Padding(3, 4, 3, 4);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(178, 27);
            loginTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(17, 37);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(46, 20);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login";
            // 
            // connectButton
            // 
            connectButton.Location = new Point(149, 124);
            connectButton.Margin = new Padding(3, 4, 3, 4);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(133, 31);
            connectButton.TabIndex = 0;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += ConnectButton_Click;
            // 
            // chatMembersListBox
            // 
            chatMembersListBox.FormattingEnabled = true;
            chatMembersListBox.Location = new Point(7, 20);
            chatMembersListBox.Margin = new Padding(3, 4, 3, 4);
            chatMembersListBox.Name = "chatMembersListBox";
            chatMembersListBox.Size = new Size(274, 524);
            chatMembersListBox.TabIndex = 1;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(309, 701);
            messageTextBox.Margin = new Padding(3, 4, 3, 4);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PlaceholderText = "Write your message here...";
            messageTextBox.Size = new Size(409, 27);
            messageTextBox.TabIndex = 3;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(725, 701);
            sendButton.Margin = new Padding(3, 4, 3, 4);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(79, 31);
            sendButton.TabIndex = 4;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += SendButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chatMembersListBox);
            groupBox2.Location = new Point(14, 179);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(288, 553);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chat Members";
            // 
            // chatRichTextBox
            // 
            chatRichTextBox.Location = new Point(309, 26);
            chatRichTextBox.Name = "chatRichTextBox";
            chatRichTextBox.Size = new Size(495, 668);
            chatRichTextBox.TabIndex = 6;
            chatRichTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 749);
            Controls.Add(chatRichTextBox);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label loginLabel;
        private Button connectButton;
        private TextBox textBox3;
        private Label label1;
        private TextBox loginTextBox;
        private ListBox chatMembersListBox;
        private ListBox chat;
        private TextBox messageTextBox;
        private Button sendButton;
        private GroupBox groupBox2;
        private RichTextBox chatRichTextBox;
    }
}
