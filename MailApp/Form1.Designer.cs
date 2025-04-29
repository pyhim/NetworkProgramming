namespace MailApp
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
            recepientsTextBox = new TextBox();
            clearRecepientButton = new Button();
            removeRecepientButton = new Button();
            addRecepientButton = new Button();
            recepientsListBox = new ListBox();
            groupBox2 = new GroupBox();
            passwordTextBox = new TextBox();
            label4 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            smtpPortUpDown = new NumericUpDown();
            label2 = new Label();
            smtpAddressTextBox = new TextBox();
            label1 = new Label();
            sendButton = new Button();
            groupBox3 = new GroupBox();
            messageRichTextBox = new RichTextBox();
            label6 = new Label();
            subjectTextBox = new TextBox();
            label5 = new Label();
            groupBox4 = new GroupBox();
            attachmentsListBox = new ListBox();
            removeAttachmentButton = new Button();
            addAttachmentButton = new Button();
            attachmentsFileDialog = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)smtpPortUpDown).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(recepientsTextBox);
            groupBox1.Controls.Add(clearRecepientButton);
            groupBox1.Controls.Add(removeRecepientButton);
            groupBox1.Controls.Add(addRecepientButton);
            groupBox1.Controls.Add(recepientsListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recepients";
            // 
            // recepientsTextBox
            // 
            recepientsTextBox.Location = new Point(7, 156);
            recepientsTextBox.Name = "recepientsTextBox";
            recepientsTextBox.Size = new Size(305, 27);
            recepientsTextBox.TabIndex = 3;
            // 
            // clearRecepientButton
            // 
            clearRecepientButton.Location = new Point(218, 192);
            clearRecepientButton.Name = "clearRecepientButton";
            clearRecepientButton.Size = new Size(94, 29);
            clearRecepientButton.TabIndex = 2;
            clearRecepientButton.Text = "Clear";
            clearRecepientButton.UseVisualStyleBackColor = true;
            clearRecepientButton.Click += ClearRecepientButton_Click;
            // 
            // removeRecepientButton
            // 
            removeRecepientButton.Location = new Point(112, 192);
            removeRecepientButton.Name = "removeRecepientButton";
            removeRecepientButton.Size = new Size(94, 29);
            removeRecepientButton.TabIndex = 1;
            removeRecepientButton.Text = "Remove";
            removeRecepientButton.UseVisualStyleBackColor = true;
            removeRecepientButton.Click += RemoveRecepientButton_Click;
            // 
            // addRecepientButton
            // 
            addRecepientButton.Location = new Point(6, 192);
            addRecepientButton.Name = "addRecepientButton";
            addRecepientButton.Size = new Size(94, 29);
            addRecepientButton.TabIndex = 1;
            addRecepientButton.Text = "Add";
            addRecepientButton.UseVisualStyleBackColor = true;
            addRecepientButton.Click += AddRecepientButton_Click;
            // 
            // recepientsListBox
            // 
            recepientsListBox.FormattingEnabled = true;
            recepientsListBox.Location = new Point(6, 26);
            recepientsListBox.Name = "recepientsListBox";
            recepientsListBox.Size = new Size(307, 124);
            recepientsListBox.TabIndex = 1;
            recepientsListBox.SelectedIndexChanged += RecepientsListBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(emailTextBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(smtpPortUpDown);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(smtpAddressTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 245);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 240);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Server";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(7, 205);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(305, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 182);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(7, 152);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(305, 27);
            emailTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 129);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // smtpPortUpDown
            // 
            smtpPortUpDown.Location = new Point(7, 99);
            smtpPortUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            smtpPortUpDown.Name = "smtpPortUpDown";
            smtpPortUpDown.Size = new Size(93, 27);
            smtpPortUpDown.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // smtpAddressTextBox
            // 
            smtpAddressTextBox.Location = new Point(7, 46);
            smtpAddressTextBox.Name = "smtpAddressTextBox";
            smtpAddressTextBox.Size = new Size(306, 27);
            smtpAddressTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "SMTP Server";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(84, 491);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(174, 51);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += SendButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(messageRichTextBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(subjectTextBox);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(337, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(490, 306);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Message";
            // 
            // messageRichTextBox
            // 
            messageRichTextBox.Location = new Point(6, 99);
            messageRichTextBox.Name = "messageRichTextBox";
            messageRichTextBox.Size = new Size(478, 201);
            messageRichTextBox.TabIndex = 3;
            messageRichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 76);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 2;
            label6.Text = "Text";
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(6, 46);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(478, 27);
            subjectTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 0;
            label5.Text = "Subject";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(attachmentsListBox);
            groupBox4.Controls.Add(removeAttachmentButton);
            groupBox4.Controls.Add(addAttachmentButton);
            groupBox4.Location = new Point(337, 324);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(490, 218);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Attachments";
            // 
            // attachmentsListBox
            // 
            attachmentsListBox.FormattingEnabled = true;
            attachmentsListBox.Location = new Point(6, 19);
            attachmentsListBox.Name = "attachmentsListBox";
            attachmentsListBox.Size = new Size(478, 164);
            attachmentsListBox.TabIndex = 4;
            attachmentsListBox.SelectedIndexChanged += AttachmentsListBox_SelectedIndexChanged;
            // 
            // removeAttachmentButton
            // 
            removeAttachmentButton.Location = new Point(390, 183);
            removeAttachmentButton.Name = "removeAttachmentButton";
            removeAttachmentButton.Size = new Size(94, 29);
            removeAttachmentButton.TabIndex = 2;
            removeAttachmentButton.Text = "Remove";
            removeAttachmentButton.UseVisualStyleBackColor = true;
            removeAttachmentButton.Click += RemoveAttachmentButton_Click;
            // 
            // addAttachmentButton
            // 
            addAttachmentButton.Location = new Point(290, 183);
            addAttachmentButton.Name = "addAttachmentButton";
            addAttachmentButton.Size = new Size(94, 29);
            addAttachmentButton.TabIndex = 3;
            addAttachmentButton.Text = "Add";
            addAttachmentButton.UseVisualStyleBackColor = true;
            addAttachmentButton.Click += AddAttachmentButton_Click;
            // 
            // attachmentsFileDialog
            // 
            attachmentsFileDialog.FileName = "openFileDialog1";
            attachmentsFileDialog.FileOk += AttachmentsFileDialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 554);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(sendButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)smtpPortUpDown).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button clearRecepientButton;
        private Button removeRecepientButton;
        private Button addRecepientButton;
        private ListBox recepientsListBox;
        private TextBox recepientsTextBox;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox emailTextBox;
        private Label label3;
        private NumericUpDown smtpPortUpDown;
        private Label label2;
        private TextBox smtpAddressTextBox;
        private Label label1;
        private TextBox passwordTextBox;
        private Button sendButton;
        private GroupBox groupBox3;
        private RichTextBox messageRichTextBox;
        private Label label6;
        private TextBox subjectTextBox;
        private Label label5;
        private GroupBox groupBox4;
        private ListBox attachmentsListBox;
        private Button removeAttachmentButton;
        private Button addAttachmentButton;
        private OpenFileDialog attachmentsFileDialog;
    }
}
