using System;
using System.Globalization;
using System.Windows.Data;

namespace Core.Converters
{
    public class IntTimeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrEmpty(value.ToString()))
            {
                TimeSpan time = TimeSpan.FromSeconds(int.Parse(value.ToString()));
                return time.ToString(@"hh\:mm\:ss");
            }
            return "0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
