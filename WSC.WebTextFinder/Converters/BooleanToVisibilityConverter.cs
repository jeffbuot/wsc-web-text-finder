using System.Windows;
using System.Globalization;
using System.Windows.Data;

namespace WSC.WebTextFinder.Converters;

public class BooleanToVisibilityConverter : IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
        if (value is bool boolValue) {
            bool isInverted = parameter as string == "Invert"; 
            return (boolValue ^ isInverted) ? Visibility.Visible : Visibility.Collapsed;
        }
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
        if (value is Visibility visibility) {
            bool isInverted = parameter as string == "Invert";
            return isInverted ? visibility != Visibility.Visible : visibility == Visibility.Visible;
        }
        return false;
    }
}