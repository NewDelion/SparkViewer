using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SparkViewer.converter
{
    public class TotalUsersConv : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return string.Format("ユーザ数：{0}", (int)value);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string v = value as string;
            if (v.Length < 6)
                return 0;
            return int.Parse(v.Substring(6));
        }
    }
}
