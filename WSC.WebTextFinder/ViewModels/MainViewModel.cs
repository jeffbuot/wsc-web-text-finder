using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSC.WebTextFinder.Core;

namespace WSC.WebTextFinder.ViewModels;
public class MainViewModel : ViewModelBase {

    public MainViewModel() {
    }

    private string _websiteUrl;
    public string WebsiteUrl {
        get => _websiteUrl;
        set => SetProperty(ref _websiteUrl, value);
    }

}
