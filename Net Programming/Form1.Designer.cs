namespace Homework1
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
            networkDevicesCountLabel = new Label();
            networkDevicesCountTextBox = new TextBox();
            groupBox1 = new GroupBox();
            propertiesButton = new Button();
            awakenDevicesTextBox = new TextBox();
            label1 = new Label();
            adaptersListBox = new ListBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // networkDevicesCountLabel
            // 
            networkDevicesCountLabel.AutoSize = true;
            networkDevicesCountLabel.Location = new Point(6, 19);
            networkDevicesCountLabel.Name = "networkDevicesCountLabel";
            networkDevicesCountLabel.Size = new Size(131, 15);
            networkDevicesCountLabel.TabIndex = 0;
            networkDevicesCountLabel.Text = "Network devices count ";
            // 
            // networkDevicesCountTextBox
            // 
            networkDevicesCountTextBox.Location = new Point(143, 16);
            networkDevicesCountTextBox.Name = "networkDevicesCountTextBox";
            networkDevicesCountTextBox.ReadOnly = true;
            networkDevicesCountTextBox.Size = new Size(27, 23);
            networkDevicesCountTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(propertiesButton);
            groupBox1.Controls.Add(awakenDevicesTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(adaptersListBox);
            groupBox1.Controls.Add(networkDevicesCountLabel);
            groupBox1.Controls.Add(networkDevicesCountTextBox);
            groupBox1.Location = new Point(10, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 218);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adapters";
            // 
            // propertiesButton
            // 
            propertiesButton.Location = new Point(255, 188);
            propertiesButton.Name = "propertiesButton";
            propertiesButton.Size = new Size(104, 23);
            propertiesButton.TabIndex = 5;
            propertiesButton.Text = "Properties";
            propertiesButton.UseVisualStyleBackColor = true;
            propertiesButton.Click += PropertiesButton_Click;
            // 
            // awakenDevicesTextBox
            // 
            awakenDevicesTextBox.Location = new Point(326, 16);
            awakenDevicesTextBox.Name = "awakenDevicesTextBox";
            awakenDevicesTextBox.ReadOnly = true;
            awakenDevicesTextBox.Size = new Size(27, 23);
            awakenDevicesTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Awaken devices";
            // 
            // adaptersListBox
            // 
            adaptersListBox.FormattingEnabled = true;
            adaptersListBox.Items.AddRange(new object[] { "", "" });
            adaptersListBox.Location = new Point(6, 58);
            adaptersListBox.Name = "adaptersListBox";
            adaptersListBox.Size = new Size(353, 124);
            adaptersListBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(10, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 218);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Summary";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(391, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 442);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Connections";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(385, 376);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 16);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(27, 23);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 5;
            label2.Text = "Active connections";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label networkDevicesCountLabel;
        private TextBox networkDevicesCountTextBox;
        private GroupBox groupBox1;
        private ListBox adaptersListBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox awakenDevicesTextBox;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button propertiesButton;
        private RichTextBox richTextBox1;
    }
}
