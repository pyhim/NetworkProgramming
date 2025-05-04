using System.Net;
using System.Net.Sockets;

namespace Homework4Client;

public partial class Form1 : Form
{
    private ServerConnection? _connection;
    private Task TaskProcessLoop;
    private Task? TaskSendMessage;

    public Form1()
    {
        InitializeComponent();

        TaskProcessLoop = new(ProcessLoop);
    }

    private void ConnectButton_Click(object sender, EventArgs e)
    {
        _connection = new("127.0.0.1");
        _connection.Writer.WriteLine(loginTextBox.Text);

        TaskProcessLoop.Start();

        if (_connection.GetStatus())
        {
            MessageBox.Show("Successfully established connection with the server!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private void SendButton_Click(object sender, EventArgs e)
    {
        TaskSendMessage = new(() => SendMessage(messageTextBox.Text));
        TaskSendMessage.Start();
        TaskSendMessage.Wait();
    }

    private void ProcessLoop()
    {
        while (true)
        {
            if (_connection == null) break;

            string? responseMessage = _connection.Reader.ReadLine();

            if (responseMessage == null) continue;

            string[] messageTokens = responseMessage.Split(':');

            if (messageTokens[0].Equals("@MSG"))
            {
                chatRichTextBox.Text += messageTokens[1] + messageTokens[2] + '\n';
            }
            if (messageTokens[0].Equals("@CMD") && messageTokens[1].Equals("CHAT_UPDATE"))
            {
                UpdateChatMembersList(messageTokens[2]);
            }
        }
    }

    private void SendMessage(string message)
    {
        if (_connection == null) return;

        _connection.Writer.WriteLine(message);
    }

    private void UpdateChatMembersList(string members)
    {
        chatMembersListBox.Items.Clear();
        string[] membersTokens = members.Split('\n');

        foreach (var member in membersTokens)
        {
            chatMembersListBox.Items.Add(member);
        }
    }
}

