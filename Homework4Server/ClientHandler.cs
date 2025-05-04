using System.Net.Sockets;

namespace Homework4Server;

internal class ClientHandler
{
    public string Id { get; } = Guid.NewGuid().ToString();
    protected internal StreamWriter Writer { get; }
    protected internal StreamReader Reader { get; }

    private Task TaskProcess { get; set; }
    private CancellationTokenSource Cts { get; } = new();
    private bool _destroyable = false;
    public bool Destroyable => _destroyable;

    private TcpClient _client;
    private Server _server;

    protected internal string Username { get; set; } = string.Empty;

    public ClientHandler(TcpClient tcpClient, Server server)
    {
        _client = tcpClient;
        _server = server;

        var stream = _client.GetStream();

        Reader = new StreamReader(stream);
        Writer = new StreamWriter(stream);
        TaskProcess = new Task(() => Process(Cts.Token), Cts.Token);
        TaskProcess.Start();
    }

    public void Process(CancellationToken token)
    {
        try
        {
            Username = Reader.ReadLine() ?? "ANONYMOUS";
            string? message = $"@MSG:{Username} entered the chat";

            _server.BroadcastMessage(message, Id);
            _server.BroadcastMessage($"@CMD:CHAT_UPDATE:{_server.GetChatMembersList()}");

            while (true)
            {
                token.ThrowIfCancellationRequested();

                if (!_client.Connected)
                {
                    message = $"@MSG:{Username} left the chat";
                    Console.WriteLine(message);
                    _server.BroadcastMessage(message, Id);
                    _server.BroadcastMessage($"@CMD:CHAT_UPDATE:{_server.GetChatMembersList()}");
                    _server.RemoveConnection(this);
                    break;
                }

                message = Reader.ReadLine();

                if (message == null) continue;

                message = $"@MSG:{Username}: {message}";
                Console.WriteLine(message);
                _server.BroadcastMessage(message, Id);

            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Stopped ClientHandler, finalizing...");
            _destroyable = true;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.ToString());
            _server.RemoveConnection(this);
        }
    }

    ~ClientHandler()
    {
        
        Writer.Close();
        Reader.Close();
        _client.Close();
    }
}

