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
        public MainView(Frame mainFrame) {
            InitializeComponent();
            MainFrame = mainFrame;
        }

        public Frame MainFrame { get; }

        private void Border_MouseLeftButtonUp_NZPostcodes(object sender, MouseButtonEventArgs e) {
            MainFrame.Navigate(new NZPostCodeView());
        }

        private void Border_MouseLeftButtonUp_TextFinder(object sender, MouseButtonEventArgs e) {
            MainFrame.Navigate(new WebTextSearchView());

        }
    }
}
