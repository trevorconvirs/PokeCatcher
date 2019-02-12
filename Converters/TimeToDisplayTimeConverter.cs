

using System;
using System.Globalization;
using System.Windows;

namespace PokeCatcher
{
    /// <summary>
    /// Takes in a date a converts into a user friendly time
    /// </summary>
    class TimeToDisplayTimeConverter : BaseValueConverter<TimeToDisplayTimeConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            if (value != null)
            {
                // if this is today
                if (time.Date == DateTimeOffset.UtcNow.Date)
                    // return just time
                    return time.ToLocalTime().ToString("HH:mm");

                // otherwise, return full date
                return time.ToLocalTime().ToString("HH:mm, MM yyyy");

            }
            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
