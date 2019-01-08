using Ninject;
using PokeCatcher.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace PokeCatcher
{
    /// <summary>
    /// Converts a string name to a service pulled from the IoC containter
    /// </summary>
    public class IoCConverter : BaseValueConverter<IoCConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // find the appropriate page
            switch ((string)parameter)
            {
                case nameof(ApplicationViewModel):
                    return IoC.Get<ApplicationViewModel>();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
