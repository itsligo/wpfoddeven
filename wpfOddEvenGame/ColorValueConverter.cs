using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace wpfOddEvenGame
{
    public class SliderValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int sldValue = Int32.Parse(value.ToString());
            if (sldValue<3) return new SolidColorBrush(Colors.AntiqueWhite);
            if (sldValue<6) return new SolidColorBrush(Colors.Beige);
            if (sldValue < 8) return new SolidColorBrush(Colors.BurlyWood);
            if (sldValue<11) return new SolidColorBrush(Colors.DarkCyan);
            return new SolidColorBrush(Colors.DarkCyan);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
