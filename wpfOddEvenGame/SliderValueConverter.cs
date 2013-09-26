using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace wpfOddEvenGame
{
    public class SliderValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int sliderValue = Int32.Parse(value.ToString());
            if (sliderValue < 3) return new SolidColorBrush(Colors.Cornsilk);
            if (sliderValue < 6) return new SolidColorBrush(Colors.DarkCyan);
            if (sliderValue < 8) return new SolidColorBrush(Colors.DarkGoldenrod);
            return new SolidColorBrush(Colors.CornflowerBlue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
