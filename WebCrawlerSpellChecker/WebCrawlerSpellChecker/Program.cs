using HtmlAgilityPack;

HttpClient client = new HttpClient();

HashSet<string> visitedUrls = new HashSet<string>();
Queue<string> urlsToVisit = new Queue<string>();


client.DefaultRequestHeaders.Add("User-Agent",
    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

Console.Write("Please enter the URL: ");
string startUrl = Console.ReadLine();

Console.Write("Please target text to search: ");
string targetText = Console.ReadLine(); // The text you're looking for


urlsToVisit.Enqueue(startUrl);

while (urlsToVisit.Count > 0)
{
    string currentUrl = urlsToVisit.Dequeue();
    if (visitedUrls.Contains(currentUrl))
        continue;

    visitedUrls.Add(currentUrl);
    Console.WriteLine($"Visiting: {currentUrl}");

    try
    {
        var pageText = await GetPageText(currentUrl);
        int count = CountOccurrences(pageText, targetText);
        // Search for the target text
        // if (pageText.Contains(targetText, StringComparison.OrdinalIgnoreCase)) 
        if (count > 0) Console.WriteLine($"Found '{targetText}' {count} times on page: {currentUrl}");

        
        var links = await GetLinks(currentUrl);

        foreach (var link in links.Where(link =>
                     !visitedUrls.Contains(link) && link.StartsWith("/") || link.StartsWith(startUrl)))
        {
            urlsToVisit.Enqueue(link.StartsWith("/") ? $"{startUrl}{link}" : link);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error fetching {currentUrl}: {ex.Message}");
    }
}

async Task<string> GetPageText(string url)
{
    string html = await client.GetStringAsync(url);
    var doc = new HtmlDocument();
    doc.LoadHtml(html);

    // Extract all the text from the body
    var bodyText = doc.DocumentNode.SelectSingleNode("//body").InnerText;
    return bodyText;
}

async Task<List<string>> GetLinks(string url)
{
    string html = await client.GetStringAsync(url);
    var doc = new HtmlDocument();
    doc.LoadHtml(html);

    // Extract all links on the page
    var links = doc.DocumentNode
        .SelectNodes("//a[@href]")
        .Select(link => link.GetAttributeValue("href", ""))
        .Where(href => !string.IsNullOrWhiteSpace(href))
        .ToList();

    return links;
}

int CountOccurrences(string pageText, string targetText)
{
    int count = 0;
    int index = 0;

    // Count the occurrences using case-insensitive search
    while ((index = pageText.IndexOf(targetText, index, StringComparison.OrdinalIgnoreCase)) != -1)
    {
        count++;
        index += targetText.Length;
    }

    return count;
}