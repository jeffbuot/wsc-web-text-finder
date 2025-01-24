using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WSC.WebTextFinder.Services {

    public class HttpCrawlerService {

        public delegate void SearchProgressUpdateEventHandler(object sender, SearchProgressUpdateEventArgs arg);

        public event SearchProgressUpdateEventHandler SearchProgressUpdate;

        private readonly HttpClient _httpClient;
        private Queue<string> _urlsToVisit;
        public HashSet<string> VisitedUrls { get; set; } = new HashSet<string>();
        public HttpCrawlerService() {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

            _urlsToVisit = new Queue<string>();
        }

        public async Task SearchKeywordAsync(string webUrl, string keyword, bool isMatchCase = false, CancellationToken cancellationToken = default) {
            VisitedUrls.Clear();
            _urlsToVisit.Clear();
            int totalMatches = 0;
            _urlsToVisit.Enqueue(webUrl);

            // Ensure that the web url does not ends with /
            if (webUrl.EndsWith("/")) {
                webUrl = webUrl.TrimEnd('/');
            }

            while (_urlsToVisit.Count > 0) {
                var currentUrl = _urlsToVisit.Dequeue();
                if (cancellationToken.IsCancellationRequested) {
                    OnSearchProgressUpdate(SearchProgressState.Interrupted, currentUrl, keyword);
                    return;
                }

                if (VisitedUrls.Contains(currentUrl))
                    continue;

                VisitedUrls.Add(currentUrl);
                //Console.WriteLine($"Visiting: {currentUrl}");
                OnSearchProgressUpdate(SearchProgressState.Visiting, currentUrl, keyword);

                try {
                    var pageText = await GetPageText(currentUrl);
                    var matchCount = CountOccurrences(pageText, keyword);
                    // Search for the target text
                    // if (pageText.Contains(keyword, StringComparison.OrdinalIgnoreCase)) 
                    if (matchCount > 0) {

                        //Console.WriteLine($"Found '{keyword}' {count} times on page: {currentUrl}");
                        OnSearchProgressUpdate(SearchProgressState.KeywordFound, currentUrl, keyword, matchCount);
                        totalMatches += matchCount;
                    }


                    var links = await GetLinks(currentUrl);

                    foreach (var link in links.Where(link =>
                                 !VisitedUrls.Contains(link) && link.StartsWith("/") || link.StartsWith(webUrl))) {
                        _urlsToVisit.Enqueue(link.StartsWith("/") ? $"{webUrl}{link}" : link);
                    }


                }
                catch (Exception ex) {
                    //Console.WriteLine($"Error fetching {currentUrl}: {ex.Message}");
                    OnSearchProgressUpdate(SearchProgressState.Error, currentUrl, keyword, errorMessage: ex.Message);
                }
            }

            OnSearchProgressUpdate(SearchProgressState.Done, webUrl, keyword, totalMatches);
        }

        public void OnSearchProgressUpdate(SearchProgressState state, string url, string keyword, int matchCount = 0, string errorMessage = "") {
            SearchProgressUpdate?.Invoke(this, new SearchProgressUpdateEventArgs(state, url, keyword, matchCount, errorMessage));
        }
        private async Task<string> GetPageText(string url) {
            var html = await _httpClient.GetStringAsync(url);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            // Extract all the text from the body
            var bodyText = doc.DocumentNode.SelectSingleNode("//body").InnerText;
            return bodyText;
        }

        private async Task<List<string>> GetLinks(string url) {
            var html = await _httpClient.GetStringAsync(url);
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

        private int CountOccurrences(string pageText, string keyword, bool isMatchCase = false) {
            var count = 0;
            var index = 0;

            // Count the occurrences using case-insensitive search
            while ((index = pageText.IndexOf(keyword, index, isMatchCase ?
                StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase)) != -1) {
                count++;
                index += keyword.Length;
            }

            return count;
        }
    }

    public enum SearchProgressState {
        Visiting, KeywordFound, Done, Interrupted, Error
    }

    public class SearchProgressUpdateEventArgs : EventArgs {
        public string Url { get; set; }
        public string Keyword { get; set; }
        public int MatchCount { get; set; }
        public string ErrorMessage { get; set; }
        public SearchProgressState State { get; set; }

        public SearchProgressUpdateEventArgs(SearchProgressState state, string url, string keyword, int matchCount = 0, string errorMessage = "") {
            Url = url;
            Keyword = keyword;
            MatchCount = matchCount;
            State = state;
            ErrorMessage = errorMessage;
        }
    }
}
