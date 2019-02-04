﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace TumblThree.Presentation.Converters
{
    public class IntToDisplayValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var number = (int)value;
            return number != 0 ? (object)number : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var displayValue = value as string;
            return string.IsNullOrEmpty(displayValue) ? 0 : int.Parse(displayValue, CultureInfo.CurrentCulture);
        }
    }
}
