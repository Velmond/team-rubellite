namespace ToDoList.Converters
{
    using System;
    using System.Collections.ObjectModel;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Data;
    using ToDoList.Models;

    public class TagToText:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            StringBuilder result = new StringBuilder();
            foreach (var tag in (value as ObservableCollection<string>))
            {
                result.AppendFormat("#{0}",tag);
            }
            return result.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string[] split = (value as string).Split(
                new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
            return new ObservableCollection<string>(split.AsEnumerable<string>());
        }
    }
}
