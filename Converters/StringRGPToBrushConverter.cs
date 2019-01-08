using System;
using System.Globalization;
using System.Windows.Media;

namespace PokeCatcher
{
    /// <summary>
    /// A converter that takes in a RGB string such as FF00FF and converts it to a WPF brush
    /// </summary>
    class StringRGPToBrushConverter : BaseValueConverter<StringRGPToBrushConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#{value}"));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
