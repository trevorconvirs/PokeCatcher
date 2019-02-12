

using System;
using System.Globalization;
using System.Windows;

namespace PokeCatcher
{
    /// <summary>
    /// Converter takes in boolean if a message was sent by me, and returns the
    /// correct background color
    /// </summary>
    class SentByMeBackgroundConverter : BaseValueConverter<SentByMeBackgroundConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Application.Current.FindResource("VeryLightBlueBrush"): Application.Current.FindResource("ForegroundLightBrush");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
