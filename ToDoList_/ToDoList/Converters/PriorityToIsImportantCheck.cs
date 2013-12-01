﻿namespace ToDoList.Converters
{
    using System;
    using System.Windows.Data;
    using System.Windows.Media;
    using System.Globalization;
    using ToDoList.Models;

    public class PriorityToIsImportantCheck : IValueConverter
    {
        /// <summary>
        /// Converts Priority to bool values
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Urgent, Important":
                case "Important":
                    return true;
                default:
                    return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
                return Priority.Important;
        }
    }
}