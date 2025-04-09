using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Homework6;

internal class Client
{
    private int _localPort = 8001;
    private IPAddress _broadcastAddress;

    public string Name { get; set; } = string.Empty;
    public event Action<string>? WriteMessage;

    public Client()
    {
        _broadcastAddress = IPAddress.Parse("224.0.0.0");
    }

    public void Connect(string name)
    {
        if (string.IsNullOrEmpty(name))
            return;

        Name = name;
        WriteMessage?.Invoke("Your name: " + Name);
    }
    public async Task ReceiveMessageAsync()
    {
        // UdpClient для получения данных
        using var receiver = new UdpClient(_localPort);
        receiver.JoinMulticastGroup(_broadcastAddress);

        // отключаем получение своих же сообщений
        receiver.MulticastLoopback = true;
        while (true)
        {
            var result = await receiver.ReceiveAsync();
            string message = Encoding.UTF8.GetString(result.Buffer);

            WriteMessage?.Invoke(message + " " + result.RemoteEndPoint.ToString());
        }
    }

    public async Task SendMessageAsync(string username, string message)
    {
        // создаем UdpClient для отправки
        using var sender = new UdpClient();

        // отправляем сообщения

        if (string.IsNullOrWhiteSpace(message)) return;
        message = $"{username}: {message}";

        byte[] data = Encoding.UTF8.GetBytes(message);
        await sender.SendAsync(data, new IPEndPoint(_broadcastAddress, _localPort));

    }
}

