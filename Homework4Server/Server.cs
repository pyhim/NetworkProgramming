using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Homework4Server;

public class Server
{
    private TcpListener _listener = new(IPAddress.Loopback, 54532);
    private LinkedList<ClientHandler> _handlers = [];
    private bool _shutdown = false;

    public async Task Start()
    {
        _listener.Start();

        await ListenAsync();

        /*while (!_shutdown)
        {
            if (_handlers.Count < 1)
            {
                Thread.Sleep(1000);
                continue;
            }

            foreach (ClientHandler handler in _handlers)
            {
                if (handler.Destroyable)
                    _handlers.Remove(handler);
            }

            Thread.Sleep(3000);
        }*/
    }

    public async Task ListenAsync()
    {
        while (!_shutdown)
        {
            TcpClient newClient = await _listener.AcceptTcpClientAsync();
            lock (_handlers)
            {
                _handlers.AddLast(new ClientHandler(newClient, this));
            }
            Thread.Sleep(2000);
        }
    }

    protected internal void BroadcastMessage(string message, string excludedId)
    {
        lock (_handlers)
        {

            foreach (var client in _handlers)
            {
                if (client.Id == excludedId) continue;
                
                client.Writer.WriteLine(message);
                client.Writer.Flush();
            }
        }
    }
     
    protected internal void BroadcastMessage(string message)
    {
        lock (_handlers)
        {
            foreach (var client in _handlers)
            {
                client.Writer.WriteLine(message);
                client.Writer.Flush();
            }
        }
    }

    internal void RemoveConnection(ClientHandler handler)
    {
        /*// получаем по id закрытое подключение
        ClientHandler? client = _handlers.FirstOrDefault(c => c.Id == id);
        // и удаляем его из списка подключений
        if (client != null) */
        lock (_handlers)
        {
            _handlers.Remove(handler); 
        }
    }

    protected internal string GetChatMembersList()
    {
        var builder = new StringBuilder();

        lock (_handlers)
        {
            foreach (var client in _handlers)
            {
                builder.AppendLine(client.Username);
            } 
        }
        
        return builder.ToString();
    }

    ~Server()
    {
        _listener.Dispose();
        _listener.Stop();
    }
}

