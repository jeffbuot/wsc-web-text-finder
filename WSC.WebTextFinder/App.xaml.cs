using System.Configuration;
using System.Data;
using System.Windows;
using WSC.WebTextFinder.Core;
using WSC.WebTextFinder.Services;
using WSC.WebTextFinder.ViewModels;

namespace WSC.WebTextFinder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            // REFACTOR: Need to improve into function based, instance should be stored first then accessed.
            // This will cause issue of order in accessing other service from constructor.
            ServiceLocator.RegisterSingleton(new HttpCrawlerService());
            ServiceLocator.RegisterSingleton(new MainViewModel());
            ServiceLocator.RegisterSingleton(new NZPostCodeViewModel());
            ServiceLocator.RegisterSingleton(new WebTextSearchViewModel());
            //ServiceLocator.RegisterTransient(() => new TransientViewModel()); // Transient registration

        }
    }

}
