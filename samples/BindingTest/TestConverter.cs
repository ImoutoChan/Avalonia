using System;
using System.Globalization;
using Avalonia.Markup;
using Avalonia.Media;

namespace BindingTest
{
    class TestConverter : IValueConverter
    {
        public static TestConverter Instance { get; } = new TestConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new SolidColorBrush(Colors.AliceBlue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
