namespace HTTP1;

public partial class Task2 : Form
{
    private const string _topUrl = "https://www.gutenberg.org/browse/scores/top";
    private HttpClient _httpClient = new();
    private Dictionary<string, string> _bookFileLinks = new();

    public Task2()
    {
        InitializeComponent();
        _ = LoadTopBooksAsync();
    }

    private async Task LoadTopBooksAsync()
    {
        string html = await _httpClient.GetStringAsync(_topUrl);

        var doc = new HtmlAgilityPack.HtmlDocument();
        doc.LoadHtml(html);

        var topList = doc.DocumentNode.SelectSingleNode("//ol[1]");
        var items = topList!.SelectNodes(".//li/a");

        foreach (var item in items!)
        {
            string title = item.InnerText;
            string bookNumber = item.GetAttributeValue("href", string.Empty).Split('/', StringSplitOptions.RemoveEmptyEntries)[1];
            string link = $"https://www.gutenberg.org/cache/epub/{bookNumber}/pg{bookNumber}.txt";

            _bookFileLinks.Add(title, link);
        }
    }

    private void ShowTopBooks()
    {
        foreach (var item in _bookFileLinks)
        {
            booksListBox.Items.Add(item.Key);
        }
    }

    private async void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string link = _bookFileLinks[(string)booksListBox.SelectedItem!];

            bookTextBox.Text = await _httpClient.GetStringAsync(link);
            MessageBox.Show("Downloaded successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (HttpRequestException err)
        {
            MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadButton_Click(object sender, EventArgs e)
    {
        ShowTopBooks();
    }
}

