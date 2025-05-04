using System.Threading.Tasks;

namespace HTTP1;

public partial class Task1 : Form
{
    private HttpClient _httpClient = new();
    private const string url = "https://www.gutenberg.org/cache/epub/27761/pg27761.txt";

    public Task1()
    {
        InitializeComponent();
    }

    private async void DownloadButton_Click(object sender, EventArgs e)
    {
        try
        {
            string responseText = await _httpClient.GetStringAsync(url);

            mainRichTextBox.Text = responseText;
            MessageBox.Show("Downloaded successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (HttpRequestException err)
        {
            MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

