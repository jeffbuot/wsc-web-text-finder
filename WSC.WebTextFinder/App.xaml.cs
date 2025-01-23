using System.Configuration;
using System.Data;
using System.Windows;
using WSC.WebTextFinder.Core;
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
            ServiceLocator.RegisterSingleton(new MainViewModel()); 
            //ServiceLocator.RegisterTransient(() => new TransientViewModel()); // Transient registration

        }
    }

}
