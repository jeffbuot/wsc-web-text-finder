using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using WSC.WebTextFinder.Core;
using System.Diagnostics;
using System.Windows.Media;
using System.Windows;
using System.Net;
using WSC.WebTextFinder.Services;
using System.Drawing;

namespace WSC.WebTextFinder.ViewModels;
public class MainViewModel : ViewModelBase {

    public ICommand ClearLogsCommand { get; }
    public ICommand SearchCommand { get; }
    public ICommand CancelSearchCommand { get; }
    public ICommand OpenHyperlinkCommand { get; }

    public HttpCrawlerService CrawlerService { get; }

    public MainViewModel() {
        ClearLogsCommand = new RelayCommand(ClearLogs);
        //AddLogCommand = new RelayCommand(() => AddLog("Test"));
        OpenHyperlinkCommand = new RelayCommand<string>(OpenHyperlink);
        SearchCommand = new AsyncRelayCommand(StartSearch);
        CrawlerService = ServiceLocator.Resolve<HttpCrawlerService>();
        CrawlerService.SearchProgressUpdate += CrawlerService_SearchProgressUpdate;
        ClearLogsCommand = new RelayCommand(() => { });
    }

    private void CrawlerService_SearchProgressUpdate(object sender, SearchProgressUpdateEventArgs arg) {
        if (arg.State == SearchProgressState.Visiting) {
            var paragraph = new Paragraph();

            var textLink = new Hyperlink(new Run(arg.Url)) {
                Command = OpenHyperlinkCommand,
                CommandParameter = arg.Url
            };

            paragraph.Inlines.Add(new Run("Visiting "));
            paragraph.Inlines.Add(textLink);
            paragraph.Inlines.Add(new Run("."));
            LogMessages.Add(paragraph);
        }
        else if (arg.State == SearchProgressState.KeywordFound) {
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(new Run($"Found keword {arg.Keyword} with {arg.MatchCount} {(arg.MatchCount > 1 ? "match" : "matches")} in "));
            paragraph.Inlines.Add(new Hyperlink(new Run(arg.Url)) {
                Command = OpenHyperlinkCommand,
                CommandParameter = arg.Url
            });
            paragraph.Inlines.Add(new Run("."));
            LogMessages.Add(paragraph);
        }
        else if (arg.State == SearchProgressState.Error) {
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(new Run("Error :"));
            paragraph.Inlines.Add(new Run(arg.ErrorMessage) {
                Foreground = new BrushConverter().ConvertFromString("#f5425d") as Brush
            });
            LogMessages.Add(paragraph);
        }
    }

    private async Task StartSearch() {

        SearchButtonText = "Validating ...";
        IsValidUrl = await ValidateUrl(WebsiteUrl);
        IsValidKeyword = !string.IsNullOrEmpty(SearchKeyword);

        SearchButtonText = "Search";
        if (!(IsValidUrl && IsValidKeyword)) return;

        SearchButtonText = "Searching...";
        IsProcessing = true;

        var paragraph = new Paragraph();
        paragraph.Inlines.Add(new Run($"Searching match for '{SearchKeyword}' to website "));
        paragraph.Inlines.Add(new Hyperlink(new Run(WebsiteUrl)) {
            Command = OpenHyperlinkCommand,
            CommandParameter = WebsiteUrl
        });

        LogMessages.Add(paragraph);

        await CrawlerService.SearchKeyword(WebsiteUrl, SearchKeyword);
        IsProcessing = false;
        SearchButtonText = "Search";
    }
    private async Task<bool> ValidateUrl(string url) {
        if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) ||
            (uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps)) {
            return false;
        }
        return await Task.Run(() => {
            try {
                IPHostEntry entry = Dns.GetHostEntry(uriResult.Host);
                return entry.AddressList.Length > 0;
            }
            catch {
                return false;
            }
        });
    }

    private void OpenHyperlink(string url) {
        if (!string.IsNullOrEmpty(url)) {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }

    public ObservableCollection<Paragraph> LogMessages { get; } = new();

    private string _websiteUrl;
    public string WebsiteUrl {
        get => _websiteUrl;
        set => SetProperty(ref _websiteUrl, value);
    }

    private string _searchKeyword;
    public string SearchKeyword {
        get => _searchKeyword;
        set => SetProperty(ref _searchKeyword, value);
    }

    private string _searchButtonText = "Search";
    public string SearchButtonText {
        get => _searchButtonText;
        set => SetProperty(ref _searchButtonText, value);
    }

    private bool _isValidKeyword = true;
    public bool IsValidKeyword {
        get => _isValidKeyword;
        set => SetProperty(ref _isValidKeyword, value);
    }

    private bool _isValidUrl = true;
    public bool IsValidUrl {
        get => _isValidUrl;
        set => SetProperty(ref _isValidUrl, value);
    }

    private bool _isMatchCase;
    public bool IsMatchCase {
        get => _isMatchCase;
        set => SetProperty(ref _isMatchCase, value);
    }

    private bool _isProcessing;
    public bool IsProcessing {
        get => _isProcessing;
        set => SetProperty(ref _isProcessing, value);
    }
    public void ClearLogs() {
        LogMessages.Clear();
    }
}
