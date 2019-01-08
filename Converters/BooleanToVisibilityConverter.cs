

using System;
using System.Globalization;
using System.Windows;

namespace PokeCatcher
{
    /// <summary>
    /// A converter that takes in a boolean and rerurns a <see cref="Visibility"/>
    /// </summary>
    class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return (bool)value ? Visibility.Hidden : Visibility.Visible;
            else
                return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
