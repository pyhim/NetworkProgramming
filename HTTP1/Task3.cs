namespace HTTP1;

public partial class Task3 : Form
{
    private HttpClient _httpClient = new();

    public Task3()
    {
        InitializeComponent();
    }

    private async void SearchButton_Click(object sender, EventArgs e)
    {
        string query = searchTextBox.Text;
        string searchUrl = $"https://www.gutenberg.org/ebooks/search/?query={Uri.EscapeDataString(query)}";

        string html = await _httpClient.GetStringAsync(searchUrl);

        var doc = new HtmlAgilityPack.HtmlDocument();
        doc.LoadHtml(html);

        var resultNodes = doc.DocumentNode.SelectNodes("//li[@class='booklink']");

        if (resultNodes == null)
        {
            MessageBox.Show("Nothing has been found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        foreach (var node in resultNodes)
        {
            var titleNode = node.SelectSingleNode(".//span[@class='title']");
            var subtitleNode = node.SelectSingleNode(".//span[@class='subtitle']");

            if (titleNode == null || subtitleNode == null) continue;

            resultsTextBox.Text += $"Title: {titleNode.InnerText}\r\nSubtitle: {subtitleNode.InnerText}\r\n\r\n";
        }
    }
}

