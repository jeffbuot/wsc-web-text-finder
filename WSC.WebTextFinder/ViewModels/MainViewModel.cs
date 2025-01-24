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

namespace WSC.WebTextFinder.ViewModels;
public class MainViewModel : ViewModelBase {

    public ICommand ClearLogsCommand { get; }

    public ICommand SearchCommand { get; }
    public ICommand AddLogCommand { get; }
    public ICommand OpenHyperlinkCommand { get; }

    public MainViewModel() {
        ClearLogsCommand = new RelayCommand(ClearLogs);
        AddLogCommand = new RelayCommand(() => AddLog("Test"));
        OpenHyperlinkCommand = new RelayCommand<string>(OpenHyperlink);
        SearchCommand = new AsyncRelayCommand(StartSearch);
    }

    private async Task StartSearch() {

        SearchButtonText = "Validating ...";
        IsValidUrl = await ValidateUrl(WebsiteUrl);
        IsValidKeyword = !string.IsNullOrEmpty(SearchKeyword);

        SearchButtonText = "Search";
        if (!(IsValidUrl && IsValidKeyword)) return;

        SearchButtonText = "Searching...";

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

    public void AddLog(string message) {
        var paragraph = new Paragraph();
        var run = new Run(message) {
            //Foreground = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFromString(color)
        };
        var url = "https://stackoverflow.com/questions/325075/how-do-i-change-richtextbox-paragraph-spacing";
        var textLink = new Hyperlink(new Run(url)) {
            Command = OpenHyperlinkCommand,
            CommandParameter = url
        };

        paragraph.Inlines.Add(run);
        paragraph.Inlines.Add(textLink);
        LogMessages.Add(paragraph);
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
    public void ClearLogs() {
        LogMessages.Clear();
    }
}
