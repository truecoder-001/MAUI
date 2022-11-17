using System.Globalization;
 

namespace ValueConverters.Converters
{
    public class RGBConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var red = System.Convert.ToByte(values[0]);
            var green = System.Convert.ToByte(values[1]);
            var blue = System.Convert.ToByte(values[2]);

           return Color.FromRgb(red, green, blue);

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
