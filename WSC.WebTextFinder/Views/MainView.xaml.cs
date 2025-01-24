using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WSC.WebTextFinder.Views {
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl {
        public MainView() {
            InitializeComponent();
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e) {
            if (sender is Hyperlink hyperlink && hyperlink.NavigateUri != null) {
                Process.Start(new ProcessStartInfo(hyperlink.NavigateUri.AbsoluteUri) { UseShellExecute = true });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

                Process.Start(new ProcessStartInfo("https://www.youtube.com") { UseShellExecute = true });
            
        }
    }
}
