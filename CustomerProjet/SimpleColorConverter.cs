using System.Globalization;

namespace SharedComponent;

public class SimpleColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        int batteryLevel = (int)value;

        if (batteryLevel < 25)
            return Colors.Red;
        else if (batteryLevel < 50)
            return Colors.Orange;
        else if (batteryLevel < 75)
            return Colors.Yellow;
        else
            return Colors.GreenYellow;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

