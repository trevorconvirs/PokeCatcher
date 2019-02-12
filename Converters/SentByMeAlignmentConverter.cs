

using System;
using System.Globalization;
using System.Windows;

namespace PokeCatcher
{
    /// <summary>
    /// Takes in a boolean if a message was sent by me and aligns to right
    /// if not sent by me aligns to the left
    /// </summary>
    class SentByMeAlignmentConverter : BaseValueConverter<SentByMeAlignmentConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
