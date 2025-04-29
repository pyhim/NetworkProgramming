using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MailApp;

internal class Client
{
    public SmtpClient smtpClient;
    
    public string SmtpAddress { get; set; }
    public int SmtpPort { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public Client(string smtpAddress, int smtpPort, string email, string password)
    {
        smtpClient = new(smtpAddress, smtpPort)
        {
            EnableSsl = true
        };

        SmtpAddress = smtpAddress;
        SmtpPort = smtpPort;
        Email = email;
        Password = password;

        smtpClient.Credentials = new NetworkCredential(Email, Password);
    }

    public void ChangeSmtpServer(string smtpAddress, int smtpPort)
    {
        SmtpAddress = smtpAddress;
        SmtpPort = smtpPort;

        smtpClient = new(smtpAddress, smtpPort)
        {
            EnableSsl = true
        };
    }

    public void ChangeCredentials(string email, string password)
    {
        Email = email;
        Password = password;

        smtpClient.Credentials = new NetworkCredential(Email, Password);
    }

    public async Task SendMessageAsync(MailMessage mail) {
        /*foreach (var receiver in recepients)
        {
            _client.SendMailAsync(from, recepients, subject, body);
        }*/

        await smtpClient.SendMailAsync(mail);
    }
}

