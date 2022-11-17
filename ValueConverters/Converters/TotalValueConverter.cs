using System.Globalization;

namespace ValueConverters.Converters
{
    public class TotalValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int result;
            try
            {
                int firstNumber, secondNumber, thirdNumber;

                int.TryParse(values[0].ToString(), out firstNumber);
                int.TryParse(values[1].ToString(), out secondNumber);
                int.TryParse(values[2].ToString(), out thirdNumber);

                result = firstNumber + secondNumber + thirdNumber;
            }
            catch (Exception)
            {

                throw;
            }


            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
