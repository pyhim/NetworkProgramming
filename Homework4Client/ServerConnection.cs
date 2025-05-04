using System.IO;
using System.Net.Sockets;

namespace Homework4Client;

internal class ServerConnection
{
    private readonly TcpClient _connection;
    /*private readonly StreamWriter _writer;
    private readonly StreamReader _reader;*/

    protected internal StreamWriter Writer { get; private set; }
    protected internal StreamReader Reader { get; private set; }

    public ServerConnection(string ipAddress)
    {
        _connection = new(ipAddress, 54532);

        var networkStream = _connection.GetStream();
        Writer = new(networkStream);
        Reader = new(networkStream);

        Writer.AutoFlush = true;
    }

    public bool GetStatus()
    {
        return _connection.Connected;
    }

    ~ServerConnection() 
    {
        _connection.Close();
    }
}

