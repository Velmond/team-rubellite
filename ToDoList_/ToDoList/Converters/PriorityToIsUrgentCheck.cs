namespace ToDoList.Converters
{
    using System;
    using System.Windows.Data;
    using System.Windows.Media;
    using System.Globalization;
    using ToDoList.Models;

    public class PriorityToIsUrgentCheck : IValueConverter
    {
        /// <summary>
        /// Convert priority to bool value.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Urgent, Important":
                case "Urgent":
                    return true;
                default:
                    return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
                return Priority.Urgent;
        }
    }
}
