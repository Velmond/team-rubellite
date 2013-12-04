namespace ToDoList.Models
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
                    (item as Goal).DeadLine = CorrectGoalDeadLine(item as Goal);
                }

                if ((item as Meeting) != null)
                {
                    (item as Meeting).Beginning = CorrectMeetingBeginning(item as Meeting);
                }

                if ((item as BirthdayReminder) != null)
                {
                    (item as BirthdayReminder).BirthDate = CorrectBirthdayReminderBirthDate(item as BirthdayReminder);
                    (item as BirthdayReminder).DateCreated = CorrectBirthdayReminderDateCreated(item as BirthdayReminder);
                }
            }

            return result;
        }

        private static DateTime CorrectGoalDeadLine(Goal goal)
        {
            if (goal.DeadLine.Day < 12)
            {
                return new DateTime(goal.DeadLine.Year, goal.DeadLine.Day, goal.DeadLine.Month);
            }
            else
            {
                return goal.DeadLine;
            }
        }

        private static DateTime CorrectMeetingBeginning(Meeting meeting)
        {
            if (meeting.Beginning.Day < 12)
            {
                return new DateTime(meeting.Beginning.Year, meeting.Beginning.Day, meeting.Beginning.Month);
            }
            else
            {
                return meeting.Beginning;
            }
        }

        private static DateTime CorrectBirthdayReminderBirthDate(BirthdayReminder birthdayReminder)
        {
            if (birthdayReminder.BirthDate.Day < 12)
            {
                return new DateTime(birthdayReminder.BirthDate.Year, birthdayReminder.BirthDate.Day, birthdayReminder.BirthDate.Month);
            }
            else
            {
                return birthdayReminder.BirthDate;
            }
        }

        private static DateTime CorrectBirthdayReminderDateCreated(BirthdayReminder birthdayReminder)
        {
            if (birthdayReminder.DateCreated.Day < 12)
            {
                return new DateTime(birthdayReminder.DateCreated.Year, birthdayReminder.DateCreated.Day, birthdayReminder.DateCreated.Month);
            }
            else
            {
                return birthdayReminder.DateCreated;
            }
        }
    }
}
