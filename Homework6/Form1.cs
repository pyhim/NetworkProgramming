namespace Homework6
{
    public partial class Form1 : Form
    {
        private Client _client = new();
        public Form1()
        {
            InitializeComponent();
            _client.WriteMessage += Client_WriteMessage;
        }

        private void Client_WriteMessage(string obj)
        {
            listBox1.Items.Add(obj);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _client.Connect(txtName.Text);
            txtName.ReadOnly = true;
            _ = _client.ReceiveMessageAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _ = _client.SendMessageAsync(txtName.Text, txtMessage.Text);
        }
    }
}
