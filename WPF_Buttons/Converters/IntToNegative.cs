using System;
using System.Globalization;
using System.Windows.Data;

namespace WPF_Buttons.Converters
{
    [ValueConversion(typeof(int), typeof(int))]
    class NumberToNegative : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return -(int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return -(int)value;
        }
    }
}
