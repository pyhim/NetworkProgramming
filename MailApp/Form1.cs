using System.ComponentModel;
using System.Net.Mail;
using System.Text;

namespace MailApp
{
    public partial class Form1 : Form
    {
        private Client? _client;

        private string _selectedRecepient = string.Empty;
        private string _selectedAttachment = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddRecepientButton_Click(object sender, EventArgs e)
        {
            recepientsListBox.Items.Add(recepientsTextBox.Text);
        }

        private void RemoveRecepientButton_Click(object sender, EventArgs e)
        {
            if (_selectedRecepient.Equals(string.Empty)) return;

            recepientsListBox.Items.Remove(_selectedRecepient);
        }

        private void RecepientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRecepient = recepientsListBox.SelectedItem as string ?? string.Empty;
        }

        private void ClearRecepientButton_Click(object sender, EventArgs e)
        {
            recepientsListBox.Items.Clear();
        }

        private void AddAttachmentButton_Click(object sender, EventArgs e)
        {
            attachmentsFileDialog.ShowDialog();
        }

        private void AttachmentsFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            attachmentsListBox.Items.Add(attachmentsFileDialog.FileName);
        }

        private void RemoveAttachmentButton_Click(object sender, EventArgs e)
        {
            attachmentsListBox.Items.Remove(_selectedAttachment);
        }

        private void AttachmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAttachment = attachmentsListBox.SelectedItem as string ?? string.Empty;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            var recepientsBuilder = new StringBuilder();

            if (recepientsListBox.Items.Count > 1)
            {
                foreach (string recepient in recepientsListBox.Items)
                {
                    recepientsBuilder.Append(recepient);
                    recepientsBuilder.Append(';');
                }
            }
            recepientsBuilder.Append(recepientsListBox.Items[0]);

            _client = new(smtpAddressTextBox.Text, (int)smtpPortUpDown.Value, emailTextBox.Text, passwordTextBox.Text);
            _client.smtpClient.SendCompleted += new SendCompletedEventHandler(SendMessageCompleted);

            var mail =
                new MailMessage(emailTextBox.Text, recepientsBuilder.ToString(), subjectTextBox.Text, messageRichTextBox.Text);

            if (attachmentsListBox.Items.Count == 0)
            {
                _ = _client.SendMessageAsync(mail);
                return;
            }

            foreach (string filePath in attachmentsListBox.Items)
            {
                mail.Attachments.Add(new Attachment(filePath));
            }

            _ = _client.SendMessageAsync(mail);
        }

        private void SendMessageCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //string token = (string)(e.UserState ?? string.Empty);

            if (e.Cancelled)
            {
                MessageBox.Show($"[] Send canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.Error != null)
            {
                MessageBox.Show($"[] {e.Error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Message sent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
