
namespace Homework4Server;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var server = new Server();

        await server.Start();
    }
}

