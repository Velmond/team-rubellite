namespace ToDoList.Converters
{
    using System;
    using System.Windows.Data;
    using ToDoList.Models;

    class DoneToStrikethrough:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value)
            {
                return "Strikethrough";
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
