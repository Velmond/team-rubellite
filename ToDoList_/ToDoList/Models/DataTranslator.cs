﻿namespace ToDoList.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Xml.Serialization;
    using TodoListConsole;

    /// <summary>
    /// Class that allows implementing serialization and deserialization of objects of type T
    /// </summary>
    /// <typeparam name="T">Type derived from BaseObjectModel</typeparam>
    class DataTranslator<T> where T : BaseObjectModel
    {
        private static readonly string path = @"..\..\Data\";

        /// <summary>
        /// Serializes the data from a viewmodel to an *.xml file
        /// </summary>
        /// <param name="list">Collection of objects to be serialized</param>
        public static void Serialize(ObservableCollection<T> list)
        {
            XmlSerializer seri = new XmlSerializer(typeof(ObservableCollection<T>));

            using (TextWriter writer = new StreamWriter(path + (typeof(T).ToString()) + ".xml"))
            {
                seri.Serialize(writer, list);
            }
        }

        /// <summary>
        /// Deserializes an *.xml file and turns it into a collection of elements
        /// </summary>
        /// <returns>A collection of objects of type T</returns>
        public static ObservableCollection<T> Deserialize()
        {
            ObservableCollection<T> result = new ObservableCollection<T>();
            XmlSerializer deseri = new XmlSerializer(typeof(ObservableCollection<T>));

            if (!File.Exists(path + (typeof(T).ToString()) + ".xml"))
            {
                Serialize(new ObservableCollection<T>());
            }

            using (TextReader reader = new StreamReader(path + (typeof(T).ToString()) + ".xml"))
            {
                result = deseri.Deserialize(reader) as ObservableCollection<T>;
            }

            foreach (var item in result)
            {
                if ((item as Goal) != null)
                {
                    (item as Goal).DeadLine = CorrectDate((item as Goal).DeadLine);
                }

                if ((item as Meeting) != null)
                {
                    (item as Meeting).Beginning = CorrectDate((item as Meeting).Beginning);
                }

                if ((item as BirthdayReminder) != null)
                {
                    (item as BirthdayReminder).BirthDate = CorrectDate((item as BirthdayReminder).BirthDate);
                    (item as BirthdayReminder).DateCreated = CorrectDate((item as BirthdayReminder).DateCreated);
                }
            }

            return result;
        }

        private static DateTime CorrectDate(DateTime date)
        {
            if (date.Day < 12)
            {
                return new DateTime(date.Year, date.Day, date.Month);
            }
            else
            {
                return date;
            }
        }
    }
}